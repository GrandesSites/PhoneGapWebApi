using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_SeriesMap : EntityTypeConfiguration<TB_Series>
    {
        public TB_SeriesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Serie);

            // Properties
            this.Property(t => t.DS_Serie)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TB_Series");
            this.Property(t => t.ID_Serie).HasColumnName("ID_Serie");
            this.Property(t => t.ID_Set).HasColumnName("ID_Set");
            this.Property(t => t.DS_Serie).HasColumnName("DS_Serie");
            this.Property(t => t.ST_ATIVO).HasColumnName("ST_ATIVO");

            // Relationships
            this.HasOptional(t => t.TB_Sets)
                .WithMany(t => t.TB_Series)
                .HasForeignKey(d => d.ID_Set);

        }
    }
}
