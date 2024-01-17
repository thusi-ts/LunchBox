using Calculator.Models;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var companySettings = builder.Configuration.GetSection("CompanySettings").Get<CompanySettings>();
            builder.Services.AddSingleton<CompanySettings>(companySettings);

            builder.Services.AddHttpClient("TemperatureHttpClient", config => { 
                config.BaseAddress = new Uri(companySettings.WeatherAPIBaseAddress);
                config.DefaultRequestHeaders.Add("Accept", "application/json");
            });

            var app = builder.Build();

            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapControllers();

            app.Run();
        }
    }
}