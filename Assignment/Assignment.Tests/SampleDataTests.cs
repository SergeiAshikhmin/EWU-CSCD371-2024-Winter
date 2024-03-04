using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SampleDataTests
{
    [TestMethod]
    public void CsvRows()
    {
        Assert.IsTrue(TestingData.Data.Contains("Sergei"));
    }

}
