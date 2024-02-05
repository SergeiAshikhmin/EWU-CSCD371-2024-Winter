using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookTest()
        {
            Book book = new Book("My Book");
            Assert.Equal("My Book", book.Name);
        }
    }
}
