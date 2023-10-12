using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models
{
	[Table("CARGO")]
	public class Cargo
	{
		[Key]
		public int Id { get; set; }

		public string Codigo { get; set; }

		public string Nombre { get; set; }

		public bool Activo { get; set; }

		public int IdUsuarioCreacion { get; set; }
	}
}
