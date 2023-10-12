using Microsoft.EntityFrameworkCore;
using Test.Entities;
using Test.Models;

namespace Test.DAL.DepartamentoRepository
{
	public class DepartamentoRepository : IDepartamentoRepository
	{
		private readonly UsuarioContext _usuarioContext;

        public DepartamentoRepository(UsuarioContext usuarioContext)
        {
			_usuarioContext = usuarioContext;
		}

        public async Task<Departmento> CreateDepartamentoAsync(Departmento departamentoRequest)
		{
			var departamento = new Departmento
			{
				Nombre = departamentoRequest.Nombre,
				Activo = departamentoRequest.Activo,
				Codigo = departamentoRequest.Codigo,
				Id = departamentoRequest.Id,
				IdUsuarioCreacion = departamentoRequest.IdUsuarioCreacion,
			};
			await _usuarioContext.AddAsync(departamento);

			await _usuarioContext.SaveChangesAsync();
			
			return departamento;
		}

		public async Task<Departmento> DeleteDepartamentoAsync(int departamentoId)
		{
			var departamento = await _usuarioContext.Departmentos.Where(x => x.Id == departamentoId).FirstOrDefaultAsync();
			 _usuarioContext.Remove(departamento);

			await _usuarioContext.SaveChangesAsync();

			return departamento;
		}

		public async Task<List<Departmento>> GetDepartamentoAsync()
		{
			List<Departmento> departamentos = await _usuarioContext.Departmentos.Select(x => x).ToListAsync();
			if(departamentos.Count == 0)
			{
				return null;
			}

			return departamentos;
		}

		public async Task<Departmento> UpdateDepartamentoAsync(int departamentoId, Departmento departmentoRequest)
		{
			var departamento = _usuarioContext.Departmentos.Where(x => x.Id == departamentoId).FirstOrDefault();
			departamento.Nombre = departmentoRequest.Nombre;
			departamento.Activo = departmentoRequest.Activo;
			departamento.IdUsuarioCreacion = departmentoRequest.IdUsuarioCreacion;
			departamento.Codigo = departmentoRequest.Codigo;

			await _usuarioContext.SaveChangesAsync();

			return departamento;
		}
	}
}
