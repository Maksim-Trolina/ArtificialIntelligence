using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Crossing.Real
{
    public class ArithmeticCrossing : ICrossing
    {
        private readonly Random _random = new();
        public List<Chromosome> Cross(Chromosome parent1, Chromosome parent2)
        {
            double coefficient = _random.NextDouble();
            List<Chromosome> childrens = new();

            childrens.Add(CreateChild(parent1, parent2, coefficient));
            childrens.Add(CreateChild(parent2, parent1, coefficient));

            return childrens;
        }
        
        private Chromosome CreateChild(Chromosome firstParent, Chromosome secondParent, double coefficient)
        {
            Chromosome child = new(firstParent.Gens.Length);

            for(int genNumber = 0; genNumber < child.Gens.Length; genNumber++)
            {
                child.Gens[genNumber] = coefficient * firstParent.Gens[genNumber] + 
                    (1 - coefficient) * secondParent.Gens[genNumber];
            }

            return child;
        }
    }
}
