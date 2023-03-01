using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public class TournamentSelection : BaseSelection
    {
        private int _countInTournament;
        public TournamentSelection(int countInTournament = 2)
        {
            _countInTournament = countInTournament;
        }

        public override List<Chromosome> Select(List<Chromosome> population, Func<double[], double> calculateSignificance, int numberSurvived)
        {
            List<Chromosome> newPopulation = new();

            HashSet<int> existIndices = new();
            for (int i = 0; i < numberSurvived; i++)
            {
                List<(Chromosome, int)> chromosomeIndexPairs = GenerateTournamentList(existIndices, population);

                var best = chromosomeIndexPairs.OrderBy(chromosome => calculateSignificance(chromosome.Item1.Gens))
                    .First();

                for(int j = 0; j < chromosomeIndexPairs.Count; j++)
                {
                    int index = chromosomeIndexPairs[i].Item2;
                    existIndices.Remove(index);
                }

                newPopulation.Add(best.Item1);
                existIndices.Add(best.Item2);
            }

            return newPopulation;
        }

        private List<(Chromosome, int)> GenerateTournamentList(HashSet<int> existIndices, List<Chromosome> population)
        {
            List<(Chromosome, int)> chromosomeIndexPairs = new();

            for (int tournamentNumber = 0; tournamentNumber < _countInTournament; tournamentNumber++)
            {
                int index = GenerateIndex(existIndices, population.Count);
                chromosomeIndexPairs.Add((population[index], index));
            }

            return chromosomeIndexPairs;
        }
    }
}
