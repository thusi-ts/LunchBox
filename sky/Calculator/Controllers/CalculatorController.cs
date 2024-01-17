using Calculator.Models;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using ILogger = Calculator.Services.ILogger;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger _fileLogger;
        private readonly ILogger _consoleLogger;

        public CalculatorController(CompanySettings companySettings)
        {
            var fileLoggerSettings = new LoggerSettings { LogFilePath = companySettings.LogFilePath, ProviderType = "File" };
            var consoleLoggerSettings = new LoggerSettings { ProviderType = "Console" };

            var fileLoggerProvider = LoggerProviderFactory.CreateLoggerProvider(fileLoggerSettings);
            this._fileLogger = fileLoggerProvider.CreateLogger();

            var consoleLoggerProvider = LoggerProviderFactory.CreateLoggerProvider(consoleLoggerSettings);
            this._consoleLogger = consoleLoggerProvider.CreateLogger();
        }

        [Route("Addition")]
        [HttpPost()]
        public CalculationResult Addition([FromBody] CalculationRequest request)
        {
            var logger = new SqlLogger();
            logger.Log($"Adding {request.Number1} to {request.Number2}");
            return new CalculationResult
            {
                Result = request.Number1 + request.Number2
            };
        }

        [Route("Division")]
        [HttpPost()]
        public IActionResult Division([FromBody] CalculationRequest request)
        {
            if (request.Number2 == 0)
            {
                return BadRequest("You can't divide with zero");
            }

            var calculationReult = new CalculationResult
            {
                Result = request.Number1 / request.Number2
            };

            return Ok(calculationReult);
        }

        [Route("AdditionForFiveNumbers")]
        [HttpPost()]
        public IActionResult Addition([FromBody] CalculationRequestForFiveNumbers request)
        {
            var calculationReult = new CalculationResult
            {
                Result = request.Number1 + request.Number2 + request.Number3 + request.Number4 + request.Number5
            };
            try
            {
                this._fileLogger.Log(calculationReult.Result.ToString());
                this._consoleLogger.Log(calculationReult.Result.ToString());
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            return Ok(calculationReult);
        }
    }
}