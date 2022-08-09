using FactoryPattern.Services.Calculator.@interface;

namespace FactoryPattern.Services.Calculator
{
    public class IndividualCalculator : ICalculator
    {
        public string Name => "individual";
        public double CalculateTaxAmount(double amount)
        {
          return amount * 10 / 100;
        }
    }
}