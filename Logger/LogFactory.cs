using System;
using System.Threading;

namespace Logger;

public class LogFactory
{
    private string? _PathName;
    public BaseLogger CreateLogger(string className)
    {

        FileLogger FileLogger = new FileLogger(_PathName!);
        FileLogger.ClassName = className;
        return FileLogger;
    }
    public string ConfigureFileLogger(string pathName)
        {
            _PathName = pathName;
            return _PathName;
        }
}
