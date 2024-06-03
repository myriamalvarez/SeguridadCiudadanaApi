using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Incidente
{
    [Key]
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required]
    public string TipoIncidente { get; set; }

    public string Descripcion { get; set; }

    [Required]
    public DateTime FechaHora { get; set; } = DateTime.Now;

    [Required]
    public decimal Latitud { get; set; }

    [Required]
    public decimal Longitud { get; set; }

    public string FotoUrl { get; set; }

    public string VideoUrl { get; set; }

    [Required]
    public EstadoIncidente Estado { get; set; } = EstadoIncidente.Pendiente;
}

public enum EstadoIncidente
{
    Pendiente,
    EnProceso,
    Resuelto
}
