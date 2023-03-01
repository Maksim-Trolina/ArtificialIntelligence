using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Contracts
{
    public interface ISelection
    {
        List<Chromosome> Select(List<Chromosome> population, Func<double[], double> calculateSignificance, int numberSurvived);
    }
}
