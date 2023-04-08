using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NPContext : DbContext
    {
        public NPContext() : base("name=NPContext")
        {
        }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
