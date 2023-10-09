using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class PublisherConfiguration : EntityTypeConfiguration<Publisher>
    {
        public PublisherConfiguration()
        {
            ToTable("Publishers");
            HasKey(p => p.ID);

            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Address).IsRequired().HasColumnType("text");
            Property(p => p.PhoneNumber).IsRequired().HasMaxLength(50);
            Property(p => p.Email).HasMaxLength(50);
            Property(p => p.CreateDate).IsRequired();
            Property(p => p.ChangeDate).IsRequired();
            Property(p => p.DeleteDate).IsRequired();

            HasMany(p => p.BookPublishers)
                .WithRequired(bp => bp.Publisher)
                .HasForeignKey(bp => bp.PublisherID)
                .WillCascadeOnDelete(false);

        }
    }
}
