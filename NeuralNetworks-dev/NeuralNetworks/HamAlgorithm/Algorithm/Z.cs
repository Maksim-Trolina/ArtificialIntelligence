using System;
using System.Collections.Generic;
using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.HamAlgorithm.Algorithm;

public class Z 
{
    private readonly Matrix _w;  
    private readonly double _k1; 
    public Z(double epsilon, int countOfNeurons, IReadOnlyList<Matrix> samples, double k1 = 0) 
    {
        _k1 = k1 switch
        {
            > 0 => k1,
            0 => 1d / (countOfNeurons + 1),
            _ => throw new ArgumentException("K1 not positive!")
        };

        if (epsilon < 0 || epsilon > 1d / samples.Count)
        {
            throw new ArgumentException("Epsilon does not satisfy the condition!");
        }

        _w = GetMatrix(countOfNeurons, samples.Count, samples);
    }

    public Matrix GetInputSignal(Matrix inputSignal)
    {
        var zInputSignal = new Matrix(1, _w.N);
        var zNeuronsOffset = _w.M / 2;
        
        for (var k = 0; k < zInputSignal.N; k++)
        {
            zInputSignal[0, k] = zNeuronsOffset;

            for (var i = 0; i < _w.M; i++)
            {
                zInputSignal[0, k] += _w[i, k] * inputSignal[0, i];
            }
        }

        return zInputSignal;
    }
    
    public Matrix GetOutputSignal(Matrix inputSignal)
    {
        var umax = 1d / _k1;

        var zOutputSignal = new Matrix(1, _w.N);

        for (var i = 0; i < _w.N; i++)
        {
            if (inputSignal[0, i] <= 0)
            {
                zOutputSignal[0, i] = 0;
            }
            else if (inputSignal[0, i] > umax)
            {
                zOutputSignal[0, i] = umax;
            }
            else
            {
                zOutputSignal[0, i] = inputSignal[0, i] * _k1;
            }
        }

        return zOutputSignal;
    }

    private Matrix GetMatrix(int rowCount, int columnCount, IReadOnlyList<Matrix> samples)
    {
        var matrix = new Matrix(rowCount, columnCount);
        var samplesColumnCount = samples[0].N;

        for (var j = 0; j < columnCount; j++)
        {
            for (var i = 0; i < rowCount; i++)
            {
                matrix[i, j] = samples[j]
                [i / samplesColumnCount, i % samplesColumnCount] / 2d;
                
            }
        }

        return matrix;
    }
}