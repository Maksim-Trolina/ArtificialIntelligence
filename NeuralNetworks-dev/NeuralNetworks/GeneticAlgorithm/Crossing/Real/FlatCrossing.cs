using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Crossing.Real
{

    public class FlatCrossing : ICrossing
    {
        private readonly Random _random = new();
        public List<Chromosome> Cross(Chromosome parent1, Chromosome parent2)
        {
            Chromosome child = CreateChild(parent1, parent2);

            List<Chromosome> childrens = new();
            childrens.Add(child);

            return childrens;
        }

        private Chromosome CreateChild(Chromosome parent1, Chromosome parent2)
        {
            Chromosome child = new(parent1.Gens.Length);
            for (int genNumber = 0; genNumber < parent1.Gens.Length; genNumber++)
            {
                double maxGen = Math.Max(parent1.Gens[genNumber], parent2.Gens[genNumber]);
                double minGen = Math.Min(parent1.Gens[genNumber], parent2.Gens[genNumber]);
                double deltaGen = maxGen - minGen;
                double randomNumber = _random.NextDouble();
                double childGen = randomNumber * deltaGen + minGen;

                child.Gens[genNumber] = childGen;
            }

            return child;
        }
    }
}
