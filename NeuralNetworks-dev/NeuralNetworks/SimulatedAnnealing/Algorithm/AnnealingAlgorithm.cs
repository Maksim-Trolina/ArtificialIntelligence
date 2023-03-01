using System;
using System.Collections.Generic;

namespace NeuralNetworks.SimulatedAnnealing.Algorithm
{
    public class AnnealingAlgorithm
    {
        private readonly Random _random = new();
        
        public double GetPathWeight(double[,] graph, List<int> path)
        {
            double weight = 0;

            for (int i = 0; i < path.Count; i++)
            {
                weight += graph[path[i], path[(i + 1) % path.Count]];
            }

            return weight;
        }

        public List<int> GetBestPath(
            double[,] graph,
            double maxTemperature,
            double minTemperature,
            double coefficientC)
        {
            var currentTemperature = maxTemperature;
            int iterationNumber = 0;
            List<int> bestPath = CreateInitialPath(graph.GetLength(0));

            while (currentTemperature > minTemperature)
            {
                var newPath = CreateNewPath(bestPath);

                iterationNumber++;

                double weightNewPath = GetPathWeight(graph, newPath);
                double weightOldPath = GetPathWeight(graph, bestPath);
                double deltaWeightPath = weightNewPath - weightOldPath;

                currentTemperature = GetTemperature(maxTemperature, iterationNumber);

                if (weightNewPath < weightOldPath)
                {
                    bestPath = newPath;
                }
                else
                {
                    double probability = TransitionStateProbability(coefficientC, deltaWeightPath, currentTemperature);

                    if (IsProbabilityWorked(probability, coefficientC))
                    {
                        bestPath = newPath;
                    }
                }
            }

            return bestPath;
        }

        private bool IsProbabilityWorked(double probability, double coefficientC)
        {
            return probability > coefficientC * _random.NextDouble();
        }
        private double GetTemperature(double maxTemperature, int iterationNumber)
        {
            return maxTemperature / iterationNumber;
        }

        private List<int> CreateInitialPath(int countVertex)
        {
            List<int> path = new();

            for (int currentVertexNum = 0; currentVertexNum < countVertex; currentVertexNum++)
            {
                int randomVertex;
                do
                {
                    randomVertex = _random.Next(countVertex);

                } while (path.Contains(randomVertex));

                path.Add(randomVertex);
            }

            return path;
        }

        private double TransitionStateProbability(double coefficientC, double deltaWeightPath, double temperature)
        {
            return coefficientC * Math.Pow(Math.E, -deltaWeightPath / temperature);
        }

        private List<int> CreateNewPath(List<int> oldPath)
        {
            List<int> newPath = new(oldPath);

            int index1 = _random.Next(oldPath.Count);
            int index2 = _random.Next(oldPath.Count);

            var tempVertex = newPath[index1];

            newPath[index1] = newPath[index2];
            newPath[index2] = tempVertex;

            return newPath;
        }

        
    }
}
