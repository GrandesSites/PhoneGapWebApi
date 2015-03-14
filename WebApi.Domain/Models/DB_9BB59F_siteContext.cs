using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WebApi.Domain.Models.Mapping;

namespace WebApi.Domain.Models
{
    public partial class DB_9BB59F_siteContext : DbContext
    {
        static DB_9BB59F_siteContext()
        {
            Database.SetInitializer<DB_9BB59F_siteContext>(null);
        }

        public DB_9BB59F_siteContext()
            : base("Name=DB_9BB59F_siteContext")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TB_Exercicio> TB_Exercicio { get; set; }
        public DbSet<TB_Login> TB_Login { get; set; }
        public DbSet<TB_Relacionamento> TB_Relacionamento { get; set; }
        public DbSet<TB_Series> TB_Series { get; set; }
        public DbSet<TB_Sets> TB_Sets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TB_ExercicioMap());
            modelBuilder.Configurations.Add(new TB_LoginMap());
            modelBuilder.Configurations.Add(new TB_RelacionamentoMap());
            modelBuilder.Configurations.Add(new TB_SeriesMap());
            modelBuilder.Configurations.Add(new TB_SetsMap());
        }
    }
}
