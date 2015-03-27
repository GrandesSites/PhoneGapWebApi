using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_PersonalizacaoMap : EntityTypeConfiguration<TB_Personalizacao>
    {
        public TB_PersonalizacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_SeriePersonalizada);

            // Properties
            this.Property(t => t.NR_Repeticoes)
                .HasMaxLength(50);

            this.Property(t => t.DS_Peso)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_Personalizacao");
            this.Property(t => t.ID_SeriePersonalizada).HasColumnName("ID_SeriePersonalizada");
            this.Property(t => t.Id_NomePers).HasColumnName("Id_NomePers");
            this.Property(t => t.ID_Professor).HasColumnName("ID_Professor");
            this.Property(t => t.ID_Exercicio).HasColumnName("ID_Exercicio");
            this.Property(t => t.NR_Repeticoes).HasColumnName("NR_Repeticoes");
            this.Property(t => t.DS_Peso).HasColumnName("DS_Peso");
        }
    }
}
