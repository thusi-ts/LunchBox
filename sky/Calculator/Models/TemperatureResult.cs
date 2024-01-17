using Newtonsoft.Json;

namespace Calculator.Models
{
    public class TemperatureResult
    {
        [JsonProperty("current")]
        public Current Current {  get; set; } 
        
    }

    public class Current
    {
        [JsonProperty("temp_c")]
        public decimal TempC { get; set; }

        [JsonProperty("temp_f")]
        public decimal TempF { get; set; }
    }
}
