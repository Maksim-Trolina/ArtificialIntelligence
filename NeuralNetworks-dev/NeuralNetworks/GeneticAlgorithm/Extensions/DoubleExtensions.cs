using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.GeneticAlgorithm.Extensions
{
    static internal class DoubleExtensions
    {
        const long ExponentMask = 0x7FF0000000000000;
        static internal bool IsNormal(this double number)
        {
            long bithack = BitConverter.DoubleToInt64Bits(number);
            bithack &= ExponentMask;
            return (bithack != 0) && (bithack != ExponentMask);
        }
    }
}
