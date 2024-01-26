using System;
using System.Threading;

namespace Logger;

public class LogFactory
{
    private string? _PathName;

    public LogFactory(string filePath)
    {
        ConfigureFileLogger(filePath);
    }
    public BaseLogger? CreateLogger(string className)
    {
        if(className == nameof(FileLogger)){
            FileLogger FileLogger = new(_PathName!) {ClassName = className};
            if(FileLogger.GetPathName() == null)
            {
                return null;
            }

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
