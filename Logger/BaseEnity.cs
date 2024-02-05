using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public abstract class BaseEnity : IEntity
    {
        public Guid ID { get; init; }
        public abstract string Name { get; set; }
    }
}
