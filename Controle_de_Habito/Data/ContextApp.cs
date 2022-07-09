using Controle_de_Habito.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Controle_de_Habito.Data
{
    public class ContextApp : DbContext
    {
        public ContextApp()
        {
                
        }

        public virtual DbSet<Habito> Habito { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties().Where(p => p.Name == "Id").Configure(p => p.IsKey());
        }
    }
}
