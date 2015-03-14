using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_RelacionamentoMap : EntityTypeConfiguration<TB_Relacionamento>
    {
        public TB_RelacionamentoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_REL);

            // Properties
            // Table & Column Mappings
            this.ToTable("TB_Relacionamento");
            this.Property(t => t.ID_REL).HasColumnName("ID_REL");
            this.Property(t => t.ID_REQUISITANTE).HasColumnName("ID_REQUISITANTE");
            this.Property(t => t.ID_REQUISITADO).HasColumnName("ID_REQUISITADO");
            this.Property(t => t.BIT_APROVADO).HasColumnName("BIT_APROVADO");
            this.Property(t => t.BIT_REPROVADO).HasColumnName("BIT_REPROVADO");
        }
    }
}
