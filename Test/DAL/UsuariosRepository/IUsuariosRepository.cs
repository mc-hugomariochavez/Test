using Test.Models;

namespace Test.DAL.UsuariosRepository
{
	public interface IUsuariosRepository
	{
		Task<List<Usuario>> GetUsuariosAsync();
		Task<Usuario> CreateUsuarioAsync(UsuarioRequest usuario);
		Task<Usuario> UpdateUsuarioAsync(int usuarioId, UsuarioRequest usuario);
		Task<Usuario> DeleteUsuarioAsync(int usuarioId);
	}
}
