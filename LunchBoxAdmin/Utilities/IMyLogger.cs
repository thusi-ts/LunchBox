using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text;

/*

startup
services.Configure<LoggerSettingsOptions>(options => {
                                                options.LogFilePath = Configuration.GetSection("LoggerSettings:LogFilePath").Value;
                                                });

            //services.AddTransient<IMyLoggerProvider<ConsoleLogger>, ConsoleLoggerProvider>();
            services.AddTransient<IMyLoggerProvider<ConsoleLogger>>(serviceProvider =>
            {
                //var loggerSettings = serviceProvider.GetRequiredService<IOptions<LoggerSettingsOptions>>().Value;
                return new ConsoleLoggerProvider();
            });

            services.AddTransient<IMyLoggerProvider<FileLogger>, FileLoggerProvider>();
*/

namespace LunchBoxAdmin.Utilities
{
    public interface IMyLogger
    {
        void Log(String message);
    }


    public class ConsoleLogger : IMyLogger
    {
        public void Log(String message)
        {
            Console.WriteLine(DateTime.Now.ToString("dd / MM / yyyy HH:mm") + " Result: " + message);
        }
    }

    public class FileLogger : IMyLogger
    {
        private readonly String _filePath;

        public FileLogger(LoggerSettingsOptions loggerSettings)
        {
            this._filePath = loggerSettings.LogFilePath;
        }

        public void Log(String message)
        {
            using (FileStream fs = File.Create(this._filePath))
            {
                byte[] messageBytes = new UTF8Encoding(true).GetBytes(DateTime.Now.ToString("dd / MM / yyyy HH:mm") + " Result: " + message);
                fs.Write(messageBytes);
            }
        }
    }

    public interface IMyLoggerProvider<TLogger> where TLogger : IMyLogger
    {
        TLogger CreateLogger();
    }

    public class ConsoleLoggerProvider : IMyLoggerProvider<ConsoleLogger>
    {
        public ConsoleLoggerProvider()
        {

        }

        public ConsoleLogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }

    public class FileLoggerProvider : IMyLoggerProvider<FileLogger>
    {
        private readonly LoggerSettingsOptions _loggerSettings;

        public FileLoggerProvider(IOptions<LoggerSettingsOptions> loggerSettings)
        {
            _loggerSettings = loggerSettings.Value;
        }

        public FileLogger CreateLogger()
        {
            return new FileLogger(_loggerSettings);
        }
    }

    public class LoggerSettingsOptions
    {
        public String LogFilePath { get; set; }
    }

    /*
     * public interface IMyLogger
{
    void Log(string message);
}

public class ConsoleLogger : IMyLogger
{
    public void Log(string message)
    {
        Console.WriteLine(DateTime.Now.ToString("dd / MM / yyyy HH:mm") + " Result: " + message);
    }
}

public class FileLogger : IMyLogger
{
    private readonly string _filePath;

    public FileLogger(string logFilePath)
    {
        _filePath = logFilePath;
    }

    public void Log(string message)
    {
        using (FileStream fs = File.Create(_filePath))
        {
            byte[] messageBytes = new UTF8Encoding(true).GetBytes(DateTime.Now.ToString("dd / MM / yyyy HH:mm") + " Result: " + message);
            fs.Write(messageBytes);
        }
    }
}

public interface ILoggerProvider
{
    IMyLogger CreateLogger();
}

public class ConsoleLoggerProvider : ILoggerProvider
{
    public IMyLogger CreateLogger()
    {
        return new ConsoleLogger();
    }
}

public class FileLoggerProvider : ILoggerProvider
{
    private readonly string _logFilePath;

    public FileLoggerProvider(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    public IMyLogger CreateLogger()
    {
        return new FileLogger(_logFilePath);
    }
}

public static class LoggerProviderFactory
{
    public static ILoggerProvider CreateLoggerProvider(LoggerSettings loggerSettings)
    {
        switch (loggerSettings.ProviderType)
        {
            case "Console":
                return new ConsoleLoggerProvider();
            case "File":
                return new FileLoggerProvider(loggerSettings.LogFilePath);
            default:
                throw new ArgumentException("Invalid provider type");
        }
    }
}

public class LoggerSettings
{
    public string ProviderType { get; set; }
    public string LogFilePath { get; set; }
}
    */
      
}


