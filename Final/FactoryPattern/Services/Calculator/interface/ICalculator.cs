namespace FactoryPattern.Services.Calculator.@interface
{
    public interface ICalculator
    {
        string Name { get; }
        double CalculateTaxAmount(double amount);
    }
}