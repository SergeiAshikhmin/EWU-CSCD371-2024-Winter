using Assignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

[TestClass]
public class SampleDataTests
{
    [TestMethod]
    public void CsvRows_CountData()
    {
        SampleData sampleData = new SampleData();
        IEnumerable<string> data = sampleData.CsvRows;
        Assert.AreEqual(50, data.Count());
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_ReturnsSortedUniqueStatesFromHardCodedList_True()
    {
        IEnumerable<string> expected = TestingData.uniqueSortedStates.Split(',');
        SampleData sampleData = new();
        IEnumerable<string> actual = sampleData.GetUniqueSortedListOfStatesGivenCsvRows().ToArray();
        bool result = actual.SequenceEqual(expected);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void GetUniquenessSortedListOfStatesGivenCsvRows_ReturnSortedUniqueStatesUsesLINQ_Ture()
    {
        SampleData sampleData = new();
        IEnumerable<string> expected = sampleData.CsvRows.Select(line => line.Split(',')[6]).Distinct().Order();
        IEnumerable<string> actual = sampleData.GetUniqueSortedListOfStatesGivenCsvRows();
        Assert.IsTrue(actual.SequenceEqual(expected));
    }

    [TestMethod]
    public void GetAggregateSortedListOfStatesGivenCsvRows_ReturnSortedUniqueStatesString_Ture()
    {
        string expected = TestingData.uniqueSortedStates;
        SampleData sampleData = new();
        string actual = sampleData.GetAggregateSortedListOfStatesUsingCsvRows();
        Assert.AreEqual(expected, actual);
    }

}
