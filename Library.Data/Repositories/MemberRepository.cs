using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Linq;

namespace Library.Data.Repositories
{
    public class MembersRepository : RepositoryBase<Member>, IMembersRepository
    {
        public MembersRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Member GetMembersByFirstName(string FirstName)
        {
            var Member = this.DbContext.Members.Where(c => c.FirstName == FirstName).FirstOrDefault();

            return Member;
        }
        public Member GetMembersByLastName(string LastName)
        {
            var Member = this.DbContext.Members.Where(c => c.FirstName == LastName).FirstOrDefault();

            return Member;
        }
        public Member GetMembersByEmail(string Email)
        {
            var Member = this.DbContext.Members.Where(c => c.Email == Email).FirstOrDefault();

            return Member;
        }
        public Member GetMembersByPhoneNumber(string PhoneNumber)
        {
            var Member = this.DbContext.Members.Where(c => c.PhoneNumber == PhoneNumber).FirstOrDefault();

            return Member;
        }


        public override void Update(Member entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IMembersRepository : IRepository<Member>
    {
        Member GetMembersByFirstName(string FirstName);
        Member GetMembersByLastName(string LastName);
        Member GetMembersByEmail(string Email);
        Member GetMembersByPhoneNumber(string PhoneNumber);



    }
}
