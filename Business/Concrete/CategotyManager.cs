using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategotyManager : ICategoryServices
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategotyManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void AddCategory(Category category)
        {
            _categoryDAL.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public IEnumerable<Category> GetAllActiveCategories()
        {
            return _categoryDAL.GetAll(x => x.IsDeleted == false);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDAL.Get(x => x.Id == id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}