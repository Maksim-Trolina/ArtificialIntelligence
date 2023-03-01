using NeuralNetworks.SimulatedAnnealing.Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworks.SimulatedAnnealing.UI
{
    public partial class AnnealingAlgorithmForm : Form
    {
        private double[,] _matrix;

        private readonly Form _parentForm;
        public AnnealingAlgorithmForm(Form parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;
            _matrix = new double[(int)countVertex.Value, (int)countVertex.Value];

            InitializeMatrix();

            shortestPathLabel.Text = "";
            sumWeightLabel.Text = "";
        }

        private void InitializeMatrix()
        {
            matrixGridView.RowCount = (int)countVertex.Value;

            matrixGridView.ColumnCount = (int)countVertex.Value;

            for (var i = 0; i < (int)countVertex.Value; i++)
            {
                matrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();

                matrixGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = 0; j < _matrix.GetLength(0); j++)
                {
                    matrixGridView.Rows[i].Cells[j].Value = _matrix[i, j];

                    matrixGridView.Columns[j].Width = 40;

                    matrixGridView.Rows[i].Cells[j].ReadOnly = isSimmetricCheckBox.Checked && j <= i; ;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            minTemperatureNumeric.Maximum = maxTemperatureNumeric.Value;
        }

        private void maxTemperatureNumeric_ValueChanged(object sender, EventArgs e)
        {
            minTemperatureNumeric.Maximum = maxTemperatureNumeric.Value;
        }

        private void isSimmetricCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = i + 1; j < _matrix.GetLength(0); j++)
                {
                    _matrix[j, i] = _matrix[i, j];
                }
            }

            InitializeMatrix();
        }

        private void randomWeightsButton_Click(object sender, EventArgs e)
        {
            var random = new Random();

            var maxRandom = (int)maxRandomNumeric.Value;

            for (var i = 0; i < countVertex.Value; i++)
            {
                for (var j = 0; j < countVertex.Value; j++)
                {
                    if (i != j)
                    {
                        _matrix[i, j] = random.Next(maxRandom) + 1;
                    }

                    if (isSimmetricCheckBox.Checked && j <= i)
                    {
                        _matrix[j, i] = _matrix[i, j];
                    }
                }
            }

            InitializeMatrix();
        }

        private void maxRandomNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void countVertex_ValueChanged(object sender, EventArgs e)
        {
            _matrix = new double[(int)countVertex.Value, (int)countVertex.Value];

            InitializeMatrix();
        }

        private void matrixGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;

            if (row < 0 || column < 0)
            {
                return;
            }

            var oldValue = _matrix[row, column];

            if (int.TryParse(matrixGridView.Rows[row].Cells[column].Value.ToString(), out var newValue)
                && newValue > 0)
            {
                _matrix[row, column] = newValue;
            }
            else
            {
                matrixGridView.Rows[row].Cells[column].Value = oldValue;
            }

            if (isSimmetricCheckBox.Checked)
            {
                matrixGridView.Rows[column].Cells[row].Value = matrixGridView.Rows[row].Cells[column].Value;
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            var annealing = new AnnealingAlgorithm();

            startButton.Enabled = false;

            var bestPath = await Task.Run(() => annealing.GetBestPath(
                _matrix,
                (double)maxTemperatureNumeric.Value,
                (double)minTemperatureNumeric.Value,
                (double)cRatioNumeric.Value));
            
            startButton.Enabled = true;
            shortestPathLabel.Text = string.Join(" -- ", bestPath);
            sumWeightLabel.Text = annealing.GetPathWeight(_matrix, bestPath).ToString();
        }

        private void AnnealingAlgorithmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
