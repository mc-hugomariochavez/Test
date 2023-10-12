using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Models;

[Table("DEPARTAMENTO")]
public class Departmento
{
	[Key]
	public int Id { get; set; }
    [StringLength(100)]
    public string Codigo { get; set; }
	[StringLength(100)]
	public string Nombre { get; set; }
	public bool Activo { get; set; } = true;

    public int IdUsuarioCreacion {get;set;}
}

