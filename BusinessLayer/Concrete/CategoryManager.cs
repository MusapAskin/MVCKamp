
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CaregoryName=="" || p.CaregoryName.Length<=3||p.CaregoryName.Length>51||p.CaregoryDescription=="")
            {
                //Hata Mesajı
            }
            else repo.Insert(p); 
        }
    }
}
