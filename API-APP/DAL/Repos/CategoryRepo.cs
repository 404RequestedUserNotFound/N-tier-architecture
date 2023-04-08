using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        static NPContext db;
        static CategoryRepo()
        {
            db = new NPContext();
        }


        public static List<Category> Get()
        {
            return db.Categories.ToList();
        }


        public static Category Get(int id)
        {
            return db.Categories.Find(id);
        }


        public static bool Create(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges() > 0;
        }


        public static bool Update(Category category)
        {
            var execat = Get(category.Id);
            db.Entry(execat).CurrentValues.SetValues(category);
            return db.SaveChanges() > 0;
        }


        public static bool Delete(int id)
        {
            var execat = Get(id);
            db.Categories.Remove(execat);
            return db.SaveChanges() > 0;
        }
    }
}
