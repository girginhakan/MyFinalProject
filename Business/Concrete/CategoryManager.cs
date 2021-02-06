using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //iş kodları
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
        //select*from Categories where CategoryId demek GetById
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
