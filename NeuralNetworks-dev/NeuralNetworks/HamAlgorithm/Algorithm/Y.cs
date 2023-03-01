using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.HamAlgorithm.Algorithm;

public class Y 
{
    public Matrix GetOutputSignal(Matrix inputSignal)
    {
        var outputSignal = new Matrix(1, inputSignal.N);

        for (var i = 0; i < inputSignal.N; i++)
        {
            inputSignal[0, i] = inputSignal[0, i] > 0 ? 1 : 0;
        }

        return outputSignal;
    }
}