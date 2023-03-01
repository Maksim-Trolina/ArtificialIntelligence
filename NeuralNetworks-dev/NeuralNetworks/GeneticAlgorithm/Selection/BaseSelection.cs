using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public abstract class BaseSelection : ISelection
    {
        public abstract List<Chromosome> Select(List<Chromosome> population, Func<double[], double> calculateSignificance, int numberSurvived);
        protected Random Random = new();
        protected Chromosome GetAverageChromosome(List<Chromosome> population, Func<double[], double> calculateSignificance)
        {
            var sortedPopulation = population.OrderBy(chromosome => calculateSignificance(chromosome.Gens)).ToList();

            return sortedPopulation[sortedPopulation.Count / 2];
        }

        protected int GenerateIndex(HashSet<int> existIndices, int populationCount)
        {
            int index;
            do
            {
                index = Random.Next(populationCount);
            } while (existIndices.Contains(index));

            existIndices.Add(index);
            return index;
        }
    }
}
