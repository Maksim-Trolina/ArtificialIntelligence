using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public class PanmixiaSelection : BaseSelection
    {
        public override List<Chromosome> Select(List<Chromosome> population, Func<double[], double> calculateSignificance, int numberSurvived)
        {
            List<Chromosome> newPopulation = new();
            HashSet<int> existIndices = new();

            for (int i = 0; i < numberSurvived; i++)
            {
                int index = GenerateIndex(existIndices, population.Count);
                newPopulation.Add(population[index]);
            }

            return newPopulation;
        }
    }
}
