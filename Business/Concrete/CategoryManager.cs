using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public Category CategoryGetByID(int CategoryID)
        {
            return _categoryDal.Get(p => p.CategoryID == CategoryID);


        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            using (var dbContext = new DbsistembirContext())
            {
                // Gönderdiğimiz ürün ID'sine sahip olan ürünü veritabanından bul
                var categoryToUpdate = dbContext.Categories.SingleOrDefault(p => p.CategoryID == category.CategoryID);

                if (categoryToUpdate != null)
                {
                    // Ürün bilgilerini güncelle
                    categoryToUpdate.CategoryAd = category.CategoryAd;
                    categoryToUpdate.CategoryID = category.CategoryID;


                    // Değişiklikleri veritabanına kaydet
                    dbContext.SaveChanges();
                }
            }
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Add(category);
        }
    }
}
