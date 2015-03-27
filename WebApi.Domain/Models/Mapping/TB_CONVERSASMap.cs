using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_CONVERSASMap : EntityTypeConfiguration<TB_CONVERSAS>
    {
        public TB_CONVERSASMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_CONVERSA);

            // Properties
            this.Property(t => t.DS_RECADO)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TB_CONVERSAS");
            this.Property(t => t.ID_CONVERSA).HasColumnName("ID_CONVERSA");
            this.Property(t => t.ID_FROM).HasColumnName("ID_FROM");
            this.Property(t => t.ID_TO).HasColumnName("ID_TO");
            this.Property(t => t.DS_RECADO).HasColumnName("DS_RECADO");
            this.Property(t => t.DT_DATA).HasColumnName("DT_DATA");
            this.Property(t => t.ST_LIDO).HasColumnName("ST_LIDO");
        }
    }
}
