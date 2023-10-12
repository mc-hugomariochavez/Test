using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Test.Models
{
	[Table("CARGO")]
	public class Cargo
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Codigo { get; set; }
		[Required]
		public string Nombre { get; set; }

		public bool Activo { get; set; }

		[Required, JsonPropertyName("id_usuario_creacion")]

		public int IdUsuarioCreacion { get; set; }
	}

	public class CargoRequest
	{

		public string Codigo { get; set; }

		public string Nombre { get; set; }

		public bool Activo { get; set; }

		[Required, JsonPropertyName("id_usuario_creacion")]
		public int IdUsuarioCreacion { get; set; }
	}
}
