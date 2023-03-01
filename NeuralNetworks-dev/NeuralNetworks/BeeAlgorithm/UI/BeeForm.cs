using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworks.BeeAlgorithm.Algorithm;

namespace NeuralNetworks.BeeAlgorithm.UI
{
    public partial class BeeForm : Form
    {
        private readonly Form _parentForm;
        public BeeForm(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void countScoutBeesNumeric_ValueChanged(object sender, EventArgs e)
        {
            countLocalSearchNumeric.Maximum = countScoutBeesNumeric.Value;
        }

        private void countLocalSearchNumeric_ValueChanged(object sender, EventArgs e)
        {
            countElitePointsNumeric.Maximum = countLocalSearchNumeric.Value;
        }

        private void lowerBoundNumeric_ValueChanged(object sender, EventArgs e)
        {
            upperBoundNumeric.Minimum = lowerBoundNumeric.Value;
        }

        private void upperBoundNumeric_ValueChanged(object sender, EventArgs e)
        {
            lowerBoundNumeric.Maximum = upperBoundNumeric.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            upperBoundNumeric.Minimum = lowerBoundNumeric.Value;
            lowerBoundNumeric.Maximum = upperBoundNumeric.Value;
            functionsComboBox.Text = functionsComboBox.Items[0].ToString();
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            calculateButton.Enabled = false;
            var expression = functionsComboBox.Text;

            BeeAlgorithmLogic algorithm = new();

            var optimalArguments = await Task.Run(()
                => algorithm.GetResultArguments(
                    (int)countElitePointsNumeric.Value,
                    (int)countIterationsNumeric.Value,
                    (int)countEliteBeesNumeric.Value,
                    (int)countDefaultBeesNumeric.Value,
                    (int)countLocalSearchNumeric.Value,
                    expression,
                    (double)deltaNumeric.Value,
                    (int)countScoutBeesNumeric.Value,
                    (int)lowerBoundNumeric.Value,
                    (int)upperBoundNumeric.Value));

            var optimumFunc = algorithm.GetResult(optimalArguments);
            var argumentsNames = algorithm.GetNamesArguments();
            var stringBuilder = new StringBuilder();

            for (var argumentIndex = 0; argumentIndex < argumentsNames.Length; argumentIndex++)
            {
                stringBuilder.AppendLine($"{argumentsNames[argumentIndex]} = {optimalArguments[argumentIndex]}");
            }

            stringBuilder.Append($"Значение функции: {optimumFunc}");

            MessageBox.Show(stringBuilder.ToString());

            calculateButton.Enabled = true;
        }

        private void BeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
