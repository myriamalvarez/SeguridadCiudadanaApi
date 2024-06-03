using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ContactoEmergencia
{
    [Key]
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Telefono { get; set; }

    [Required]
    public string TipoContacto { get; set; }

    public string Direccion { get; set; }

    public string Email { get; set; }
}
