using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Crossing.Real
{
    public class SimplestCrossing : ICrossing
    {
        private readonly Random _random = new();
        public List<Chromosome> Cross(Chromosome parent1, Chromosome parent2)
        {
            int randomIndex = _random.Next(parent1.Gens.Length);

            List<Chromosome> childrens = new();

            childrens.Add(CreateChild(parent1, parent2, randomIndex));
            childrens.Add(CreateChild(parent2, parent1, randomIndex));

            return childrens;
        }

        private Chromosome CreateChild(Chromosome parent1, Chromosome parent2, int index)
        {
            int childGenCount = parent1.Gens.Length;
            Chromosome child = new(childGenCount);

            Array.Copy(parent1.Gens, 0, child.Gens, 0, index);
            Array.Copy(parent2.Gens, index, child.Gens, index, childGenCount - index);

            return child;
        }
    }
}
