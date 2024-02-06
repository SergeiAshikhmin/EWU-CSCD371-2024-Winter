using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests
{
    public class StorageTests
    {
        // BookRecod
        [Fact]
        public void Add_BookRecord_Success()
        {
            BookRecord record = new("The Great Gatsby");
            

            Storage storage = new();
            storage.Add(record);

            Assert.True(storage.Contains(record));
        }

        [Fact]
        public void Remove_BooktRecord_Success()
        {
            BookRecord record = new("To Kill a Mockingbird");

            Storage storage = new();
            storage.Add(record);

            storage.Remove(record);

            Assert.False(storage.Contains(record));
        }

        [Fact]
        public void Get_ReturnsCorrectBookRecordId_Success()
        {
            BookRecord record = new("Moby-Dick");

            Storage storage = new();
            storage.Add(record);

            Assert.Equal<IEntity>(record, storage.Get(record.Id));
        }

        // Employee

    }
}
