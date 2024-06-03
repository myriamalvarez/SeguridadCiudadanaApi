using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Alerta
{
    [Key]
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required]
    public string TipoAlerta { get; set; }

    [Required]
    public DateTime FechaHora { get; set; } = DateTime.Now;

    [Required]
    public decimal Latitud { get; set; }

    [Required]
    public decimal Longitud { get; set; }

    public string Mensaje { get; set; }
}
