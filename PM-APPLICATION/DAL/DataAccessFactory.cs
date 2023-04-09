using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Member, int, bool> MemberData()
        {
            return new MemberRepo();
        }

        public static IRepo<Project, int, bool> ProjectData()
        {
            return new ProjectRepo();
        }
    }
}
