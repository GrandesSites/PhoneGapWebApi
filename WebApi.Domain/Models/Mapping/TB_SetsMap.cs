using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_SetsMap : EntityTypeConfiguration<TB_Sets>
    {
        public TB_SetsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Set);

            // Properties
            this.Property(t => t.DS_Set)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TB_Sets");
            this.Property(t => t.ID_Set).HasColumnName("ID_Set");
            this.Property(t => t.DS_Set).HasColumnName("DS_Set");
            this.Property(t => t.ST_ATIVO).HasColumnName("ST_ATIVO");
        }
    }
}
