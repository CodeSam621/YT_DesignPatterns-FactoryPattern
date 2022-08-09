using FactoryPattern.Services.Calculator.@interface;

namespace FactoryPattern.Services.Calculator
{
    public class ComplexCalculator : ICalculator
    {
        public string Name => "complex";
        public double CalculateTaxAmount(double amount)
        {
          return amount * 10 / 100 + 25;
        }
    }
}