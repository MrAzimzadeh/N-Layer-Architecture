using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;


namespace Entities.Concrete
{
    public class ProductPicture : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PictureId { get; set; }
        public Picture Picture { get; set; }

    }
}