﻿using Test.Models;

namespace Test.DAL.CargoRepository
{
	public interface ICargoRepository
	{
		Task<List<Cargo>> GetCargoAsync();
		Task<Cargo> CreateCargoAsync(Cargo cargo);
		Task<Cargo> UpdateCargoAsync(int cargoId, Cargo cargo);
		Task<Cargo> DeleteCargoAsync(int cargoId);
	}
}
