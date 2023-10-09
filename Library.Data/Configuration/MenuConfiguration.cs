using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class MenuConfiguration : EntityTypeConfiguration<Menu>
    {
        public MenuConfiguration()
        {
            ToTable("Menus");
            HasKey(m => m.ID);

            Property(m => m.MenuName).IsRequired().HasMaxLength(50);
            Property(m => m.Url).HasMaxLength(100);
            Property(m => m.CreateDate).IsRequired();
            Property(m => m.ChangeDate).IsRequired();
            Property(m => m.DeleteDate).IsRequired();

            
            HasOptional(m => m.ParentMenu)
                .WithMany(m => m.ChildMenus)
                .HasForeignKey(m => m.ParentID);

        }
    }
}
