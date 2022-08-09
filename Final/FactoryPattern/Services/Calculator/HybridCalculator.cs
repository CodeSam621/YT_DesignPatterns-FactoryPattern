using FactoryPattern.Services.Calculator.@interface;

namespace FactoryPattern.Services.Calculator
{
    public class HybridCalculator : ICalculator
    {
        public string Name => "hybrid";

        public double CalculateTaxAmount(double amount)
        {
            return amount * 15 / 100;
        }
    }
}