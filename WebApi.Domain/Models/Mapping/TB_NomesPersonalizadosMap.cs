using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_NomesPersonalizadosMap : EntityTypeConfiguration<TB_NomesPersonalizados>
    {
        public TB_NomesPersonalizadosMap()
        {
            // Primary Key
            this.HasKey(t => t.Id_NomePers);

            // Properties
            this.Property(t => t.NM_Nome)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TB_NomesPersonalizados");
            this.Property(t => t.Id_NomePers).HasColumnName("Id_NomePers");
            this.Property(t => t.NM_Nome).HasColumnName("NM_Nome");
        }
    }
}
