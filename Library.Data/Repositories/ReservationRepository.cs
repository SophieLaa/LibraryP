using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class ReservationsRepository : RepositoryBase<Reservation>, IReservationsRepository
    {
        public ReservationsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Reservation GetReservationsByBookID(int BookID)
        {
            var Reservation = this.DbContext.Reservations.Where(c => c.BookID == BookID).FirstOrDefault();

            return Reservation;
        }
        public Reservation GetReservationsByMemberID(int MemberID)
        {
            var Reservation = this.DbContext.Reservations.Where(c => c.MemberID == MemberID).FirstOrDefault();

            return Reservation;
        }
        public Reservation GetReservationsByResvationDate(DateTime ReservationDate)
        {
            var Reservation = this.DbContext.Reservations.Where(c => c.ReservationDate == ReservationDate).FirstOrDefault();

            return Reservation;
        }


        public override void Update(Reservation entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
    }

    public interface IReservationsRepository : IRepository<Reservation>
    {
        Reservation GetReservationsByBookID(int BookID);
        Reservation GetReservationsByMemberID(int MemberID);
        Reservation GetReservationsByResvationDate(DateTime ReservationDate);

    }
}
