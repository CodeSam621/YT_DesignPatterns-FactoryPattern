namespace FactoryPattern.Services
{
    public interface ITaxCalculatorService
    {
        double CalculateTax(string type, double amount);
    }
}