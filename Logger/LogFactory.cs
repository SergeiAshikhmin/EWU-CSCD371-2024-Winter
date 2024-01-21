using System;
using System.Threading;

namespace Logger;

public class LogFactory
{
    public BaseLogger CreateLogger(string className)
    {

        FileLogger FileLogger = new FileLogger();
        FileLogger.ClassName = className;
        return FileLogger;
    }
}
