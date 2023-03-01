using System;

namespace NeuralNetworks.Common.Utils;
public class Matrix
{
    public const double ComparisonAccuracy = 0.000001;
    
    private readonly double [,] _data;
    
    private double _precalculatedDeterminant = double.NaN;
    public int M { get; }
    public int N { get; }
    private bool IsSquare => M == N;
        
    public double this[int x, int y] 
    {
        get => _data[x, y];
        set
        {
            _data[x, y] = value;
            _precalculatedDeterminant = double.NaN;
        }
    }
        
    public Matrix(int m, int n, double value = 0) 
    {
        M = m; 
        N = n;
        _data = new double[m, n];
        ProcessFunctionOverData((i, j) => _data[i, j] = value);
    }
    
    public Matrix(Matrix matrix) 
    {
        M = matrix.M; 
        N = matrix.N;
        _data = new double[matrix.M, matrix.N];
        ProcessFunctionOverData((i, j) => _data[i, j] = matrix[i, j]);
    }
        
    public void ProcessFunctionOverData(Action<int, int> func)
    {
        for(var i = 0; i < M; i++)
        {
            for(var j = 0; j < N; j++)
            {
                func(i, j);
            }
        }
    }
        
    public static Matrix operator* (Matrix matrix1, double value) 
    {
        var result = new Matrix(matrix1.M, matrix1.N);
        result.ProcessFunctionOverData((i, j) => 
            result[i,j] = matrix1[i,j] * value);
        return result;
    }
        
    public static Matrix operator* (Matrix matrix1, Matrix matrix2) 
    {
        if (matrix1.N != matrix2.M) {
            throw new ArgumentException("Matrix can't be multiplied!");
        }
        var result = new Matrix(matrix1.M, matrix2.N);
        result.ProcessFunctionOverData((i, j) => {
            for(var k = 0; k < matrix1.N; k++) {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        });
        return result;
    }
        
    public static Matrix operator -(Matrix matrix1, Matrix matrix2)
    {
        return matrix1 + (matrix2 * -1);
    }
        
    public static Matrix operator -(Matrix matrix1, double value)
    {
        return matrix1 + (value * -1);
    }
        
    public static Matrix operator+ (Matrix matrix1, double value) 
    {
        var result = new Matrix(matrix1.M, matrix1.N);
        result.ProcessFunctionOverData((i, j) => 
            result[i,j] = matrix1[i,j] + value);
        return result;
    }
        
    public static Matrix operator+ (Matrix matrix1, Matrix matrix2) 
    {
        if (matrix1.M != matrix2.M && matrix1.N != matrix2.N) {
            throw new ArgumentException("Impossible to add matrices!");
        }
        var result = new Matrix(matrix1.M, matrix1.N);
        result.ProcessFunctionOverData((i, j) => {
                
            result[i, j] += matrix1[i, j] + matrix2[i, j];
        });
        return result;
    }
        
    private Matrix CreateMatrixWithoutColumn(int column)
    {
        if (column < 0 || column >= N)
        {
            throw new ArgumentException("Invalid column index!");
        }
        var result = new Matrix(M, N - 1);
        result.ProcessFunctionOverData((i, j) => 
            result[i, j] = j < column ? this[i, j] : this[i, j + 1]);
        return result;
    }
        
    private Matrix CreateMatrixWithoutRow(int row)
    {
        if (row < 0 || row >= M)
        {
            throw new ArgumentException("Invalid row index!");
        }
        var result = new Matrix(M - 1, N);
        result.ProcessFunctionOverData((i, j) => 
            result[i, j] = i < row ? this[i, j] : this[i + 1, j]);
        return result;
    }
        
    public double CalculateDeterminant()
    {
        if (!IsSquare)
        {
            throw new InvalidOperationException(
                "Determinant can be calculated only for square matrix!");
        }
        if (!double.IsNaN(_precalculatedDeterminant))
        {
            return _precalculatedDeterminant;
        }
        if (N == 2)
        {
            return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];
        }
        
        double result = 0;
        
        for (var j = 0; j < N; j++)
        {
            result += (j % 2 == 1 ? 1 : -1) * this[1, j] * 
                      CreateMatrixWithoutColumn(j).
                          CreateMatrixWithoutRow(1).CalculateDeterminant();
        }
        return result;
    }
        
    public static Matrix CreateSquareMatrix(int n, double value = 1.0)
    {
        var result = new Matrix(n, n);
        for (var i = 0; i < n; i++)
        {
            result[i, i] = value;
        }
        return result;
    }

    public Matrix CreateTransposeMatrix()
    {
        var result = new Matrix(N, M);
        result.ProcessFunctionOverData((i, j) => result[i, j] = this[j, i]);
        return result;
    }
    
    public static bool Equals(Matrix matrix1, Matrix matrix2)
    {
        if (!(matrix1.M == matrix2.M && matrix1.N == matrix2.N))
        {
            throw new ArgumentException("Dimensions of matrix not matched!");
        }

        for (var i = 0; i < matrix1.M; i++)
        {
            for (var j = 0; j < matrix1.N; j++)
            {
                if (Math.Abs(matrix1[i, j] - matrix2[i, j]) > ComparisonAccuracy)
                {
                    return false;
                }
            }
        }

        return true;
    }
    
    public static double[,] Multiply(double[,] first, double[,] second)
    {
        if (first.GetLength(1) != second.GetLength(0))
        {
            throw new ArgumentException("dimensions of matrix not matched");
        }

        var result = new double[first.GetLength(0), second.GetLength(1)];

        for (var i = 0; i < first.GetLength(0); i++)
        {
            for (var j = 0; j < second.GetLength(1); j++)
            {
                for (var k = 0; k < first.GetLength(1); k++)
                {
                    result[i, j] += first[i, k] * second[k, j];
                }
            }
        }

        return result;
    }
    
    public static double[,] Transpose(double[,] matrix)
    {
        var result = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for(var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }
    
    public static double[,] Add(double[,] first, double[,] second)
    {
        if (!(first.GetLength(0) == second.GetLength(0) && first.GetLength(1) == second.GetLength(1)))
        {
            throw new ArgumentException("dimensions of matrix not matched");
        }

        var result = new double[first.GetLength(0), first.GetLength(1)];

        for (var i = 0; i < first.GetLength(0); i++)
        {
            for (var j = 0; j < first.GetLength(1); j++)
            {
                result[i, j] = first[i, j] + second[i, j];
            }
        }

        return result;
    }
    
    public static bool Equals(double[,] first, double[,] second)
    {
        if (!(first.GetLength(0) == second.GetLength(0) && first.GetLength(1) == second.GetLength(1)))
        {
            throw new ArgumentException("dimensions of matrix not matched");
        }

        for (var i = 0; i < first.GetLength(0); i++)
        {
            for (var j = 0; j < first.GetLength(1); j++)
            {
                if (Math.Abs(first[i, j] - second[i, j]) > ComparisonAccuracy)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static double FindMax(Matrix matrix)
    {
        var max = double.MinValue;

        for (var i = 0; i < matrix.M; i++)
        {
            for (var j = 0; j < matrix.N; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }

        return max;
    }
}