using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public class RankSelection : BaseSelection
    {
        public override List<Chromosome> Select(List<Chromosome> population, Func<double[], double> calculateSignificance, int numberSurvived)
        {
            Chromosome averageChromoseme = GetAverageChromosome(population, calculateSignificance);

            return population.Where(chromosome => CalculateDeltaSignificance(chromosome, averageChromoseme, calculateSignificance) >= 0)
                .ToList();
        }

        private double CalculateDeltaSignificance(Chromosome chromosome1, Chromosome chromosome2, Func<double[], double> calculateSignificance)
        {
            return calculateSignificance(chromosome1.Gens) - calculateSignificance(chromosome2.Gens); ;
        }
    }
}
