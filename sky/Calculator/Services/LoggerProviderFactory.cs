using Calculator.Models;


namespace Calculator.Services
{
    public interface IloggerProvider
    {
        ILogger CreateLogger();
    }

    public class ConsoleLoggerProvider : IloggerProvider
    {
        public ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }

    public class FileLoggerProvider : IloggerProvider
    {
        private readonly LoggerSettings _loggerSettings;
        public FileLoggerProvider(LoggerSettings loggerSettings)
        {
            this._loggerSettings = loggerSettings;
        }

        public ILogger CreateLogger()
        {
            return new FileLogger(this._loggerSettings);
        }
    }

    public class LoggerProviderFactory
    {
        public static IloggerProvider CreateLoggerProvider(LoggerSettings loggerSettings)
        {
            switch (loggerSettings.ProviderType)
            {
                case "Console":
                    return new ConsoleLoggerProvider();
                case "File":
                    return new FileLoggerProvider(loggerSettings);
                default:
                    throw new ArgumentException("Invalid provider type");
            }
        }
    }
}
