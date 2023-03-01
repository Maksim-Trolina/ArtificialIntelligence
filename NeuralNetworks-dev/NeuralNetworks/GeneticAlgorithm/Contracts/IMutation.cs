using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System.Collections.Generic;

namespace NeuralNetworks.GeneticAlgorithm.Contracts
{
    public interface IMutation
    {
        void Mutate(List<Chromosome> population);
    }
}
