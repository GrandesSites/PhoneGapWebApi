using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WebApi.Domain.Models.Mapping
{
    public class TB_LoginMap : EntityTypeConfiguration<TB_Login>
    {
        public TB_LoginMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_login);

            // Properties
            this.Property(t => t.DS_Login)
                .HasMaxLength(255);

            this.Property(t => t.DS_Senha)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TB_Login");
            this.Property(t => t.ID_login).HasColumnName("ID_login");
            this.Property(t => t.DS_Login).HasColumnName("DS_Login");
            this.Property(t => t.DS_Senha).HasColumnName("DS_Senha");
            this.Property(t => t.Bit_Aluno).HasColumnName("Bit_Aluno");
            this.Property(t => t.Bit_Professor).HasColumnName("Bit_Professor");
        }
    }
}
