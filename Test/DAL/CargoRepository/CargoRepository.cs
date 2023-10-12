using Microsoft.EntityFrameworkCore;
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

        public async Task<Cargo> CreateCargoAsync(CargoRequest cargoRequest)
		{
			var cargo = new Cargo
			{
				Nombre = cargoRequest.Nombre,
				Activo = cargoRequest.Activo,
				Codigo = cargoRequest.Codigo,
				IdUsuarioCreacion = cargoRequest.IdUsuarioCreacion,
			};

			await _usuarioContext.AddAsync(cargo);

			await _usuarioContext.SaveChangesAsync();

			return cargo;
		}

		public async Task<List<Cargo>> GetCargoAsync()
		{
			List<Cargo> cargos = await _usuarioContext.Cargos.Select(x => x).ToListAsync();
			if (cargos.Count == 0)
			{
				return null;
			}

			return cargos;
		}
		

		public async Task<Cargo> UpdateCargoAsync(int cargoId, CargoRequest cargoRequest)
		{
			var cargo = _usuarioContext.Cargos.Where(x => x.Id == cargoId).FirstOrDefault();
			cargo.Nombre = cargoRequest.Nombre;
			cargo.Activo = cargoRequest.Activo;
			cargo.IdUsuarioCreacion = cargoRequest.IdUsuarioCreacion;
			cargo.Codigo = cargoRequest.Codigo;

			await _usuarioContext.SaveChangesAsync();

			return cargo;
		}

		public async Task<Cargo> DeleteCargoAsync(int cargoId)
		{
			var cargo = await _usuarioContext.Cargos.Where(x => x.Id == cargoId).FirstOrDefaultAsync();
			_usuarioContext.Remove(cargo);

			await _usuarioContext.SaveChangesAsync();

			return cargo;
		}
	}
}
