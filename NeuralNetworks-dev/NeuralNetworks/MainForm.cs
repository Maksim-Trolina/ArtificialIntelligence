using NeuralNetworks.AntAlgorithm.UI;
using NeuralNetworks.BeeAlgorithm.UI;
using NeuralNetworks.GeneticAlgorithm.UI;
using NeuralNetworks.SimulatedAnnealing.UI;
using System;
using System.Windows.Forms;

namespace NeuralNetworks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var hopfieldForm = new Hopfield(this);
            hopfieldForm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var hammingForm = new Hamming(this);
            hammingForm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var geneticForm = new GeneticForm(this);
            geneticForm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var antForm = new AntAlgorithmForm(this);
            antForm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var beeForm = new BeeForm(this);
            beeForm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var annealingAlgorithmForm = new AnnealingAlgorithmForm(this);
            annealingAlgorithmForm.Show();
            Hide();
        }
    }
}