using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class PositionConfiguration : EntityTypeConfiguration<Position>
    {
        public PositionConfiguration()
        {
            ToTable("Positions");
            HasKey(p => p.ID);

            Property(p => p.PositionTitle).IsRequired().HasMaxLength(100);
            Property(p => p.CreateDate).IsRequired();
            Property(p => p.ChangeDate).IsRequired();
            Property(p => p.DeleteDate).IsRequired();

            HasMany(p => p.EmployeePositions)
                .WithRequired(ep => ep.Position)
                .HasForeignKey(ep => ep.PositionID)
                .WillCascadeOnDelete(false);

        }
    }
}
