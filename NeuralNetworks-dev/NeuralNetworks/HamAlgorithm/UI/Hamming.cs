using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NeuralNetworks.Common.Utils;
using NeuralNetworks.HamAlgorithm.Algorithm;

namespace NeuralNetworks;

public partial class Hamming : Form
{
    private readonly Form _parentForm;
    
    private bool _paintAvailable;
    private Graphics _graphics;
    private string _imagesPath = "";
    private readonly ImageList _imageList;
    private Bitmap _bitmap;
    
    private List<Matrix> _samples;
    private HammingNn _nn;
    
    private const int PictureBoxHeightInNeurons = 200;
    private const int PictureBoxWidthInNeurons = 200;
    private const double Epsilon = 0.00001;

    public Hamming(Form parentForm)
    {
        InitializeComponent();
        
        _imageList = new ImageList();
        _imageList.ImageSize = new Size(100, 100);
        
        _parentForm = parentForm;
    }
    
    private void Hamming_Load(object sender, EventArgs e)
    {
        _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        _graphics = Graphics.FromImage( _bitmap);
        _graphics.Clear(Color.White);
        pictureBox1.Image = _bitmap;
        
        listView1.View = View.Details;
        listView1.Columns.Add("Patterns", 150);
        listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
    }
    
    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        _paintAvailable = false;
    }
    
    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        _paintAvailable = true;
    }
    
    // Draw image
    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (!_paintAvailable)
        {
            return;
        }
        _graphics.FillEllipse(Brushes.Brown, e.X, e.Y, 40.0f, 40.0f);
        pictureBox1.Refresh();
    }

    private void Hamming_FormClosed(object sender, FormClosedEventArgs e)
    {
        _parentForm.Show();
    }

    // Refresh picture
    private void button1_Click(object sender, EventArgs e)
    {
        _graphics.Clear(Color.White);
        _imageList.Images.Clear();
        listView1.Items.Clear();
    }

    // Search sample
    [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: System.Double[,]; size: 207MB")]
    private void button3_Click(object sender, EventArgs e)
    {
        _nn = new HammingNn(_samples, PictureBoxHeightInNeurons * PictureBoxWidthInNeurons, Epsilon);
        
        var results = _nn.GetIndexes(Converter.ImageToVector(pictureBox1.Image));

        switch (results.Count)
        {
            case 0:
                MessageBox.Show("Algorithm didn't find any decision");
                break;
            case > 1:
                MessageBox.Show("Algorithm found a few");
                break;
        }

        pictureBox2.Image = _imageList.Images[results[0]];
        pictureBox2.Refresh();
    }
    
    // Get samples folder
    private void button6_Click(object sender, EventArgs e)
    {
        folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
        
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        {
            _imagesPath = folderBrowserDialog1.SelectedPath;
        }

        var imagesWithNames = Parser.ParseImages(_imagesPath);

        _samples = new List<Matrix>(imagesWithNames.Count);

        _imageList.Images.AddRange(imagesWithNames.Values.ToArray());
        listView1.SmallImageList = _imageList;

        foreach (var curIm in imagesWithNames)
        {
            listView1.Items.Add(curIm.Key, listView1.Items.Count);
            _samples.Add(Converter.ImageToVector(curIm.Value));
        }
    }

    // Clear draw zone
    private void button4_Click(object sender, EventArgs e)
    {
        _graphics.Clear(Color.White);
        pictureBox1.Refresh();
    }
}