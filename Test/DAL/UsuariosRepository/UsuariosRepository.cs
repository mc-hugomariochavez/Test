using Test.Models;

namespace Test.DAL.UsuariosRepository
{
	public class UsuariosRepository : IUsuariosRepository
	{
		public Task<Usuario> CreateUsuarioAsync(Usuario usuario)
		{
			throw new NotImplementedException();
		}

		public Task<Usuario> DeleteUsuarioAsync(int usuarioId)
		{
			throw new NotImplementedException();
		}

		public Task<List<Usuario>> GetUsuariosAsync()
		{
			throw new NotImplementedException();
		}

		public Task<Usuario> UpdateUsuarioAsync(int usuarioId, Usuario usuario)
		{
			throw new NotImplementedException();
		}
	}
}
