using System;
using System.Collections.Generic;
using System.Linq;
using FactoryPattern.Services.Calculator;
using FactoryPattern.Services.Calculator.@interface;

namespace FactoryPattern.Services
{
    public interface ICalculatorFactory
    {
        ICalculator GetCalculator(string type);
    }
    public class CalculatorFactory :ICalculatorFactory
    {
        private readonly IEnumerable<ICalculator> _calculators;

        public CalculatorFactory(IEnumerable<ICalculator> calculators)
        {
            _calculators = calculators;
        }
        public ICalculator GetCalculator(string type)
        {
            var calculator = _calculators.FirstOrDefault(t => t.Name == type.ToLower());
            if (calculator == null)
            {
                throw new NotImplementedException();
            }

            return calculator;
        }
    }
}