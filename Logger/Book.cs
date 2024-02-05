using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Book(string Name) : IEntity
    {
        public Guid ID { get; init; } = typeof(Book).GUID;
        public string Name
        {
            get
            {
                return Name;
            }
        }
    }
}
