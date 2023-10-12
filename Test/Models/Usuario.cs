using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Test.Models;

[Table("USUARIOS")]
public class Usuario
{
	[Key]
	public int Id { get; set; }

	[Required, StringLength(100), JsonPropertyName("primer_nombre")]
	public string PrimerNombre { get; set; }

	[Required, StringLength(100), JsonPropertyName("segundo_nombre")]
	public string SegundoNombre { get; set; }

	[Required, StringLength(100), JsonPropertyName("primer_apellido")]
	public string PrimerApellido { get; set; }

	[Required, StringLength(100), JsonPropertyName("segundo_apellido")]
	public string SegundoApellido { get; set; }

	[ForeignKey("Departamento"), JsonPropertyName("id_departamento")]
	public int IdDepartamento { get; set; }
	[ForeignKey("Cargo"), JsonPropertyName("id_cargo")]
	public int IdCargo { get; set; }

	
	public Cargo Cargo { get; set; }
	public Departmento Departamento { get; set; }

}

public class UsuarioRequest
{

	[Required, JsonPropertyName("primer_nombre")]
	public string PrimerNombre { get; set; }

	[Required, JsonPropertyName("segundo_nombre")]
	public string SegundoNombre { get; set; }

	[Required, JsonPropertyName("primer_apellido")]
	public string PrimerApellido { get; set; }

	[Required, JsonPropertyName("segundo_apellido")]
	public string SegundoApellido { get; set; }

	[Required, JsonPropertyName("id_departamento")]
	public int IdDepartamento { get; set; }
	[Required, JsonPropertyName("id_cargo")]
	public int IdCargo { get; set; }
}

