using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class BookRecord(string Name) : IEntity
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        string IEntity.Name { get; set; } = Name;

        //public string Name { get; init; } = Name ?? throw new ArgumentNullException(nameof(Name));

    }
}
