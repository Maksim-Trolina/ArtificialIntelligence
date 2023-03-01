using System.Collections.Generic;
using System.Drawing;

namespace NeuralNetworks.Common.Utils;

public static class Converter
{
   public static Matrix ImageToVector(Image image)
   {
      var bitmap = new Bitmap(image);
      var imageMatrix = new Matrix(1, bitmap.Width * bitmap.Height);
      var current = 0;
      
      for (var i = 0; i < bitmap.Height; i++)
      {
         for (var j = 0; j < bitmap.Width; j++)
         {
            var color = bitmap.GetPixel(j, i);
            
            imageMatrix[0, current++] = color is { R: 255, G: 255, B: 255 } ? 1 : -1;
         }
      }

      return imageMatrix;
   }

   public static double[,] MatrixToVector(bool[,] arr)
   {
      var converted = new double[arr.GetLength(0) * arr.GetLength(1), 1];
      var k = 0;

      for (var i = 0; i < arr.GetLength(0); i++)
      {
         for (var j = 0; j < arr.GetLength(1); j++)
         {
            converted[k, 0] = arr[i, j] ? 1 : -1;
            k++;
         }
      }
      
      return converted;
   }
   
   public static List<double[,]> MatrixToVector(List<bool[,]> arr)
   {
      var result = new List<double[,]>();
      
      foreach (var currentPattern in arr)
      {
         var converted = new double[currentPattern.GetLength(0) * currentPattern.GetLength(1), 1];
         var k = 0;

         for (var i = 0; i < currentPattern.GetLength(0); i++)
         {
            for (var j = 0; j < currentPattern.GetLength(1); j++)
            {
               converted[k, 0] = currentPattern[i, j] ? 1 : -1;
               k++;
            }
         }
         
         result.Add(converted);
      }

      return result;
   } 
   
   public static bool[,] VectorToGrid(double[,] vector, int columnNumber)
   {
      var rowNumber = vector.Length / columnNumber;
      var converted = new bool[rowNumber, columnNumber];
      var k = 0;

      for (var i = 0; i < rowNumber; i++)
      {
         for (var j = 0; j < columnNumber; j++)
         {
            converted[i, j] = vector[k, 0] > 0;
            k++;
         }
      }
      return converted;
   }
}