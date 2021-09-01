﻿using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class CategoryManager : ICategoryService // burada kullanılan her metodu önce interface içerisinde tanımla.
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public List<Category> GetList()
        {
            return _categoryDal.List();
        }


        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category); // fluentValidation kontrollerini controller tarafında gerekleştiririz.
        }
    }
}
