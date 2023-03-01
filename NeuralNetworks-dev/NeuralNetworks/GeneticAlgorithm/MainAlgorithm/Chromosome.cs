using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks.GeneticAlgorithm.MainAlgorithm
{
    public class Chromosome
    {
        private readonly Random _random = new Random();
        private const int BIT_COUNTS_IN_BYTE = 8;
        public Chromosome(int genCount)
        {
            Gens = new double[genCount];

            for (int i = 0; i < genCount; i++)
            {
                Gens[i] = _random.NextDouble() - 0.5;
            }
        }

        public Chromosome(BitArray arrayBits)
        {
            int size = arrayBits.Length / (sizeof(double) * BIT_COUNTS_IN_BYTE);

            Gens = new double[size];

            for (int genNum = 0; genNum < Gens.Length; genNum++)
            {
                List<byte> bytes = new();

                for (int byteIndex = genNum * BIT_COUNTS_IN_BYTE; byteIndex < genNum * BIT_COUNTS_IN_BYTE + BIT_COUNTS_IN_BYTE; byteIndex++)
                {
                    bool[] bits = new bool[BIT_COUNTS_IN_BYTE];

                    for (int bitIndex = 0; bitIndex < bits.Length; bitIndex++)
                    {
                        int bitArrayIndex = byteIndex * BIT_COUNTS_IN_BYTE + bitIndex;

                        bits[bitIndex] = arrayBits[bitArrayIndex];
                    }

                    bits.Reverse();

                    bytes.Add(ToByte(bits));
                }

                var gen = BitConverter.ToDouble(bytes.ToArray(), 0);

                Gens[genNum] = gen;
            }
        }

        public int GetBitsCount()
        {
            return Gens.Length * sizeof(double) * BIT_COUNTS_IN_BYTE;
        }

        public double[] Gens { get; set; }
        public BitArray ToBits()
        {
            var chromosomeBytes = Gens.Select(gen => BitConverter.GetBytes(gen)).ToList();

            var chromosomesCombinedBytes = new List<byte>();

            foreach (var item in chromosomeBytes)
            {
                chromosomesCombinedBytes.AddRange(item);
            }
            var chromosomeBits = new BitArray(chromosomesCombinedBytes.ToArray());

            return chromosomeBits;
        }

        private byte ToByte(bool[] bits)
        {
            byte result = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i])
                {                    
                    result += (byte)Math.Pow(2, i); ;
                }
            }

            return result;
        }

    }
}
