using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_SeriesMap : EntityTypeConfiguration<TB_Series>
    {
        public TB_SeriesMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Serio);

            // Properties
            this.Property(t => t.NR_Peso)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_Series");
            this.Property(t => t.ID_Serio).HasColumnName("ID_Serio");
            this.Property(t => t.ID_EXERCICIO).HasColumnName("ID_EXERCICIO");
            this.Property(t => t.DT_Data).HasColumnName("DT_Data");
            this.Property(t => t.NR_Repeticoes).HasColumnName("NR_Repeticoes");
            this.Property(t => t.NR_Peso).HasColumnName("NR_Peso");
        }
    }
}
