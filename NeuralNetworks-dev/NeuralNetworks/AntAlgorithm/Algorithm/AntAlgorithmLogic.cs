using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuralNetworks.AntAlgorithm.UI;

namespace NeuralNetworks.AntAlgorithm.Algorithm
{
    public class AntAlgorithmLogic
    {
        private readonly List<Ant> _ants = new();
        private readonly Random _random = new();

        private readonly double _alphaCoefficient;
        private readonly double _betaCoefficient;

        public AntAlgorithmLogic(int alpha, int beta)
        {
            _alphaCoefficient = alpha;
            _betaCoefficient = beta;
        }
        
        private void InitializeAnts(int countAnts, int countVertex)
        {
            for (int antIndex = 0; antIndex < countAnts; antIndex++)
            {
                int randomVertex = _random.Next(countVertex);
                _ants.Add(new Ant(randomVertex));
            }
        }

        public double WeightSum(List<int> path, MatrixCell[,] matrix)
        {
            return path.Select((vertex, vertexIndex) => matrix[vertex, path[(vertexIndex + 1) % path.Count]])
                .Sum(cell => cell.Weight);
        }
        
        public List<int> HamiltonCycle(MatrixCell[,] matrix)
        {
            List<int> cycle = new() { 0 };

            for (var iterationIndex = 0; iterationIndex < matrix.GetLength(0); iterationIndex++)
            {
                var lastVertex = cycle.Last();

                var maxPheromoneIndex = lastVertex;

                for (var vertex = 0; vertex < matrix.GetLength(0); vertex++)
                {
                    if (!cycle.Contains(vertex) && matrix[lastVertex, maxPheromoneIndex].Pheromone < matrix[lastVertex, vertex].Pheromone)
                    {
                        maxPheromoneIndex = vertex;
                    }
                }

                if (lastVertex != maxPheromoneIndex)
                {
                    cycle.Add(maxPheromoneIndex);
                }
            }

            return cycle;
        }
        
        public Task RunAlgorithm(int countIteration, int countAnts, MatrixCell[,] matrix, double evaporationRate, double q)
        {
            int countVertex = matrix.GetLength(0);
            for (var iterationIndex = 0; iterationIndex < countIteration; iterationIndex++)
            {
                InitializeAnts(countAnts, countVertex);

                var cyclePathAnts = new List<Ant>();

                foreach (var ant in _ants)
                {
                    var startedVertex = ant.GetObservedVertices().First();
                    int currentVertex;

                    do
                    {
                        currentVertex = GetNextVertex(matrix, ant, countVertex);

                        if (currentVertex != -1)
                        {
                            ant.AddVertex(currentVertex);
                        }

                    } while (currentVertex != -1);

                    int endVertex = ant.GetObservedVertices().Last();

                    if (matrix[endVertex, startedVertex].IsValid())
                    {
                        cyclePathAnts.Add(ant);
                    }
                }

                FillPheramones(matrix, countVertex, evaporationRate, cyclePathAnts, q);
            }

            return Task.CompletedTask;
        }

        private void FillPheramones(MatrixCell[,] matrix, int countVertex, double evaporationRate, List<Ant> ants, double q)
        {
            for (var fromVertex = 0; fromVertex < countVertex; fromVertex++)
            {
                for (var toVertex = 0; toVertex < countVertex; toVertex++)
                {
                    var sumDeltaPheromone = ants.Sum(ant => ant.IsEdgeViewed(fromVertex, toVertex) ? q / WeightSum(ant.GetObservedVertices(), matrix) : 0);
                    matrix[fromVertex, toVertex].Pheromone = (1 - evaporationRate) * matrix[fromVertex, toVertex].Pheromone + sumDeltaPheromone;
                }
            }
        }
        private int GetNextVertex(MatrixCell[,] matrix, Ant ant, int countVertex)
        {
            var startedVertex = ant.GetObservedVertices().Last();
            var adjacencyVertexes = GetAdjacencyVertexes(matrix, countVertex, ant, startedVertex);


            if (adjacencyVertexes.Count == 0)
            {
                return -1;
            }

            var probabilities = adjacencyVertexes.Select(t => GetProbabilityMove(startedVertex, t, matrix, ant, countVertex)).ToList();

            List<double> points = GetPoints(probabilities);

            return GetNextVertex(points, adjacencyVertexes);
        }

        private int GetNextVertex(List<double> points, List<int> adjacencyVertexes)
        {
            var randomPoint = _random.NextDouble();
            var vertexIndex = 1;

            while (vertexIndex < points.Count && points[vertexIndex] < randomPoint)
            {
                vertexIndex++;
            }

            return adjacencyVertexes[vertexIndex - 1];
        }
        private List<double> GetPoints(List<double> probabilities)
        {
            List<double> points = new() { 0 };

            for (var i = 1; i < probabilities.Count + 1; i++)
            {
                double point = points.Last() + probabilities[i - 1];
                points.Add(point);
            }

            return points;
        }
        private List<int> GetAdjacencyVertexes(MatrixCell[,] matrix, int countVertex, Ant ant, int fromVertex)
        {
            var adjacencyVertexes = new List<int>();
            for (var vertex = 0; vertex < countVertex; vertex++)
            {
                if (matrix[fromVertex, vertex].IsValid() && !ant.IsVertexObserved(vertex))
                {
                    adjacencyVertexes.Add(vertex);
                }
            }

            return adjacencyVertexes;
        }
        private double GetProbabilityMove(int fromVertex, int toVertex, MatrixCell[,] matrix, Ant ant, int countVertex)
        {
            double sum = 0;

            for (var vertex = 0; vertex < countVertex; vertex++)
            {
                sum = ant.IsVertexObserved(vertex) ? sum : 
                    sum + GetMovementWeight(matrix[fromVertex, vertex]);
            }

            return GetMovementWeight(matrix[fromVertex, toVertex]) / sum;
        }

        private double GetMovementWeight(MatrixCell matrixCell)
        {
            return Math.Pow(1 / matrixCell.Weight, _betaCoefficient) * Math.Pow(matrixCell.Pheromone, _alphaCoefficient);
        }
    }
}
