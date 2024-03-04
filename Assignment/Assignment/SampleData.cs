using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows => File.ReadLines("People.csv").Skip(1);
        //{
        //    get
        //    {
        //        string? line;
        //        List<string> list = new();
        //        using(StreamReader sr = new(@"C:\CSCD371-Assignment7&8-MyAttempt\EWU-CSCD371-2024-Winter\Assignment\Assignment\People.csv"))
        //        {
        //            line = sr.ReadLine();
        //            while (line != null)
        //            {
        //                list.Add(line);
        //                line = sr.ReadLine();
        //            }
        //        }


        //        return list.Skip(1);
        //    }
        //}

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
            => CsvRows.Select(line => line.Split(',')[6]).Distinct().Order();

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => string.Join(',',GetUniqueSortedListOfStatesGivenCsvRows().ToArray());

        // 4.
        public IEnumerable<IPerson> People => throw new NotImplementedException();

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}
