using Microsoft.AspNetCore.Mvc;
using Test.DAL.UsuariosRepository;
using Test.Models;

namespace Test.Controllers;

[ApiController]
[Route("[controller]")]
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
}

