using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_CheckClassName_Success()
    {
        LogFactory LogFactory = new LogFactory();
        BaseLogger FileLogger = LogFactory.CreateLogger("FileLogger")!;
        Assert.AreEqual("FileLogger", FileLogger.ClassName);
    }

    [TestMethod]
    public void CreateLogger_CheckClassName_Fail()
    {
        LogFactory LogFactory = new LogFactory();
        BaseLogger FileLogger = LogFactory.CreateLogger("FileLogger")!;
        Assert.AreNotEqual("FileNotLogger", FileLogger.ClassName);
    }

    [TestMethod]
    public void ConfigureFileLogger_CorrectPathName_Success()
    {
        LogFactory LogFactory = new LogFactory();
        string PathName = LogFactory.ConfigureFileLogger("text.txt");
        Assert.AreEqual("text.txt", PathName);
    }
}
