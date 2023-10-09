using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Linq;

namespace Library.Data.Repositories
{
    public class LoansRepository : RepositoryBase<Loan>, ILoansRepository
    {
        public LoansRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Loan GetLoanByBookID(int LoanBookID)
        {
            var LoanBook = this.DbContext.Loans.Where(c => c.BookID == LoanBookID).FirstOrDefault();

            return LoanBook;
        }
        public Loan GetLoanByMemberID(int LoanMemberID)
        {
            var LoanBook = this.DbContext.Loans.Where(c => c.MemberID == LoanMemberID).FirstOrDefault();

            return LoanBook;
        }

        public override void Update(Loan entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface ILoansRepository : IRepository<Loan>
    {
        Loan GetLoanByBookID(int LoanBookID);
        Loan GetLoanByMemberID(int LoanMemberID);
    }
}
