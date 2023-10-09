using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class RoleMenuConfiguration : EntityTypeConfiguration<RoleMenu>
    {
        public RoleMenuConfiguration()
        {
            ToTable("RoleMenus");
            HasKey(rm => rm.ID);

            Property(rm => rm.CreateDate).IsRequired();
            Property(rm => rm.ChangeDate).IsRequired();
            Property(rm => rm.DeleteDate).IsRequired();

            HasRequired(rm => rm.Role)
                .WithMany(r => r.RoleMenus)
                .HasForeignKey(rm => rm.RoleID)
                .WillCascadeOnDelete(false);

            HasRequired(rm => rm.Menu)
                .WithMany(m => m.RoleMenus)
                .HasForeignKey(rm => rm.MenuID)
                .WillCascadeOnDelete(false);

        }
    }
}
