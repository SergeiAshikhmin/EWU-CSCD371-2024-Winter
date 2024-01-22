using System;
using System.Runtime.CompilerServices;

namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger? logger, string message, params int[] args)
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
            for (int i = 0 ; i < args.Length; i++){
                message = String.Format(message, args[i]);
            }
            logger.Log(LogLevel.Error, message);
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
