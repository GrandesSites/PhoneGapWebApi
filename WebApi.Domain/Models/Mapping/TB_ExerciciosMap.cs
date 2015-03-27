using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_ExerciciosMap : EntityTypeConfiguration<TB_Exercicios>
    {
        public TB_ExerciciosMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_EXERCICIO);

            // Properties
            this.Property(t => t.DS_EXERCICIO)
                .HasMaxLength(255);

            this.Property(t => t.ID_YOUTUBE)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TB_Exercicios");
            this.Property(t => t.ID_EXERCICIO).HasColumnName("ID_EXERCICIO");
            this.Property(t => t.DS_EXERCICIO).HasColumnName("DS_EXERCICIO");
            this.Property(t => t.ID_YOUTUBE).HasColumnName("ID_YOUTUBE");
            this.Property(t => t.ST_STATUS).HasColumnName("ST_STATUS");
        }
    }
}
