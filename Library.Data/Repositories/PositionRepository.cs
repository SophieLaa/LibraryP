using Library.Data.Infrastructure;
using Library.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public class PositionsRepository : RepositoryBase<Position>, IPositionsRepository
    {
        public PositionsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Position GetPositionByTitle(string Title)
        {
            var Position = this.DbContext.Positions.Where(c => c.PositionTitle == Title).FirstOrDefault();

            return Position;
        }


        public override void Update(Position entity)
        {
            entity.ChangeDate = DateTime.Now;
            base.Update(entity);
        }
       

        public List<Position> GetAllPositions()
        {
            return DbContext.Positions.ToList();
        }

        public void AddPosition(Position position)
        {
            DbContext.Positions.Add(position);
            DbContext.SaveChanges();
        }

        public Position GetPositionById(int id)
        {
            return DbContext.Positions.Find(id);
        }

        public void UpdatePosition(Position position)
        {
            position.ChangeDate = DateTime.Now;
            base.Update(position);
        }

        public void DeletePosition(int id)
        {
            var position = DbContext.Positions.Find(id);
            if (position != null)
            {
                DbContext.Positions.Remove(position);
                DbContext.SaveChanges();
            }
        }
    }

    public interface IPositionsRepository : IRepository<Position>
    {
        Position GetPositionByTitle(string Title);
        List<Position> GetAllPositions();
        void AddPosition(Position position);
        Position GetPositionById(int id);
        void UpdatePosition(Position position);
        void DeletePosition(int id);
    }
}

