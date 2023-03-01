using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NeuralNetworks.Common.Utils;
using NeuralNetworks.HopAlgorithm.Algorithm;
using NeuralNetworks.HopAlgorithm.UI;

namespace NeuralNetworks;

public partial class Hopfield : Form
{
    private readonly Form _parentForm;
    private Graphics _gridGraphics;
    private Bitmap _gridBitmap;
    private readonly Color _cellColor = Color.DarkRed;
    private ImageList _images;
    
    private int AcceptableSamples => (int)Math.Floor((int)ColumnCount.Value * (int)RowsCount.Value * 0.14m);
    
    private bool[,] _gridArray;
    private HopfieldNn _nn = new();
    private List<bool[,]> _patterns; 

    public Hopfield(Form parentForm)
    {
        InitializeComponent();
        _parentForm = parentForm;
    }
    
    private void Hopfield_Load(object sender, EventArgs e)
    {
        _gridBitmap = new Bitmap(gridPictureBox.Width, gridPictureBox.Height);
        _gridGraphics = Graphics.FromImage(_gridBitmap);
        _patterns = new List<bool[,]>();

        acceptableSamplesLabel.Text = AcceptableSamples.ToString();
            
        _images = new ImageList();
        _images.ImageSize = new Size(100, 100);
    }

    // Draw pattern
    private void gridPictureBox_Click(object sender, EventArgs e)
    {
        var click = (MouseEventArgs)e;
            
        Draw.DrawCell(_gridGraphics, _gridBitmap, _gridArray, click.Location, _cellColor, BackColor);
        Draw.DrawGrid(_gridGraphics, _gridBitmap, (int)RowsCount.Value, (int)ColumnCount.Value);
 
        gridPictureBox.Image = _gridBitmap;
    }

    // Add pattern
    private void button1_Click(object sender, EventArgs e)
    {
        if (_patterns.Count == AcceptableSamples)
        {
            MessageBox.Show("Превышен лимит образцов");
            return;
        } 
        
        var pattern = new bool[(int)RowsCount.Value, (int)ColumnCount.Value];
            
        Array.Copy(_gridArray, pattern, pattern.Length);
        _patterns.Add(pattern);
        
        _images.Images.Add(gridPictureBox.Image);
        imageList.Items.Add(new ListViewItem($"Pattern {_patterns.Count}", _patterns.Count));
        imageList.LargeImageList = _images;
    }

    // Search pattern
    private void button2_Click(object sender, EventArgs e)
    {
        try
        {
            _nn = new HopfieldNn(Converter.MatrixToVector(_patterns));
            _gridArray = _nn.Find(_gridArray);
            
            PaintFigure();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void CreateGrid(int row, int column)
    {
        _gridArray = new bool[row, column];
        _gridGraphics.Clear(BackColor); 
        Draw.DrawGrid(_gridGraphics, _gridBitmap, row, column);
    }

    private void PaintFigure()
    {
        Draw.PaintFigure(_gridGraphics, _gridBitmap, _gridArray, (int)RowsCount.Value, (int)ColumnCount.Value, _cellColor, BackColor);
        Draw.DrawGrid(_gridGraphics, _gridBitmap, (int)RowsCount.Value, (int)ColumnCount.Value);
        gridPictureBox.Image = _gridBitmap;
    }
        
    // Clear patterns
    private void button4_Click(object sender, EventArgs e)
    {  
        _patterns.Clear();
        _images.Images.Clear();
        imageList.Clear();
            
        CreateGrid((int)RowsCount.Value, (int)ColumnCount.Value);
            
        gridPictureBox.Image = _gridBitmap;

        _images.Images.Add(Image.FromHbitmap(_gridBitmap.GetHbitmap()));
    }

    private void Hopfield_FormClosed(object sender, FormClosedEventArgs e)
    {
        _parentForm.Show();
    }

    private void RowsCount_ValueChanged(object sender, EventArgs e)
    {
        _patterns.Clear();
        _images.Images.Clear();
        acceptableSamplesLabel.Text = AcceptableSamples.ToString();
            
        CreateGrid((int)RowsCount.Value, (int)ColumnCount.Value);

        gridPictureBox.Image = _gridBitmap;

        _images.Images.Clear();
        imageList.Clear();
        _images.Images.Add(Image.FromHbitmap(_gridBitmap.GetHbitmap()));
    }

    private void ColumnCount_ValueChanged(object sender, EventArgs e)
    { 
        _patterns.Clear();
        _images.Images.Clear();
        acceptableSamplesLabel.Text = AcceptableSamples.ToString();
            
        CreateGrid((int)RowsCount.Value, (int)ColumnCount.Value);
            
        gridPictureBox.Image = _gridBitmap;

        _images.Images.Clear();
        imageList.Clear();
        _images.Images.Add(Image.FromHbitmap(_gridBitmap.GetHbitmap()));
    }
}