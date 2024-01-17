using Calculator.Controllers;
using Calculator.Models;

namespace CalculatorTests
{
    public class AdditionTest
    {
        [Fact]
        public void AddingNumbersGivesCorrectResult()
        {

            var companySettings = new CompanySettings();
            var calculator = new CalculatorController(companySettings);

            var result = calculator.Addition(new CalculationRequest { Number1 = 1, Number2 = 2 });

            Assert.Equal(3, result.Result);
        }
    }
}