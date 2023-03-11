using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;

namespace DataAcces.Concrete.SQLServer
{
    public class SubCategoryDAL : EFRepositoryBase<SubCategory, AppDbContext>, ISubCategoryDAL
    {

    }
}