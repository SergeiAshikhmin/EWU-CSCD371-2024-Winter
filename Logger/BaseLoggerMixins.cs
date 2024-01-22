using System;
using System.Runtime.CompilerServices;

namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger? logger, string message, params object[] args)
    {
        if(logger == null)
        {
            throw new ArgumentNullException("Error extention method: Missing BaseLogger");
        }

        if(args == null)
        {
            logger.Log(LogLevel.Error, message);
        }
        else
        {
            
            String TempMessage = String.Format(message, args);
            
            logger.Log(LogLevel.Error, TempMessage);
        }

        
    }

    public static void Warning(this BaseLogger? logger, string message, params string[] args)
    {
        if (logger == null)
        {
            throw new ArgumentNullException("Error extention method: Missing BaseLogger");
        }

        logger.Log(LogLevel.Warning, message);
    }

    public static void Information(this BaseLogger? logger, string message, params string[] args)
    {
        if (logger == null)
        {
            throw new ArgumentNullException("Error extention method: Missing BaseLogger");
        }

        logger.Log(LogLevel.Information, message);
    }

    public static void Debug(this BaseLogger? logger, string message, params string[] args)
    {
        if (logger == null)
        {
            throw new ArgumentNullException("Error extention method: Missing BaseLogger");
        }

        logger.Log(LogLevel.Debug, message);
    }
}
