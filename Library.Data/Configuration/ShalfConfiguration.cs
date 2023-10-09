using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class ShalfConfiguration : EntityTypeConfiguration<Shalf>
    {
        public ShalfConfiguration()
        {
            ToTable("Shalves");
            HasKey(s => s.ID);

            Property(s => s.Floor).IsRequired();
            Property(s => s.Room).IsRequired().HasMaxLength(50);
            Property(s => s.Shelf).IsRequired();
            Property(s => s.Section).IsRequired().HasMaxLength(50);
            Property(s => s.Row).IsRequired().HasMaxLength(50);
            Property(s => s.CreateDate).IsRequired();
            Property(s => s.ChangeDate).IsRequired();
            Property(s => s.DeleteDate).IsRequired();

            HasMany(s => s.BookShalves)
                .WithRequired(bs => bs.Shalf)
                .HasForeignKey(bs => bs.ShelfID)
                .WillCascadeOnDelete(false);

        }
    }
}
