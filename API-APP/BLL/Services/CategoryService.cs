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
    public class CategoryService
    {
        public static CategoryDTO Get(int id)
        {
            var data = CategoryRepo.Get(id);
            return Convert(data);
        }

        public static List<CategoryDTO> Get()
        {
            var data = CategoryRepo.Get();
            return Convert(data);
        }

        public static CategoryDTO Convert(Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }


        public static Category Convert(CategoryDTO category)
        {
            return new Category()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
        static List<CategoryDTO> Convert(List<Category> category)
        {
            var data = new List<CategoryDTO>();
            foreach (var item in category)
            {
                data.Add(Convert(item));
            }
            return data;
        }

        public static bool Create(CategoryDTO category)
        {
            var data = Convert(category);
            return CategoryRepo.Create(data);
        }

        public static bool Update(CategoryDTO category)
        {
            var data = Convert(category);
            return CategoryRepo.Update(data);
        }

        public static bool Delete(int id)
        {
            return CategoryRepo.Delete(id);
        }
    }
}
