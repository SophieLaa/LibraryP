using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            ToTable("UserRoles");
            HasKey(ur => ur.ID);

            Property(ur => ur.RoleTitles).IsRequired().HasMaxLength(50);

            //HasMany(ur => ur.Users)
            //    .WithRequired(u => u.UserRole)
            //    .HasForeignKey(u => u.UserRoleID)
            //    .WillCascadeOnDelete(false);

        }
    }
}
