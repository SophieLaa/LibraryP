using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            ToTable("Roles");
            HasKey(r => r.ID);

            Property(r => r.RoleName).IsRequired().HasMaxLength(50);
            Property(r => r.CreateDate).IsRequired();
            Property(r => r.ChangeDate).IsRequired();
            Property(r => r.DeleteDate).IsRequired();

            HasMany(r => r.RoleMenus)
                .WithRequired(rm => rm.Role)
                .HasForeignKey(rm => rm.RoleID)
                .WillCascadeOnDelete(false);
        }
    }
}
