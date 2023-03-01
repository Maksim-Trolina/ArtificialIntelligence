using System;
using System.Collections.Generic;
using System.Linq;
using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.BeeAlgorithm.Algorithm
{
    public class BeeAlgorithmLogic
    {
        private readonly MathParser _parser = new();
        private readonly Random _random = new();

        public double[] GetResultArguments(
            int countElitePoint,
            int countIterations,
            int countEliteBees,
            int countDefaultBees,
            int countLocalSearchPoints,
            string expression,
            double delta,
            int countScoutBees,
            double lowerBound,
            double upperBound)
        {

            _parser.InitializeExpression(expression);

            int argumentsCount = _parser.GetArgumentsNumber();

            List<double[]> points = CreateRandomPoints(countScoutBees, lowerBound, upperBound, argumentsCount)
                .OrderBy(p => GetResult(p))
                .ToList();


            for (int iterationIndex = 0; iterationIndex < countIterations; iterationIndex++)
            {
                SearchBestPoints(
                    countEliteBees,
                    delta,
                    countLocalSearchPoints,
                    countDefaultBees,
                    points, countElitePoint);

                points = CreateRandomPoints(countScoutBees, lowerBound, upperBound, argumentsCount)
                    .OrderBy(p => GetResult(p))
                    .ToList();
            }

            return points.First();
        }

        public double GetResult(double[] arguments)
        {
            return _parser.CalculateFunctionValue(arguments);
        }

        public string[] GetNamesArguments()
        {
            int argumentsCount = _parser.GetArgumentsNumber();
            List<string> argumentNames = new();

            for (int argumentIndex = 0; argumentIndex < argumentsCount; argumentIndex++)
            {
                argumentNames.Add(_parser.ArgumentName(argumentIndex));
            }

            return argumentNames.ToArray();
        }
        private bool IsNewSolutionBest(double[] newSolution, double[] oldSolution)
        {
            return GetResult(newSolution) < GetResult(oldSolution);
        }

        private void SearchBestPoints(
            int countEliteBees,
            double delta,
            int countLocalSearchPoints,
            int countDefaultBees,
            List<double[]> points,
            int countElitePoint)
        {
            for (int pointIndex = 0; pointIndex < countLocalSearchPoints; pointIndex++)
            {
                int countBees = GetCountBees(pointIndex, countElitePoint, countEliteBees, countDefaultBees);

                double[] tempPoint = points[pointIndex];

                for (int beeIndex = 0; beeIndex < countBees; beeIndex++)
                {
                    double[] randomCoordinatiesPoint
                        = CreateRandomCoordinatiesPoint(tempPoint, delta);

                    if (IsNewSolutionBest(randomCoordinatiesPoint, points[pointIndex]))
                    {
                        tempPoint = randomCoordinatiesPoint;
                    }
                }

                points[pointIndex] = tempPoint;
            }
        }
        
        private int GetCountBees(int pointIndex, int countElitePoint, int countEliteBees, int countDefaultBees)
        {
            return pointIndex < countElitePoint ? countEliteBees : countDefaultBees;
        }
        private double[] CreateRandomCoordinatiesPoint(double[] coordinaties, double delta)
        {
            List<double> randomLocalityArguments = new();

            for (int i = 0; i < coordinaties.Length; i++)
            {
                double randomLocalityArgument = (coordinaties[i] - delta) + 2 * _random.NextDouble() * delta;
                randomLocalityArguments.Add(randomLocalityArgument);
            }

            return randomLocalityArguments.ToArray();
        }

        private double[] CreateRandomPoint(double lowerBound, double upperBound, int countArgument)
        {
            List<double> randomCoordinaties = new();

            for(int argumentIndex = 0; argumentIndex < countArgument; argumentIndex++)
            {
                double delta = upperBound - lowerBound;
                double randomCoordinate = lowerBound + _random.NextDouble() * delta;
                randomCoordinaties.Add(randomCoordinate);
            }

            return randomCoordinaties.ToArray();
        }

        private List<double[]> CreateRandomPoints(int countRandomPoints, double lowerBound, double upperBound, int countArgument)
        {
            List<double[]> randomPoints = new();

            for(int i = 0; i < countRandomPoints; i++)
            {
                double[] randomPoint = CreateRandomPoint(lowerBound, upperBound, countArgument);
                randomPoints.Add(randomPoint);
            }

            return randomPoints;
        }
    }
}
