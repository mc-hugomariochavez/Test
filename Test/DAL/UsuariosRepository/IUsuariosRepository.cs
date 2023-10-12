using Test.Models;

namespace Test.DAL.UsuariosRepository
{
	public interface IUsuariosRepository
	{
		Task<List<Usuario>> GetUsuariosAsync();
		Task<Usuario> CreateUsuarioAsync(Usuario usuario);
		Task<Usuario> UpdateUsuarioAsync(int usuarioId, Usuario usuario);
		Task<Usuario> DeleteUsuarioAsync(int usuarioId);
	}
}
