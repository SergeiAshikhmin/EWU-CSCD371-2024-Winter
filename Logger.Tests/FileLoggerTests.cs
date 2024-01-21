using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void FileLogger_FilePathCheck_Success()
    {
        string FilePath = "text.txt";
        FileLogger FileLogger = new FileLogger(FilePath);
        Assert.AreEqual(FilePath, FileLogger.GetPathName());
    }

    [TestMethod]
    public void FileLogger_FilePathCheck_Fail()
    {
        string FilePath = "text.txt";
        FileLogger FileLogger = new FileLogger(FilePath);
        Assert.AreNotEqual("notText.txt", FileLogger.GetPathName());
    }

}
