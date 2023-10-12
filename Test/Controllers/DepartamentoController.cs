using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Test.DAL.DepartamentoRepository;
using Test.Models;

namespace Test.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class DepartamentoController : Controller
	{
		private readonly IDepartamentoRepository _departamentoRepository;

        public DepartamentoController(IDepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

		[HttpGet]
        public async Task<IActionResult> Index()
		{
			List<Departmento> departmentos = await _departamentoRepository.GetDepartamentoAsync();
			if (departmentos.IsNullOrEmpty())
			{
				return NotFound("Clientes no registrados");
			}
			return Ok();
		}

		[HttpPost("save")]
		public async Task<IActionResult> CreateDepartamento([FromBody] Departmento deparamentoRequest)
		{
			Departmento departmento = await _departamentoRepository.CreateDepartamentoAsync(deparamentoRequest);
			if (departmento  == null)
			{
				return NotFound("Clientes no registrados");
			}
			return Ok();
		}

		[HttpPut("update/{id}")]
		public async Task<IActionResult> UpdateDepartamento(int departamentoId, [FromBody] Departmento deparamentoRequest)
		{
			Departmento departmento = await _departamentoRepository.UpdateDepartamentoAsync(departamentoId, deparamentoRequest);
			if (departmento == null)
			{
				return NotFound("Clientes no registrados");
			}
			return Ok();
		}

		[HttpPut("delete/{id}")]
		public async Task<IActionResult> DeleteDepartamento(int departamentoId)
		{
			Departmento departmento = await _departamentoRepository.DeleteDepartamentoAsync(departamentoId);
			if (departmento == null)
			{
				return NotFound("Clientes no registrados");
			}
			return Ok();
		}
	}
}
