using Microsoft.EntityFrameworkCore;
using Models;

namespace DbRespositorie
{
    //Derived class from DbContext
    public class Context : DbContext
    {
        // DbSet properties        
        /// <value> Get and Set properties of customers  </value>
        public DbSet<ClienteModels> Clientes { get; set; }
        /// <value> Get and Set properties of movies  </value>
        public DbSet<CarroModels> Carros { get; set; }
        /// <value> Get and Set properties of rentals  </value>
        public DbSet<LocacaoModels> Locacoes { get; set; }



        /// <summary>
        /// Initializing DbContextOptions
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("Server=localhost;User Id=root;Database=SENAC2021");
        }
    }
}