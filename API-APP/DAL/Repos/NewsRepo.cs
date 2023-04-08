using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        static NPContext db;
        static NewsRepo()
        {
            db = new NPContext();
        }

        public static List<News> Get()
        {
            return db.News.ToList();
        }


        public static News Get(int id)
        {
            return db.News.Find(id);
        }


        public static bool Create(News news)
        {
            db.News.Add(news);
            return db.SaveChanges() > 0;
        }


        public static bool Update(News news)
        {
            var exenew = Get(news.Id);
            db.Entry(exenew).CurrentValues.SetValues(news);
            return db.SaveChanges() > 0;
        }


        public static bool Delete(int id)
        {
            var exenew = Get(id);
            db.News.Remove(exenew);
            return db.SaveChanges() > 0;
        }


    }
}
