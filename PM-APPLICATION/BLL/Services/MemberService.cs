using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MemberService
    {
        public static List<MemberDTO> Get()
        {
            var data = DataAccessFactory.MemberData().Get();
            return Convert(data);
        }

        public static MemberDTO Get(int id)
        {
            return Convert(DataAccessFactory.MemberData().Get(id));
        }


        public static bool Create(MemberDTO member)
        {
            var data = Convert(member);
            return DataAccessFactory.MemberData().Insert(data);
        }


        public static bool Update(MemberDTO member)
        {
            var data = Convert(member);
            return DataAccessFactory.MemberData().Update(data);
        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.MemberData().Delete(id);
        }


        static List<MemberDTO> Convert(List<Member> Member)
        {
            var data = new List<MemberDTO>();
            foreach (var member in Member)
            {
                data.Add(Convert(member));
            }
            return data;
        }


        static MemberDTO Convert(Member Member)
        {
            return new MemberDTO()
            {
                Id = Member.Id,
                Role = Member.Role,
                Name = Member.Name,
                PId = Member.PId

            };
        }


        static Member Convert(MemberDTO Member)
        {
            return new Member()
            {
                Id = Member.Id,
                Role = Member.Role,
                Name = Member.Name,
                PId = Member.PId            
            };
        }
    }
}
