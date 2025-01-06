using System.IO;
namespace InterfaceAndExtensibility
{
    public class FileLogger : Ilogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true)) // Fixed to use StreamWriter
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
