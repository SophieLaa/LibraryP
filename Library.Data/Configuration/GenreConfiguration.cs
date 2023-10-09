using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            ToTable("Genres");
            HasKey(g => g.ID);

            Property(g => g.Name).HasColumnType("text").IsRequired();

        }
    }
}
