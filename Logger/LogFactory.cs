using System;
using System.Threading;

namespace Logger;

public class LogFactory
{
    private string? _PathName;
    public BaseLogger? CreateLogger(string className)
    {
        if(className == nameof(FileLogger)){
            FileLogger FileLogger = new FileLogger(_PathName!) {ClassName = className};
            return FileLogger;
        }

        return null;
    }
    public string ConfigureFileLogger(string pathName)
        {
            _PathName = pathName;
            return _PathName;
        }
}
