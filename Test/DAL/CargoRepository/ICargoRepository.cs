using Test.Models;

namespace Test.DAL.CargoRepository
{
	public interface ICargoRepository
	{
		Task<List<Cargo>> GetCargoAsync();
		Task<Cargo> CreateCargoAsync(CargoRequest cargo);
		Task<Cargo> UpdateCargoAsync(int cargoId, CargoRequest cargoRequest);
		Task<Cargo> DeleteCargoAsync(int cargoId);
	}
}
