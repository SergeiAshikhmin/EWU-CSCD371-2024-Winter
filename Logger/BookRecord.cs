using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class BookRecord(string Name) : IEntity
    {
        public Guid ID { get; init; } = typeof(BookRecord).GUID;

        string IEntity.Name { get => Name; set => throw new NotImplementedException(); }
    }
}
