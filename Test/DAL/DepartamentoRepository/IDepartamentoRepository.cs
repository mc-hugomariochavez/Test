using Test.Models;

namespace Test.DAL.DepartamentoRepository
{
	public interface IDepartamentoRepository
	{
		Task<List<Departmento>> GetDepartamentoAsync();
		Task<Departmento> CreateDepartamentoAsync(Departmento departmento);
		Task<Departmento> UpdateDepartamentoAsync(int departamentoId, Departmento departmento);
		Task<Departmento> DeleteDepartamentoAsync(int departamentoId);
	}
}
