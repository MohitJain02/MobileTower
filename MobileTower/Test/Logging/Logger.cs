using log4net;
using log4net.Config;

namespace Test.Logging
{
    public sealed class Logger : ILogger
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Logger()
        {
             XmlConfigurator.Configure();
        }

        public void Debug(object message)
        {
            log.Debug(message);
        }

        public void Error(object message)
        {
            log.Error(message);
        }

        public void LogInfo(object message)
        {
            log.Info(message);
        }

        public void LogWarning(object message)
        {
            log.Warn(message);
        }
    }
}
