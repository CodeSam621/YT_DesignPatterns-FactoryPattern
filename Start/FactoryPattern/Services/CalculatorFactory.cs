using System;
using FactoryPattern.Services.Calculator;

namespace FactoryPattern.Services
{
    public interface ICalculatorFactory
    {
        ICalculator GetCalculator(string type);
    }

    public class CalculatorFactory:ICalculatorFactory
    {
        public  ICalculator GetCalculator(string type)
        {
            switch (type.ToLower())
            {
                case "individual":
                    return new IndividualCalculator();
                case "company":
                    return new CompanyCalculator();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}