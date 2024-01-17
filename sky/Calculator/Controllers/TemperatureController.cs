using System;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly IHttpClientFactory _tempHttpClient;
        private readonly CompanySettings _companySettings;

        public TemperatureController(IHttpClientFactory httpClientFactory, CompanySettings companySettings)
        {
            this._tempHttpClient = httpClientFactory;
            this._companySettings = companySettings;
        }

        [Route("City")]
        [HttpPost()]
        public async Task<IActionResult> GetTemperature([FromBody] TemperatureRequest request)
        {
            try
            {
                var httpClient = _tempHttpClient.CreateClient("TemperatureHttpClient");
                var responce = await httpClient.GetAsync("?key=" + _companySettings.WeatherAPIKey + "&q=" + request.City);
                responce.EnsureSuccessStatusCode();
                var temperatureResult = JsonConvert.DeserializeObject<TemperatureResult>(await responce.Content.ReadAsStringAsync());

                return Ok(temperatureResult);
            }
            catch
            {
                return BadRequest("Error in city name or weather API connection");
            }
        }
    }
}
