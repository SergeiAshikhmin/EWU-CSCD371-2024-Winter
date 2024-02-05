using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests
{
    public class BookRecordTests
    {
        [Fact]
        public void BookRecord_InitilizeName_Success()
        {
            BookRecord book = new("My Book");
            Assert.Equal("My Book", book.Name);
        }

        [Fact]
        public void BookRecord_SameBookEquals_Success()
        {
            BookRecord book1 = new("Is it my book?");
            BookRecord book2 = book1 with { };
            Assert.True(book1.Equals(book2));   
        }

        [Fact]
        public void BookRecord_TwoBooksNotEquals_Success()
        {
            BookRecord book1 = new("Narnia");
            BookRecord book2 = new("Narnia");
            Assert.False(book1.Equals(book2));
        }
    }
}
