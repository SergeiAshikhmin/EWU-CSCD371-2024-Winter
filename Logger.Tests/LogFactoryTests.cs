﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_CheckClassName_Success()
    {
        LogFactory LogFactory = new LogFactory();
        BaseLogger FileLogger = LogFactory.CreateLogger("FileLogger");
        Assert.AreEqual("FileLogger", FileLogger.ClassName);
    }
}
