using FactoryPattern.Services.Calculator.@interface;

namespace FactoryPattern.Services.Calculator
{
    public class CompanyCalculator : ICalculator
    {
        public string Name => "company";
        public double CalculateTaxAmount(double amount)
        {
            return amount * 20 / 100;
        }
    }
}