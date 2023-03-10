using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } 
        // public int CategoryId { get; set; }
        // public Category Category { get; set; }

    }
}