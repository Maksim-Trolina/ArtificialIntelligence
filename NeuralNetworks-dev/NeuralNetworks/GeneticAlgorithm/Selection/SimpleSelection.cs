using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public class SimpleSelection : BaseSelection
    {
        public override List<Chromosome> Select(List<Chromosome> population, Func<double[], double> calculateSignificance, int numberSurvived) => population
                .OrderBy(chromosome => calculateSignificance(chromosome.Gens))
                .Take(numberSurvived)
                .ToList();
    }
}
