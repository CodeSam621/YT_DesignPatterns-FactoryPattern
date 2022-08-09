namespace FactoryPattern.Services.Calculator
{
    public class IndividualCalculator : ICalculator
    {
        public double CalculateTaxAmount(double amount)
        {
          return amount * 10 / 100;
        }
    }
}