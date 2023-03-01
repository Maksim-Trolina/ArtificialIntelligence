using System;
using System.Drawing;

namespace NeuralNetworks.HopAlgorithm.UI;

public static class Draw
{
    public static void DrawCell(Graphics graphics, Bitmap gridBitmap, bool[,] gridArr, Point click, Color cellColor, Color backColor)
    {
        var x = gridBitmap.Width / (float)gridArr.GetLength(1);
        var y = gridBitmap.Height / (float)gridArr.GetLength(0);

        var columnNumber = (int)Math.Floor(click.X / x);
        var rowNumber = (int)Math.Floor(click.Y / y);

        gridArr[rowNumber, columnNumber] = !gridArr[rowNumber, columnNumber];

        var p1 = new PointF(x * columnNumber, y * rowNumber);
        var colorFill = gridArr[rowNumber, columnNumber] ? cellColor : backColor;

        graphics.FillRectangle(new SolidBrush(colorFill)
            , new RectangleF(p1.X, p1.Y, x, y));
    }

    public static void DrawGrid(Graphics graphics, Bitmap gridBitmap, int row, int column)
    {
        var x = (float)gridBitmap.Width / column;
        var y = (float)gridBitmap.Height / row;

        var pt1 = new PointF(0, 0);
        var pt2 = new PointF(0, gridBitmap.Height);

        for (var i = 0; i < column; i++)
        {
            pt1.X += x;
            pt2.X += x;

            graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), pt1, pt2);
        }

        pt1 = new PointF(0, 0);
        pt2 = new PointF(gridBitmap.Width, 0);

        for (var i = 0; i < row; i++)
        {
            pt1.Y += y;
            pt2.Y += y;
            graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), pt1, pt2);
        }
        
        pt1 = new PointF(0, 0);
        pt2 = new PointF(0, gridBitmap.Height);

        for (var i = 0; i < column; i++)
        {
            pt1.X += x;
            pt2.X += x;
            graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), pt1, pt2);
        }
    }

    public static void PaintFigure(Graphics graphics, Bitmap gridBitmap, bool[,] gridArr, int row, int column, Color color, Color backColor)
    {
        var x = gridBitmap.Width / (float)gridArr.GetLength(1);
        var y = gridBitmap.Height / (float)gridArr.GetLength(0);

        for (var i = 0; i < row; i++)
        {
            for (var j = 0; j < column; j++)
            {
                var pointF = new PointF(x * j, y * i);
                var colorFill = gridArr[i, j] ? color : backColor;

                graphics.FillRectangle(new SolidBrush(colorFill)
                    , new RectangleF(pointF.X, pointF.Y, x, y));
            }
        }
    }
}