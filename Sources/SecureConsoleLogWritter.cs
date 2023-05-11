using System;

namespace Napilnik.Sources
{
    class SecureConsoleLogWritter : ILogger
    {
        private ILogger _logger;

        public SecureConsoleLogWritter(ILogger logger)
        {
            if(logger == null)
                throw new ArgumentNullException(nameof(logger));

            _logger = logger;
        }

        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                _logger.WriteError(message);
            }
        }
    }
}