namespace NeuralNetworks.AntAlgorithm.UI;

public class MatrixCell
{
    public const int LACK_PHERAMON = 0;
    public const int DEFAULT_VALUE_PHERAMON = 1;
    public double Weight { get; set; }
    public double Pheromone { get; set; }

    public bool IsValid()
    {
        return Weight > 0;
    }
}