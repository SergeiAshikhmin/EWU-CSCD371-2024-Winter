using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void CreateLogger_CheckClassName_Success()
    {
        LogFactory LogFactory = new();
        Assert.AreEqual("FileLogger", LogFactory.CreateLogger("FileLogger")!.ClassName);
    }

    [TestMethod]
    public void CreateLogger_CheckClassName_Fail()
    {
        LogFactory LogFactory = new();
        Assert.AreNotEqual("FileNotLogger", LogFactory.CreateLogger("FileLogger")!.ClassName);
    }

    [TestMethod]
    public void ConfigureFileLogger_CorrectPathName_Success()
    {
        LogFactory LogFactory = new();
        Assert.AreEqual("text.txt", LogFactory.ConfigureFileLogger("text.txt"));
    }

    [TestMethod]
    public void CreateLogger_InvalidClassName_Fail()
    {
        LogFactory LogFactory = new();
        Assert.AreEqual(null, LogFactory.CreateLogger("InvalidClaseName"));

    }
}
