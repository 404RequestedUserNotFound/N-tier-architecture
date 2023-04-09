using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PMContext : DbContext
    {
        public DbSet<Member> Member { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
