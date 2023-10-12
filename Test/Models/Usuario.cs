using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models;

[Table("USUARIOS")]
public class Usuario
{
	[Key]
	public int Id { get; set; }

	[Required, StringLength(100)]
	public string PrimerNombre { get; set; }

	[Required, StringLength(100)]
	public string SegundoNombre { get; set; }

	[Required, StringLength(100)]
	public string PrimerApellido { get; set; }

	[Required, StringLength(100)]
	public string SegundoApellido { get; set; }

	[ForeignKey("Departamento")]
	public int IdDepartamento { get; set; }
	[ForeignKey("Cargo")]
	public int IdCargo { get; set; }


	public Cargo Cargo { get; set; }
	public Departmento Departamento { get; set; }

}

