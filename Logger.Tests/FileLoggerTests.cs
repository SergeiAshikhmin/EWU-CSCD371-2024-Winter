using System;
using System.IO;

using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
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

    [TestMethod]
    public void Log_WriteToAFile_Success()
    {
        string FilePath = "C:\\CSCD371\\EWU-CSCD371-2024-Winter\\Text.txt";
        string Message = "Here is my message, please don't yeal at me";

        if(File.Exists(FilePath))
        {
            File.Delete(FilePath);
        }

        FileLogger FileLogger = new FileLogger(FilePath);
        FileLogger.ClassName = "FileLogger";
        FileLogger.Log(LogLevel.Error, Message);

        StreamReader StreamReader = new StreamReader(FilePath);
        string MessageFromStreamReader = StreamReader.ReadLine() ?? string.Empty;
        StreamReader.Close();

        DateTime DateTime = DateTime.Now;
        string MessageToAppend = $"{DateTime} FileLogger Error : {Message}";

        Assert.AreEqual(MessageToAppend, MessageFromStreamReader);

    }

}
