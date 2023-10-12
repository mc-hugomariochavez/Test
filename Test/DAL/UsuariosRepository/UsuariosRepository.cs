using Microsoft.EntityFrameworkCore;
using Test.Entities;
using Test.Models;

namespace Test.DAL.UsuariosRepository
{
	public class UsuariosRepository : IUsuariosRepository
	{
		private readonly UsuarioContext _usuarioContext;


		public UsuariosRepository(UsuarioContext usuarioContext)
		{
			_usuarioContext = usuarioContext;
		}

		public async Task<Usuario> CreateUsuarioAsync(UsuarioRequest usuarioRequest)
		{
			var usuario = new Usuario
			{
				PrimerNombre = usuarioRequest.PrimerNombre,
				SegundoNombre = usuarioRequest.SegundoNombre,
				PrimerApellido = usuarioRequest.PrimerApellido,
				SegundoApellido = usuarioRequest.SegundoApellido,
				IdDepartamento = usuarioRequest.IdDepartamento,
				IdCargo = usuarioRequest.IdCargo,
			};
			await _usuarioContext.AddAsync(usuario);

			await _usuarioContext.SaveChangesAsync();

			return usuario;
		}

		public async Task<List<Usuario>> GetUsuariosAsync()
		{
			List<Usuario> usuarios = await _usuarioContext.Usuarios
				.Select(x => x)
				.Include(x => x.Cargo)
				.Include(x => x.Departamento)
				.ToListAsync();

			if (usuarios.Count == 0)
			{
				return null;
			}

			return usuarios;
		}

		public async Task<Usuario> UpdateUsuarioAsync(int usuarioId, UsuarioRequest usuarioRequest)
		{
			var usuario = _usuarioContext.Usuarios.Where(x => x.Id == usuarioId).FirstOrDefault();
			usuario.PrimerNombre = usuarioRequest.PrimerNombre;
			usuario.SegundoNombre = usuarioRequest.SegundoNombre;
			usuario.PrimerApellido = usuarioRequest.PrimerApellido;
			usuario.SegundoApellido = usuarioRequest.SegundoApellido;
			usuario.IdDepartamento = usuarioRequest.IdDepartamento;
			usuario.IdCargo = usuarioRequest.IdCargo;


			await _usuarioContext.SaveChangesAsync();

			return usuario;
		}

		public async Task<Usuario> DeleteUsuarioAsync(int usuarioId)
		{
			var usuario = await _usuarioContext.Usuarios.Where(x => x.Id == usuarioId).FirstOrDefaultAsync();
			_usuarioContext.Remove(usuario);

			await _usuarioContext.SaveChangesAsync();

			return usuario;
		}




	}
}
