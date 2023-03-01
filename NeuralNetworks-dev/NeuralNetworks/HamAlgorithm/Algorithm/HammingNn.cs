using System;
using System.Collections.Generic;
using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.HamAlgorithm.Algorithm;

public class HammingNn
{
    private readonly A _a;
    private readonly Y _y;
    private readonly Z _z;
    
    public HammingNn(IReadOnlyList<Matrix> samples, int countOfSignals, double eps)
    {
        _a = new A(eps);
        _y = new Y();
        _z = new Z(eps, countOfSignals, samples);
    }

    public List<int> GetIndexes(Matrix inputS)
    {
        var input = new Matrix(inputS);
        var zInput =  _z.GetInputSignal(input);

        var indexes = GetMaxIndexes(zInput);

        if (indexes.Count > 1)
        {
            return indexes;
        }

        var zOutput = _z.GetOutputSignal(zInput);
        var aInput = new Matrix(zOutput);
        
        indexes = GetMaxIndexes(aInput);
        
        if (indexes.Count == 1)
        {
            return indexes;
        }

        indexes = new List<int>();

        var aOutput = _a.GetOutputSignal(zOutput);
        var yOutput = _y.GetOutputSignal(aOutput);

        for (var i = 0; i < yOutput.N; i++)
        {
            if (Math.Abs(yOutput[0, i] - 1) < Matrix.ComparisonAccuracy)
            {
                indexes.Add(i);
            }
        }

        return indexes;
    }

    private List<int> GetMaxIndexes(Matrix array)
    {
        var indexes = new List<int>();

        if (array.N <= 0)
        {
            return indexes;
        }
        
        var maxValue = Matrix.FindMax(array);

        for (var i = 0; i < array.N; i++)
        {
            if (Math.Abs(maxValue - array[0, i]) < Matrix.ComparisonAccuracy) 
            {
                indexes.Add(i);
            }
        }

        return indexes;
    }
}