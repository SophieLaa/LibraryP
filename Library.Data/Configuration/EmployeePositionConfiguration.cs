using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class EmployeePositionConfiguration : EntityTypeConfiguration<EmployeePosition>
    {
        public EmployeePositionConfiguration()
        {
            ToTable("EmployeePositions");
            HasKey(ep => ep.ID);

            HasRequired(ep => ep.Employee)
                .WithMany(e => e.EmployeePositions)
                .HasForeignKey(ep => ep.EmployeeID)
                .WillCascadeOnDelete(false);

            HasRequired(ep => ep.Position)
                .WithMany(p => p.EmployeePositions)
                .HasForeignKey(ep => ep.PositionID)
                .WillCascadeOnDelete(false);

        }
    }
}
