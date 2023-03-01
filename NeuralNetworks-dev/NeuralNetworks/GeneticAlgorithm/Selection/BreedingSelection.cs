using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public abstract class BreedingSelection : BaseSelection
    {
        protected int GetHammingDistance(Chromosome chromosome1, Chromosome chromosome2)
        {
            int result = 0;

            var chromosome1Bits = chromosome1.ToBits();

            var chromosome2Bits = chromosome2.ToBits();

            for (int i = 0; i < chromosome1Bits.Length; i++)
            {
                result += chromosome1Bits[i] ^ chromosome2Bits[i] ? 1 : 0;
            }

            return result;
        }
    }


}
