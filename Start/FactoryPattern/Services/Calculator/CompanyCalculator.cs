namespace FactoryPattern.Services.Calculator
{
    public class CompanyCalculator : ICalculator
    {
        public double CalculateTaxAmount(double amount)
        {
            return amount * 20 / 100;
        }
    }
}