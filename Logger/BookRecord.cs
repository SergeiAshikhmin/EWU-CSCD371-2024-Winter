using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class BookRecord(Guid Id, string Name) : IEntity
{
    // we implemented implicitly:
    // because each BookRecord object needs to have the id accessible in order to use the Get() function.
    public Guid Id { get; init; } = Id;
    // we implemented explicitly:
    // because the Book record and the IEntity both have a duplicated naming convention for the Property Name.
    string IEntity.Name { get; } = Name;

}
