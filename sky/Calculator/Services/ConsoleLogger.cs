using System.Text;

namespace Calculator.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(String message)
        {
            Console.WriteLine(DateTime.Now.ToString("dd / MM / yyyy HH:mm") + " Result: " + message);
        }
    }
}
