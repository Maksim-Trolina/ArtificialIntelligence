using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworks.GeneticAlgorithm.UI
{
    public partial class GeneticForm : Form
    {
        private CrossingType _currentCrossingType;
        private MutationType _currentMutationType;
        private SelectionType _currentSelectionType;

        private readonly Form _parentForm;
        public GeneticForm(Form parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            functionsComboBox.SelectedIndex = 0;
            flatCrossing.Checked = true;
            realRandomMutation.Checked = true;
            simpleSelection.Checked = true;
            countPointsNumeric.Visible = binaryPointCrossing.Checked;
        }

        #region selection
        private void simpleSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (simpleSelection.Checked)
            {
                _currentSelectionType = SelectionType.SimpleSelection;
            }
        }
        private void rankSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (rankSelection.Checked)
            {
                _currentSelectionType = SelectionType.RankSelection;
            }
        }

        private void panmixiaSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (panmixiaSelection.Checked)
            {
                _currentSelectionType = SelectionType.PanmixiaSelection;
            }
        }
        private void tournamentSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (tournamentSelection.Checked)
            {
                _currentSelectionType = SelectionType.ToutnamentSelection;
            }
        }
        private void inbreedingSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (inbreedingSelection.Checked)
            {
                _currentSelectionType = SelectionType.Inbreeding;
            }
        }
        private void outbreedingSelection_CheckedChanged(object sender, EventArgs e)
        {
            if (outbreedingSelection.Checked)
            {
                _currentSelectionType = SelectionType.Outbreeding;
            }
        }
        #endregion

        #region crossing
        private void flatCrossing_CheckedChanged(object sender, EventArgs e)
        {
            if (flatCrossing.Checked)
            {
                _currentCrossingType = CrossingType.Flat;
            }
        }
        private void binaryPointCrossing_CheckedChanged(object sender, EventArgs e)
        {
            countPointsNumeric.Visible = binaryPointCrossing.Checked;

            if (binaryPointCrossing.Checked)
            {
                _currentCrossingType = CrossingType.Point;
            }
        }

        private void simplestCrossing_CheckedChanged(object sender, EventArgs e)
        {
            if (simpleSelection.Checked)
            {
                _currentCrossingType = CrossingType.Simplest;
            }
        }

        private void ArithmeticCrossing_CheckedChanged(object sender, EventArgs e)
        {
            if (arithmeticCrossing.Checked)
            {
                _currentCrossingType = CrossingType.Arithmetic;
            }
        }

        private void geometryCrossing_CheckedChanged(object sender, EventArgs e)
        {
            if (geometryCrossing.Checked)
            {
                _currentCrossingType = CrossingType.Geometry;
            }
        }

        private void linearCrossing_CheckedChanged(object sender, EventArgs e)
        {
            if (linearCrossing.Checked)
            {
                _currentCrossingType = CrossingType.Linear;
            }
        }

        #endregion

        #region mutation
        private void realRandomMutation_CheckedChanged(object sender, EventArgs e)
        {
            if (realRandomMutation.Checked)
            {
                _currentMutationType = MutationType.RealRandom;
            }
        }

        private void binaryRandomMutation_CheckedChanged(object sender, EventArgs e)
        {
            if (binaryRandomMutation.Checked)
            {
                _currentMutationType = MutationType.BinaryRandom;
            }
        }
        #endregion

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            var expression = functionsComboBox.Text;

            var presenter = new Presenter
                (
                    _currentSelectionType,
                    _currentCrossingType,
                    _currentMutationType,
                    (int)numberSurvivedNumeric.Value,
                    (int)countPointsNumeric.Value,
                    (double)(probabilityNumeric.Value / probabilityNumeric.Maximum)
                );

            try
            {
                var optimalArguments = await Task.Run(
                    () => presenter.GetResultArguments(expression
                                    , (int)countStartedPopulationNumeric.Value
                                    , (int)countGenerationNumeric.Value
                                    , (int)numberSurvivedNumeric.Value)
                    );

                var optimumFunc = presenter.GetResult(optimalArguments);

                var argumentsNames = presenter.GetNamesArguments();

                var stringBuilder = new StringBuilder();

                for (var i = 0; i < argumentsNames.Length; i++)
                {
                    stringBuilder.Append($"{argumentsNames[i]} = {optimalArguments[i]}\n");
                }

                stringBuilder.Append($"Значение функции: {optimumFunc}");

                MessageBox.Show(stringBuilder.ToString());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Введена некорректная функция");
            }
        }

        private void GeneticForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parentForm.Show();
        }
    }
}
