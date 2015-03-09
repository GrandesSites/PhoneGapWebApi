using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_ExercicioMap : EntityTypeConfiguration<TB_Exercicio>
    {
        public TB_ExercicioMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Exercicio);

            // Properties
            this.Property(t => t.DS_Peso)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_Exercicio");
            this.Property(t => t.ID_Exercicio).HasColumnName("ID_Exercicio");
            this.Property(t => t.ID_Serie).HasColumnName("ID_Serie");
            this.Property(t => t.DS_Peso).HasColumnName("DS_Peso");
            this.Property(t => t.NR_Series).HasColumnName("NR_Series");
            this.Property(t => t.NR_Repeticoes).HasColumnName("NR_Repeticoes");
            this.Property(t => t.DT_Data).HasColumnName("DT_Data");
            this.Property(t => t.ST_ATIVO).HasColumnName("ST_ATIVO");

            // Relationships
            this.HasOptional(t => t.TB_Series)
                .WithMany(t => t.TB_Exercicio)
                .HasForeignKey(d => d.ID_Serie);

        }
    }
}
