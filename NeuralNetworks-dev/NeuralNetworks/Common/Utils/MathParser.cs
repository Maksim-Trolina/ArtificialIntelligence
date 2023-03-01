using System;
using org.mariuszgromada.math.mxparser;

namespace NeuralNetworks.Common.Utils
{
    public class MathParser
    {
        private Function _function;

        public int GetArgumentsNumber()
        {
            if(_function is null)
            {
                throw new NullReferenceException($"{nameof(_function)} is null");
            }
            return _function.getArgumentsNumber();
        } 

        public void InitializeExpression(string expression)
        {
            _function = new Function(expression);
        }
           

        public double CalculateFunctionValue(params double[] parameters)
        {
            double functionValue = _function.calculate(parameters);
            return functionValue;
        }

        public string ArgumentName(int parameterIndex) => _function.getParameterName(parameterIndex);
    }
}
