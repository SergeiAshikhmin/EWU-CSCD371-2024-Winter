using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logger;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class BaseLoggerTests
{
    [TestMethod]
    public void AutoProperty_SetClassNameToNull_Success()
    {
        MocLogger MocLogger = new();
        Assert.AreEqual(null, MocLogger.ClassName);
    }

    [TestMethod]
    public void AutoProperty_SetClassNameToProperName_Sucess()
    {
        MocLogger MocLogger = new();
        MocLogger.ClassName = "FileLogger";
        Assert.AreEqual(nameof(FileLogger), MocLogger.ClassName);
    }
}


public class MocLogger : BaseLogger
{
    public override void Log(LogLevel logLevel, string message)
    {
        throw new NotImplementedException();
    }
}
