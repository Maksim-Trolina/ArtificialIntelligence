using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Mutation.Real
{
    public class RandomMutation : IMutation
    {
        private double _probability;
        private readonly Random _random = new();
        public RandomMutation(double probability)
        {
            _probability = probability;
        }
        public void Mutate(List<Chromosome> population)
        {
            foreach (var chromosome in population)
            {
                for (int i = 0; i < chromosome.Gens.Length; i++)
                {
                    if (IsMutationWorked())
                    {
                        chromosome.Gens[i] += GetNewGen();
                    }
                }
            }
        }

        private bool IsMutationWorked()
        {
            return _probability > _random.NextDouble();
        }

        private double GetNewGen()
        {
            return _random.NextDouble() - 0.5;
        }
    }
}
