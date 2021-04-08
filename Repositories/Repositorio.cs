using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories {

    public class Context : DbContext {

        public DbSet<ClienteModels> Clientes { get; set; }
        public DbSet<CarroModels> Carros { get; set; }
        public DbSet<LocacaoModels> Locacaes { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder options) {
            options.UseMySql ("server=localhost;User Id=root;Database=dbluiz");
        }

    }

}