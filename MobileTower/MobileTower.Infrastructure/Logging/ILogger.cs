using System;
using System.Collections.Generic;
using System.Text;

namespace MobileTower.Infrastructure.Logging
{
    public interface ILogger
    {
        void LogInfo(object message);

        void Error(object message);

        void Debug(object message);

        void LogWarning(object message);
    }
}
