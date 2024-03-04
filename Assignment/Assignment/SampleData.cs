﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows => File.ReadLines("People.csv").Skip(1);

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
            => CsvRows.Select(line => line.Split(',')[6]).Distinct().Order();

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => string.Join(',',GetUniqueSortedListOfStatesGivenCsvRows());

        // 4.
        public IEnumerable<IPerson> People
        {
            get
            {
                IEnumerable<IPerson> sortedByAddress = CsvRows
                    .Select(line => line.Split(","))
                    .OrderBy(line => line[6])
                    .ThenBy(line => line[5])
                    .ThenBy(line => line[7])
                    .Select(line => new Person(line[1], line[2], new Address(line[4], line[5], line[6], line[7]), line[3]));
                return sortedByAddress;
            }
        }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => People
            .Where(person => filter(person.EmailAddress))
            .Select(person => (person.FirstName, person.LastName));

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => string.Join(',',
            people
            .Select(person => person.Address.State)
            .Distinct()
            .Order()
            );
    }
}
