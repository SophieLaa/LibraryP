using Library.Web;
using System.Data.Entity.ModelConfiguration;

namespace Library.Data.Configuration
{
    public class LanguageConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            ToTable("Languages");
            HasKey(l => l.ID);

            Property(l => l.Language1).HasColumnType("text").IsRequired();

        }
    }
}
