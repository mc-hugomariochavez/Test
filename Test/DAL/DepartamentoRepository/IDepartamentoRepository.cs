using Test.Models;

namespace Test.DAL.DepartamentoRepository
{
	public interface IDepartamentoRepository
	{
		Task<List<Departmento>> GetDepartamentoAsync();
		Task<Departmento> CreateDepartamentoAsync(DepartmentoRequest departmento);
		Task<Departmento> UpdateDepartamentoAsync(int departamentoId, DepartmentoRequest departmento);
		Task<Departmento> DeleteDepartamentoAsync(int departamentoId);
	}
}
