using NeuralNetworks.AntAlgorithm.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NeuralNetworks.AntAlgorithm.UI
{
    public partial class AntAlgorithmForm : Form
    {
        private MatrixCell[,] _matrix;
        private List<int> _shortestPath;

        private readonly Form _parentForm;
        private Random _random = new();
        public AntAlgorithmForm(Form parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _matrix = new MatrixCell[(int)countVertex.Value, (int)countVertex.Value];
            _shortestPath = new List<int>();
            InitializeMatrix(_matrix);
        }
        private void ResizeMatrix(object sender, EventArgs e)
        {
            _matrix = new MatrixCell[(int)countVertex.Value, (int)countVertex.Value];
            InitializeMatrix(_matrix);
        }
        private void CreateRandomWeights(object sender, EventArgs e)
        {
            InitializeMatrix(_matrix);
        }

        private void InitializeMatrix(MatrixCell[,] matrix)
        {
            FillMatrixRandomValues(matrix);
            ClearPheramones(matrix);
            InitializeUiMatrix();
        }
        private void FillMatrixRandomValues(MatrixCell[,] matrix)
        {
            var maxRandom = (int)maxRandomNumeric.Value;

            for (var i = 0; i < countVertex.Value; i++)
            {
                for (var j = 0; j < countVertex.Value; j++)
                {
                    matrix[i, j] = new MatrixCell
                    {
                        Weight = _random.Next(maxRandom) + 1
                    };
                }
            }

        }

        private void InitializeUiMatrix()
        {
            matrixGridView.RowCount = (int)countVertex.Value;
            matrixGridView.ColumnCount = (int)countVertex.Value;
            pheromonesGridView.RowCount = (int)countVertex.Value;
            pheromonesGridView.ColumnCount = (int)countVertex.Value;

            for (var i = 0; i < (int)countVertex.Value; i++)
            {
                matrixGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                matrixGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
                pheromonesGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                pheromonesGridView.Columns[i].HeaderCell.Value = (i + 1).ToString();
            }

            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = 0; j < _matrix.GetLength(0); j++)
                {
                    matrixGridView.Rows[i].Cells[j].Value = _matrix[i, j].Weight;
                    matrixGridView.Columns[j].Width = 40;
                    matrixGridView.Rows[i].Cells[j].ReadOnly = j <= i;
                    pheromonesGridView.Rows[i].Cells[j].Value = _matrix[i, j].Pheromone;
                    pheromonesGridView.Columns[j].Width = 80;
                }
            }
        }

        private async void StartAlgorithm(object sender, EventArgs e)
        {
            var algorithm = new AntAlgorithmLogic((int)alphaNumeric.Value, (int)betaNumeric.Value);

            ClearPheramones(_matrix);

            await algorithm.RunAlgorithm((int)countIterationsNumeric.Value, 
                (int)countAntsNumeric.Value, _matrix, 
                (double)evaporationRatioNumeric.Value, 
                (double)qRatioNumeric.Value);
            
            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = 0; j < _matrix.GetLength(0); j++)
                {
                    pheromonesGridView.Rows[i].Cells[j].Value = _matrix[i, j].Pheromone;
                }
            }

            _shortestPath = algorithm.HamiltonCycle(_matrix);
            shortestPathLabel.Text = string.Join("-", _shortestPath.Select(v => v + 1).ToList());
            sumWeightLabel.Text = algorithm.WeightSum(_shortestPath, _matrix).ToString();
        }

        private void ClearPheramones(MatrixCell[,] matrix)
        {
            for (var fromVertex = 0; fromVertex < matrix.GetLength(0); fromVertex++)
            {
                for (var toVertex = 0; toVertex < matrix.GetLength(0); toVertex++)
                {
                    matrix[fromVertex, toVertex].Pheromone = fromVertex == toVertex ? MatrixCell.LACK_PHERAMON : 
                        MatrixCell.DEFAULT_VALUE_PHERAMON;
                }
            }
        }

        private void AntAlgorithmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
