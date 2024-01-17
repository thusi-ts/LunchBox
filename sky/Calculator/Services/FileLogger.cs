using Calculator.Models;
using System.Text;

namespace Calculator.Services
{
    public class FileLogger : ILogger
    {
        private readonly String _filePath;

        public FileLogger(LoggerSettings loggerSettings)
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
}
