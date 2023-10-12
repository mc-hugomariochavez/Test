using Test.Entities;
using Test.Models;

namespace Test.DAL.CargoRepository
{
	public class CargoRepository : ICargoRepository
	{
		private readonly UsuarioContext _usuarioContext;

        public CargoRepository(UsuarioContext usuarioContext)
        {
			_usuarioContext = usuarioContext;
		}

        public async Task<Cargo> CreateCargoAsync(Cargo cargoRequest)
		{
			var cargo = new Cargo
			{
				Nombre = cargoRequest.Nombre,
				Activo = cargoRequest.Activo,
				Codigo = cargoRequest.Codigo,
				Id = cargoRequest.Id,
				IdUsuarioCreacion = cargoRequest.IdUsuarioCreacion,
			};
			await _usuarioContext.AddAsync(cargo);

			await _usuarioContext.SaveChangesAsync();

			return cargo;
		}

		public Task<Cargo> DeleteCargoAsync(int cargoId)
		{
			throw new NotImplementedException();
		}

		public Task<List<Cargo>> GetCargoAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Cargo> UpdateCargoAsync(int cargoId, Cargo cargo)
		{
			throw new NotImplementedException();
		}
	}
}
