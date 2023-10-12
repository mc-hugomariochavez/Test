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
				return NotFound("Departamentos no registrados");
			}
			return Ok(departmentos);
		}

		[HttpPost("save")]
		public async Task<IActionResult> CreateDepartamento([FromBody] DepartmentoRequest deparamentoRequest)
		{
			Departmento departmento = await _departamentoRepository.CreateDepartamentoAsync(deparamentoRequest);
			if (departmento  == null)
			{
				return NotFound("Departamentos no registrados");
			}
			return Ok(departmento);
		}

		[HttpPut("update/{departamentoId}")]
		public async Task<IActionResult> UpdateDepartamento(int departamentoId, [FromBody] DepartmentoRequest deparamentoRequest)
		{
			Departmento departmento = await _departamentoRepository.UpdateDepartamentoAsync(departamentoId, deparamentoRequest);
			if (departmento == null)
			{
				return NotFound("Departamentos no registrados");
			}
			return Ok();
		}

		[HttpDelete("delete/{departamentoId}")]
		public async Task<IActionResult> DeleteDepartamento(int departamentoId)
		{
			Departmento departmento = await _departamentoRepository.DeleteDepartamentoAsync(departamentoId);
			if (departmento == null)
			{
				return NotFound("Departamentos no registrados");
			}
			return Ok();
		}
	}
}
