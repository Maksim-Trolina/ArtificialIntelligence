namespace NeuralNetworks.GeneticAlgorithm.UI
{
    public enum CrossingType
    {
        Point,
        Flat,
        Simplest,
        Arithmetic,
        Geometry,
        Linear
    }

    public enum MutationType
    {
        BinaryRandom,
        RealRandom
    }

    public enum SelectionType
    {
        SimpleSelection,
        PanmixiaSelection,
        RankSelection,
        ToutnamentSelection,
        Inbreeding,
        Outbreeding
    }
}
