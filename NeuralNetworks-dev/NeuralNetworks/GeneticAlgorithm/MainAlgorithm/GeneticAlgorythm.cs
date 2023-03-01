using NeuralNetworks.GeneticAlgorithm.Contracts;
using System.Collections.Generic;
using System.Linq;
using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.GeneticAlgorithm.MainAlgorithm
{
    public class GeneticAlgorythm
    {       
        private readonly ICrossing _crossover;       
        private readonly MathParser _parser;
        private readonly ISelection _selector;
        private readonly IMutation _mutator;

        public GeneticAlgorythm
            (                               
                ISelection selector,
                IMutation mutator,
                ICrossing crossover
            )
        {
            _mutator = mutator;
            _crossover = crossover;
            _selector = selector;
            _parser = new MathParser();
        }

        public double CalculateSignificance(double[] values) => _parser.CalculateFunctionValue(values);

        public double[] GetResultArguments(string expression
            , int countStartedPopulation
            , int countGenerations
            , int numberSurvived)
        {
            _parser.InitializeExpression(expression);

            List<Chromosome> population = CreateInitialPopulation(countStartedPopulation);

            for (int i = 0; i < countGenerations; i++)
            {
                population = GetNextGeneration(population, numberSurvived);
            }

            var resultArguments = population.OrderBy(chromosome => CalculateSignificance(chromosome.Gens))
                .First().Gens;

            return resultArguments;
        }

        public string[] GetNamesArguments()
        {
            string[] names = new string[_parser.GetArgumentsNumber()];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = _parser.ArgumentName(i);
            }

            return names;
        }

        private List<Chromosome> GetNextGeneration(List<Chromosome> population, int numberSurvived)
        {
            List<Chromosome> selectedPopulation = Select(population, numberSurvived);

            var nextGeneration = new List<Chromosome>(selectedPopulation);

            for (int i = 1; i < selectedPopulation.Count; i += 2)
            {
                var childrens = _crossover.Cross(selectedPopulation[i], selectedPopulation[i - 1]);
                _mutator.Mutate(childrens);
                nextGeneration.AddRange(childrens);
            }

            if (selectedPopulation.Count % 2 != 0)
            {
                nextGeneration.Add(selectedPopulation.Last());
            }

            return nextGeneration;
        }
        private List<Chromosome> Select(List<Chromosome> population, int numberSurvived)
        {
            List<Chromosome> selectionChromosome = _selector.Select(population, CalculateSignificance, numberSurvived);
            return selectionChromosome;
        }
        private List<Chromosome> CreateInitialPopulation(int populationSize)
        {
            List<Chromosome> population = new();

            for (int i = 0; i < populationSize; i++)
            {
                population.Add(new Chromosome(_parser.GetArgumentsNumber()));
            }

            return population;
        }
    }
}
