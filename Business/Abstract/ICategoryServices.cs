using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryServices
    {
        void AddCategory(Category category);
        void  UpdateCategory(Category category);
        void DeleteCategory(Category category);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Category> GetAllActiveCategories();
    }
}