using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FactoryPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxController
    {
        private readonly ITaxCalculatorService _taxCalculatorService;
        private readonly ILogger<TaxController> _logger;

        public TaxController(ITaxCalculatorService  taxCalculatorService,
            ILogger<TaxController> logger)
        {
            _taxCalculatorService = taxCalculatorService;
            _logger = logger;
        }

        [HttpPost]
        [Route("calculate/{type}/{amount}")]
        public double Calculate(string type, double amount)
        {
            _logger.LogInformation($"Tax type: {type}");
            var taxAmount = _taxCalculatorService.CalculateTax(type, amount);
            return taxAmount;
        }
    }
}