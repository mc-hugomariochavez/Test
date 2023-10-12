using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Entities
{
	public class UsuarioContext: DbContext
	{

		private readonly IConfiguration _configuration;

        public UsuarioContext(IConfiguration configuration)
        {
			_configuration = configuration;
        }

        public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Cargo> Cargos { get; set; }
		public DbSet<Departmento> Departmentos { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Prueba"));
		}
	}
}
