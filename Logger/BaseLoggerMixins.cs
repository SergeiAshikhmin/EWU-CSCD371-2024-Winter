using System.Runtime.CompilerServices;

namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger logger, string message, params string[] args)
    {
        logger.Log(LogLevel.Error, message);
    }
}
