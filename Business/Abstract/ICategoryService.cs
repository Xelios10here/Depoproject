﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void CategoryAdd(Category category);
        Category GetByID(int id);
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);
    }
}
