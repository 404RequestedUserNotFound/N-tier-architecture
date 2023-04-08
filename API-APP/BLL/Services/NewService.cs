using BLL.DTOs;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewService
    {
        public static NewsDTO Get(int id)
        {
            var data = NewsRepo.Get(id);
            return Convert(data);
        }



        public static List<NewsDTO> Get()
        {
            var data = NewsRepo.Get();
            return Convert(data);


        }
        public static NewsDTO Convert(News news)
        {
            return new NewsDTO()
            {
                Id = news.Id,
                Title = news.Title,
                Description = news.Description,
                Date = news.Date,
                Category = news.Category
            };

        }

        public static News Convert(NewsDTO news)
        {
            return new News()
            {
                Id = news.Id,
                Title = news.Title,
                Description = news.Description,
                Date = news.Date,
                Category = news.Category
            };
        }

        static List<NewsDTO> Convert(List<News> news)
        {
            var data = new List<NewsDTO>();
            foreach (var item in news)
            {
                data.Add(Convert(item));
            }
            return data;
        }


        public static bool Create(NewsDTO employee)
        {
            var data = Convert(employee);
            return NewsRepo.Create(data);
        }

        public static bool Update(NewsDTO employee)
        {
            var data = Convert(employee);
            return NewsRepo.Update(data);
        }

        public static bool Delete(int id)
        {
            return NewsRepo.Delete(id);
        }
    }
}
