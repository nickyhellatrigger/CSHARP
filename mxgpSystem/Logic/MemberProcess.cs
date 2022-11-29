using mxgpSystem.Models;
using System.Xml.Linq;

namespace mxgpSystem.Logic
{
    public class MemberProcess
    {
        private RacesDB raceDb;
        public MemberProcess(RacesDB dataBase)
        {
            raceDb = dataBase;
        }
        public Member SignIn(string name, string password)
        {
            Member member = raceDb.Members.FirstOrDefault(u => u.Name == name);
            if (member == null)
                throw new ArgumentNullException("The member with given name was not found");

            if (member.Password != password)
                throw new ArgumentException("Password incorrect!");

            return member;
        }

        public Member Register(string name, string country, string password)
        {
            Member member = raceDb.Members.FirstOrDefault(u => u.Name == name);
            if (member != null)
                throw new ArgumentNullException("The user with given name already exists");

            if (password.Length < 8 || name.Length > 25 || name.Length < 4)
                throw new ArgumentException("Password is too weak or name invalid");

            member = new Member();
            member.Name = name;
            member.Password = password;
            member.Country = country;

            return member;
        }

        public Member Update(int memberId, Member member)
        {
            if (member == null) throw new ArgumentNullException(nameof(member), "Member is null");

            Member updateMember = raceDb.Members.FirstOrDefault(u => u.Id == memberId);

            if (updateMember == null)
                throw new ArgumentException("The member was not found");

            raceDb.Members.Remove(updateMember);
            raceDb.Members.Add(member);

            return member;
        }


        public bool Delete(Member member)
        {
            if (member == null) throw new ArgumentNullException(nameof(member), "Member is null");

            Member deleteMember = raceDb.Members.FirstOrDefault(u => u.Id == member.Id);

            if (deleteMember == null)
                return false;

            raceDb.Members.Remove(member);
            return true;
        }
    }
}
