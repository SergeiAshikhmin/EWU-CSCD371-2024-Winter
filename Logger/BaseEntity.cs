using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

// We implemented the interface implicitly
public abstract class BaseEntity : IEntity
{
    public Guid Id { get; init; }
    public abstract string Name { get; }
}
