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

    [TestMethod]
    public void People_ReturnAllItemsAsPersonObjects()
    {
        IPerson expected = new Person("Scarface",
            "Dennington",
            new Address("9978 Maple Wood Parkway", "Memphis", "TN", "99928"),
            "sdennington9@chron.com");
        SampleData sampleData = new();
        IEnumerable<IPerson> people = sampleData.People;
        IPerson actual = people
            .Where(person => person.FirstName == "Scarface" && person.LastName == "Dennington").First();
        Assert.AreEqual(50, people.Count());
        Assert.AreEqual(expected.FirstName, actual.FirstName);
        Assert.AreEqual(expected.LastName, actual.LastName);
        Assert.AreEqual(expected.Address.City, actual.Address.City);
        Assert.AreEqual(expected.Address.State, actual.Address.State);
        Assert.AreEqual(expected.Address.StreetAddress, actual.Address.StreetAddress);
        Assert.AreEqual(expected.Address.Zip, actual.Address.Zip);
        Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
    }

    [TestMethod]
    [DataRow("pjenyns0@state.gov", "Priscilla", "Jenyns")] // 1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577
    [DataRow("mkerslake4@dion.ne.jp", "Melisa", "Kerslake")] //5,Melisa,Kerslake,mkerslake4@dion.ne.jp,283 Pawling Parkway,Dallas,TX,88632
    [DataRow("sdennington9@chron.com", "Scarface", "Dennington")] //10,Scarface,Dennington,sdennington9@chron.com,9978 Maple Wood Parkway,Memphis,TN,99928
    [DataRow("pchastagniere@reference.com", "Phillida", "Chastagnier")] //15,Phillida,Chastagnier,pchastagniere@reference.com,1 Rutledge Point,Spokane,WA,99021
    public void FilterByEmailAddress_ReturnsListOfNames_True(string emailFilter, string firstNameExpected, string lastNameExpected)
    {
        SampleData sampleData = new();
        Predicate<string> filter = email =>  email == emailFilter;
        IEnumerable<(string firstName, string lastName)> people = sampleData.FilterByEmailAddress(filter);
        Assert.AreEqual((firstNameExpected, lastNameExpected), people.First());

    }

    [TestMethod]
    public void GetAggregateListOfStatesGivenPeopleCollection_ReturnsListOfStatesGivenPeopleCollection()
    {
        SampleData sampleData = new();
        string states = sampleData.GetAggregateListOfStatesGivenPeopleCollection(sampleData.People);
        Assert.AreEqual(TestingData.uniqueSortedStates, states);
        Assert.AreEqual(string.Join(',', sampleData.GetUniqueSortedListOfStatesGivenCsvRows()), states);
    }

}
