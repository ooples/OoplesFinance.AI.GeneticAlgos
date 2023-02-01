namespace OoplesFinance.AI.GeneticAlgos.Interfaces;

public interface IChromosome : IComparable
{
    public double FitnessScore { get; }

    public void Crossover();

    public void Mutate();
}