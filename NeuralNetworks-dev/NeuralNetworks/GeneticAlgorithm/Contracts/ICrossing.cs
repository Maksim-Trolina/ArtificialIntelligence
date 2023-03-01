using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Contracts
{
    public interface ICrossing
    {
        List<Chromosome> Cross(Chromosome parent1, Chromosome parent2);
    }
}
