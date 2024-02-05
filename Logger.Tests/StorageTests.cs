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
        [Fact]
        public void TestStorage_Contains()
        {
            var storage = new Storage();
            BookRecord bookRecord = new("Not my book");
            BookRecord bookRecord1 = new("Could be mine");
            BookRecord bookRecord2 = new("Lord of The Rings");

            storage.Add(bookRecord);
            storage.Add(bookRecord1);
            storage.Add(bookRecord2);

            Assert.True(storage.Contains(bookRecord2));
        }

        [Fact]
        public void TestStorage_Get()
        {
            var storage = new Storage();
            BookRecord bookRecord = new("Not my book");
            BookRecord bookRecord1 = new("Could be mine");
            BookRecord bookRecord2 = new("Lord of The Rings");

            storage.Add(bookRecord);
            storage.Add(bookRecord1);
            storage.Add(bookRecord2);

            IEntity? entity = storage.Get(bookRecord.Id);
            Assert.True(bookRecord.Equals(entity));

        }

    }
}
