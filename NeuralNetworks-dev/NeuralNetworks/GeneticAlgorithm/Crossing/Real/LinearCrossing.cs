using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Crossing.Real
{
    public class LinearCrossing : ICrossing
    {
        public List<Chromosome> Cross(Chromosome parent1, Chromosome parent2)
        {
            var childrens = new List<Chromosome>();

            childrens.Add(CreateChild(parent1, parent2, (gen1, gen2) => (gen1 + gen2) / 2));
            childrens.Add(CreateChild(parent1, parent2, (gen1, gen2) => (3 * gen1 - gen2) / 2));
            childrens.Add(CreateChild(parent1, parent2, (gen1, gen2) => (3 * gen2 - gen1) / 2));

            return childrens;
        }

        private Chromosome CreateChild(Chromosome parent1, Chromosome parent2, Func<double, double, double> createGen)
        {
            Chromosome child = new(parent1.Gens.Length);
            for(int genNum = 0; genNum < child.Gens.Length; genNum++)
            {
                child.Gens[genNum] = createGen(parent1.Gens[genNum], parent2.Gens[genNum]);
            }

            return child;
        }
    }
}
