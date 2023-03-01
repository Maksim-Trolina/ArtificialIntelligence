using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Crossing.Real
{
    public class GeometryCrossing : ICrossing
    {
        private readonly Random _random = new();
        public List<Chromosome> Cross(Chromosome parent1, Chromosome parent2)
        {
            double pow = _random.NextDouble();

            List<Chromosome> childrens = new();
            childrens.Add(CreateChild(parent1, parent2, pow));
            childrens.Add(CreateChild(parent2, parent1, pow));

            return childrens;
        }

        private Chromosome CreateChild(Chromosome parentFirst, Chromosome parentSecond, double pow)
        {
            Chromosome child = new(parentFirst.Gens.Length);

            for (int genNumber = 0; genNumber < child.Gens.Length; genNumber++)
            {
                double geneticInfoFromParent1 = Math.Pow(Math.Abs(parentFirst.Gens[genNumber]), pow);
                double geneticInfoFromParent2 = Math.Pow(Math.Abs(parentSecond.Gens[genNumber]), 1 - pow);
                child.Gens[genNumber] = geneticInfoFromParent1 * geneticInfoFromParent2;
            }

            return child;
        }
    }
}
