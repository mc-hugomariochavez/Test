using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Test.DAL.CargoRepository;
using Test.Models;

namespace Test.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CargoController : Controller
	{
		private readonly ICargoRepository _cargoRepository;

        public CargoController(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
		}


		[HttpGet]
		public async Task<IActionResult> Index()
		{
			List<Cargo> cargos = await _cargoRepository.GetCargoAsync();
			if (cargos.IsNullOrEmpty())
			{
				return NotFound("Cargos no registrados");
			}
			return Ok(cargos);
		}

		[HttpPost("save")]
		public async Task<IActionResult> CreateCargo([FromBody] CargoRequest cargoRequest)
		{
			Cargo cargo = await _cargoRepository.CreateCargoAsync(cargoRequest);
			if (cargo == null)
			{
				return NotFound("Cargos no registrados");
			}
			return Ok(cargo);
		}

		[HttpPut("update/{cargoId}")]
		public async Task<IActionResult> UpdateCargo(int cargoId, [FromBody] CargoRequest cargoRequest)
		{
			Cargo cargo = await _cargoRepository.UpdateCargoAsync(cargoId, cargoRequest);
			if (cargo == null)
			{
				return NotFound("Cargos no registrados");
			}
			return Ok(cargo);
		}

		[HttpDelete("delete/{cargoId}")]
		public async Task<IActionResult> DeleteCargo(int cargoId)
		{
			Cargo cargo = await _cargoRepository.DeleteCargoAsync(cargoId);
			if (cargo == null)
			{
				return NotFound("Cargos no registrados");
			}
			return Ok(cargo);
		}


	}
}
