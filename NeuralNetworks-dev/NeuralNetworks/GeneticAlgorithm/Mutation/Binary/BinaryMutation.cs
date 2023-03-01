using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.Mutation.Binary
{
    public class BinaryMutation : IMutation
    {
        private readonly Random _random = new();
        private double _probability;

        public BinaryMutation(double probabilityMutation)
        {
            _probability = probabilityMutation;
        }

        public void Mutate(List<Chromosome> population)
        {
            for (int i = 0; i < population.Count; i++)
            {
                var bits = population[i].ToBits();

                Mutate(bits);

                var newChromosome = new Chromosome(bits);

                if (!newChromosome.Gens.Any(gen => double.IsNaN(gen)))
                {
                    population[i] = newChromosome;
                }
            }
        }

        private bool IsMutationWorked()
        {
            return _probability > _random.NextDouble();
        }

        private void Mutate(BitArray bits)
        {
            for(int i = 0; i < bits.Count; i++)
            {
                if (IsMutationWorked())
                {
                    bits[i] = !bits[i];
                }
            }
        }
    }
}
