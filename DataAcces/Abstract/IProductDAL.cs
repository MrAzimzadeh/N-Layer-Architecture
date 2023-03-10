using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAcces;
using Entities.Concrete;

namespace DataAcces.Abstract
{
    public interface IProductDAL : IRepositoryBase<Product>
    {
        
    }
}