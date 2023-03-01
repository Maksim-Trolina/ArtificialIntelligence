using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.Extensions;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.Crossing.Binary
{
    public class PointCrossing : ICrossing
    {
        private readonly Random _random = new();
        public readonly int CountPoints;
        public PointCrossing(int countPoints = 1)
        {
            CountPoints = countPoints;
        }

        public List<Chromosome> Cross(Chromosome parent1, Chromosome parent2)
        {
            int lengthInBits = parent1.GetBitsCount();

            var childrens = new List<Chromosome>();

            while (!IsNormalGens(childrens))
            {
                List<int> crossPoints = CreateRandomeCrossPoints(lengthInBits);
                childrens = Cross(parent1, parent2, crossPoints);
            }

            return childrens;
        }

        private List<int> CreateRandomeCrossPoints(int lengthInBits)
        {
            var crossPoints = new List<int>();

            for (int i = 0; i < CountPoints; i++)
            {
                int crossPoint = _random.Next(lengthInBits);
                crossPoints.Add(crossPoint);
            }

            if (CountPoints % 2 == 1)
            {
                crossPoints.Add(0);
            }

            crossPoints.Sort();

            return crossPoints;
        }

        private List<Chromosome> Cross(Chromosome parent1, Chromosome parent2, IEnumerable<int> crossPoints)
        {
            var parent1Bits = parent1.ToBits();
            var parent2Bits = parent2.ToBits();

            List<Chromosome> childrens = new();

            foreach (var crossPoint in crossPoints)
            {
                childrens = Cross(parent1Bits, parent2Bits, crossPoint);
                parent1Bits = childrens[0].ToBits();
                parent2Bits = childrens[1].ToBits();
            }

            return childrens;
        }
        private List<Chromosome> Cross(BitArray parent1, BitArray parent2, int crossPoint)
        {
            for (int i = crossPoint; i < parent1.Length; i++)
            {
                bool temp = parent1[i];
                parent1[i] = parent2[i];
                parent2[i] = temp;
            }
            
            List<Chromosome> childrens = new();
            childrens.Add(new Chromosome(parent1));
            childrens.Add(new Chromosome(parent2));
            return childrens;
        }
        private bool IsNormalGens(List<Chromosome> population)
            => population.Count > 0 && 
            population.All(chromosome => chromosome.Gens.All(gen => gen.IsNormal()));
    }
}
