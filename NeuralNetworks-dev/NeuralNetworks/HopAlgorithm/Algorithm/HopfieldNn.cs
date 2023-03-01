using System;
using System.Collections.Generic;
using System.Linq;
using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.HopAlgorithm.Algorithm;
public class HopfieldNn
{
    private readonly List<double[,]> _patterns;
    private double[,] Weights { get; }

    public HopfieldNn()
    {
        _patterns = new List<double[,]>();
        Weights = new double[0,0];
    }
    
    public HopfieldNn(List<double[,]> patterns)
    {
        _patterns = patterns;
        Weights = new double[patterns[0].GetLength(0), patterns[0].GetLength(0)];
        
        foreach (var currentPattern in patterns)
        {
            Weights = Matrix.Add(Matrix.Multiply(currentPattern, Matrix.Transpose(currentPattern)), Weights);
        }
        
        for(var i = 0; i < Weights.GetLength(0); i++)
        {
            Weights[i, i] = 0;
        }
    }

    private double[,] FindSample(double[,] defective)
    {
        var viewed = new List<double[,]>();
        var temp = Sign(Matrix.Multiply(Weights, defective));
        Array.Copy(defective, temp, defective.Length);

        do
        {
            if (_patterns.Any(pattern => Matrix.Equals(pattern, temp)))
            {
                return temp;
            }
             
            viewed.Add(temp);
            
            temp = Sign(Matrix.Multiply(Weights, temp));

        } while (!viewed.Any(pattern => Matrix.Equals(pattern, temp)));

        if (_patterns.Any(pattern => Matrix.Equals(pattern, temp)))
        {
            return temp;
        }
        
        throw new ArgumentException("Couldn't find a sample!");
    }
    
    private double[,] Sign(double[,] matrix)
    {
        var result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (var i = 0; i < result.GetLength(0); i++)
        {
            for (var j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] >= 0 ? 1 : -1;
            }
        }
        return result;
    }
    
    public bool[,] Find(bool[,] defective)
    {
        var defectiveVector = Converter.MatrixToVector(defective); 
        
        try
        {
            var findPattern = FindSample(defectiveVector);
            return Converter.VectorToGrid(findPattern, defective.GetLength(1));
        }
        catch (ArgumentException e)
        {
            throw new ArgumentException(e.Message);
        }
    }
}