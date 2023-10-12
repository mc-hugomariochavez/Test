using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Test.Models;

[Table("DEPARTAMENTO")]
public class Departmento
{
	[Key]
	public int Id { get; set; }
    [Required, StringLength(100)]
    public string Codigo { get; set; }
	[Required, StringLength(100)]
	public string Nombre { get; set; }
	public bool Activo { get; set; } = true;

	[Required, StringLength(100), JsonPropertyName("id_usuario_creacion")]
	public int IdUsuarioCreacion {get;set;}
}

public class DepartmentoRequest
{
	[Required]
	public string Codigo { get; set; }
	[Required]
	public string Nombre { get; set; }
	public bool Activo { get; set; } = true;

	[Required, JsonPropertyName("id_usuario_creacion")]
	public int IdUsuarioCreacion { get; set; }
}

