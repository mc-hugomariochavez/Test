using Test.DAL.CargoRepository;
using Test.DAL.DepartamentoRepository;
using Test.DAL.UsuariosRepository;
using Test.Entities;

namespace Test
{
	public static class ServiceExtensions
	{
		public static void ConfigureDAL(this IServiceCollection services)
		{
			services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
			services.AddScoped<ICargoRepository , CargoRepository>();
			services.AddScoped<IUsuariosRepository , UsuariosRepository>();
		}

		public static void ConfigureDBContexts(this IServiceCollection services)
		{
			services.AddDbContext<UsuarioContext>();
		}

		public static void ConfigureCORS(this IServiceCollection services)
		{
			var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
			services.AddCors(options =>
			{
				options.AddPolicy(name: MyAllowSpecificOrigins,
					policy =>
					{
						policy.AllowAnyOrigin();
					});
			});
		}
	}
}
