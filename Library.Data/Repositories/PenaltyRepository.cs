using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class PenaltiesRepository : RepositoryBase<Penalty>, IPenaltiesRepository
    {
        public PenaltiesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Penalty GetPenaltyByMemberID(int MemberID)
        {
            var Penalty = this.DbContext.Penalties.Where(c => c.MemberID == MemberID).FirstOrDefault();

            return Penalty;
        }
        public Penalty GetPenaltyByLoanID(int LoanID)
        {
            var Penalty = this.DbContext.Penalties.Where(c => c.LoanID == LoanID).FirstOrDefault();

            return Penalty;
        }


        public override void Update(Penalty entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IPenaltiesRepository : IRepository<Penalty>
    {
        Penalty GetPenaltyByMemberID(int MemberID);
        Penalty GetPenaltyByLoanID(int LoanID);

    }
}
