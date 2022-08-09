namespace FactoryPattern.Services
{
    public class TaxCalculatorService : ITaxCalculatorService
    {
        private readonly ICalculatorFactory _calculatorFactory;

        public TaxCalculatorService(ICalculatorFactory calculatorFactory)
        {
            _calculatorFactory = calculatorFactory;
        }
        public double CalculateTax(string type, double amount)
        {
            var calculator = _calculatorFactory.GetCalculator(type);
            return calculator.CalculateTaxAmount(amount);
        }
    }
}