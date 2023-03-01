using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public class InbreedingSelection : BreedingSelection
    {
        public override List<Chromosome> Select(List<Chromosome> population, Func<double[], double> calculateSignificance, int numberSurvived)
        {
            Chromosome averageChromosome = GetAverageChromosome(population, calculateSignificance);
            return population
                        .OrderBy(chromosome => GetHammingDistance(chromosome, averageChromosome))
                        .Take(numberSurvived)
                        .ToList();
        }
    }
}
