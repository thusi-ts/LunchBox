using Calculator.Controllers;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorTests
{
    public class DivitionTest
    {
        CalculatorController _calculator;

        [Fact]
        public void DivisionNumbersGivesCorrectResultForBadRequest()
        {
            var companySettings = new CompanySettings();

            _calculator = new CalculatorController(companySettings);

            var response = _calculator.Division(new CalculationRequest { Number1 = 1, Number2 = 0 });

            Assert.IsType<BadRequestObjectResult>(response);

            Assert.Equal("Microsoft.AspNetCore.Mvc.BadRequestObjectResult", response.ToString());
        }

        [Fact]
        public void DivisionNumbersGivesCorrectResultForSuccess()
        {
            var companySettings = new CompanySettings();

            _calculator = new CalculatorController(companySettings);

            IActionResult actionResult = _calculator.Division(new CalculationRequest { Number1 = 6, Number2 = 2 });

            Assert.IsType<OkObjectResult>(actionResult);
        }
    }
}
