using System.IO;

namespace Napilnik.Sources
{
    class FileLogWritter : ILogger
    {
        public virtual void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}