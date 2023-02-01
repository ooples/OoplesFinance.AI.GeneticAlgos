using OoplesFinance.AI.GeneticAlgos.Interfaces;

namespace OoplesFinance.AI.GeneticAlgos;

public class Population
{
    private readonly int _populationSize;
    private readonly int _maxGenerations;
    private readonly IChromosome _chromosome;
    private readonly IFitnessFunction _fitnessFunction;
    private readonly ISelectionMethod _selectionMethod;
    private List<IChromosome> _population { get; set; } = new();

    public Population(int populationSize, int maxGenerations, IChromosome chromosome, IFitnessFunction fitnessFunction, ISelectionMethod selectionMethod)
    {
        _populationSize = populationSize;
        _maxGenerations = maxGenerations;
        _chromosome = chromosome;
        _fitnessFunction = fitnessFunction;
        _selectionMethod = selectionMethod;
    }

    public void RunAlgo()
    {

    }
}