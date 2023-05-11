using System;
using System.Collections.Generic;

namespace Napilnik.Sources
{
    class ChainOfLogWritter : ILogger
    {
        private IEnumerable<ILogger> _loggers;

        public ChainOfLogWritter(IEnumerable<ILogger> loggers)
        {
            if (loggers == null)
                throw new ArgumentNullException(nameof(loggers));

            _loggers = loggers;
        }

        public void WriteError(string message)
        {
            foreach(ILogger logger in _loggers)
            {
                logger.WriteError(message);
            }
        }
    }
}