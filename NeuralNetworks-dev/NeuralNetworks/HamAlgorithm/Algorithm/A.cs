using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.HamAlgorithm.Algorithm;
public class A 
{
    private readonly double _epsilon;

    public A(double epsilon)
    {
        _epsilon = epsilon;
    } 

    public Matrix GetOutputSignal(Matrix inputSignal)
    {
        var outputSignal = inputSignal;

        do
        {
            inputSignal = new Matrix(outputSignal);
            
            for (var i = 0; i < inputSignal.N; i++)
            {
                for (var j = 0; j < inputSignal.N; j++)
                {
                    if (i != j)
                    {
                        outputSignal[0, i] += inputSignal[0, j];
                    }
                }
                
                outputSignal[0, i] *= -_epsilon; 
                outputSignal[0, i] += inputSignal[0, i]; 
            }

            outputSignal = Sign(outputSignal);

        } while (inputSignal != outputSignal);

        return outputSignal;
    }
    
    private static Matrix Sign(Matrix signal)
    {
        var outputSignal = new Matrix(1, signal.N);

        for (var i = 0; i < signal.N; i++)
        {
            outputSignal[0, i] = signal[0, i] > 0 ? signal[0, i] : 0;
        }

        return outputSignal;
    }
}