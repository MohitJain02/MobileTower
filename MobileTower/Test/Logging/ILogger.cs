using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Logging
{
    public interface ILogger
    {
        void LogInfo(object message);

        void Error(object message);

        void Debug(object message);

        void LogWarning(object message);
    }
}
