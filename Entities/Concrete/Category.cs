using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Core.Entities;

namespace Entities.Concrete
{
    public class Category :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public int MyProperty { get; set; }
    }
}