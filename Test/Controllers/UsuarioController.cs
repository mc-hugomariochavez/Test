using Microsoft.AspNetCore.Mvc;
using Test.DAL.UsuariosRepository;
using Test.Models;

namespace Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
	private readonly IUsuariosRepository _usuariosRepository;

    public UsuarioController(IUsuariosRepository usuariosRepository)
    {
        _usuariosRepository = usuariosRepository;
    }

    [HttpGet]
    public async Task<ActionResult> Index()
    {
        List<Usuario> usuarios = await _usuariosRepository.GetUsuariosAsync();
        if (usuarios == null)
        {
            return NotFound("No existen usuarios registrados");
        }

        return Ok(usuarios);
    }

	[HttpPost("save")]
	public async Task<IActionResult> CreateCargo([FromBody] UsuarioRequest usuarioRequest)
	{
		Usuario usuario = await _usuariosRepository.CreateUsuarioAsync(usuarioRequest);
		if (usuario == null)
		{
			return NotFound("Cargos no registrados");
		}
		return Ok(usuario);
	}

	[HttpPut("update/{usuarioId}")]
	public async Task<IActionResult> UpdateCargo(int usuarioId, [FromBody] UsuarioRequest usuarioRequest)
	{
		Usuario usuario = await _usuariosRepository.UpdateUsuarioAsync(usuarioId, usuarioRequest);
		if (usuario == null)
		{
			return NotFound("Cargos no registrados");
		}
		return Ok(usuario);
	}

	[HttpDelete("delete/{usuarioId}")]
	public async Task<IActionResult> DeleteCargo(int usuarioId)
	{
		Usuario usuario = await _usuariosRepository.DeleteUsuarioAsync(usuarioId);
		if (usuario == null)
		{
			return NotFound("Cargos no registrados");
		}
		return Ok(usuario);
	}
}

