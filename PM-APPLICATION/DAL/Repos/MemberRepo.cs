using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MemberRepo : Repo, IRepo<Member, int, bool>
    {
        public List<Member> Get()
        {
            return db.Member.ToList();
        }

        public Member Get(int id)
        {
            return db.Member.Find(id);
        }

        public bool Insert(Member obj)
        {
            db.Member.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Member obj)
        {
            var exst = db.Member.Find(obj.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var data = db.Member.Find(id);
            if (data != null)
            {
                db.Member.Remove(data);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
