using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Notificacion
{
    [Key]
    public int Id { get; set; }

    public int? AlertaId { get; set; }

    [ForeignKey("AlertaId")]
    public Alerta Alerta { get; set; }

    public int? UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required]
    public DateTime FechaHora { get; set; } = DateTime.Now;

    [Required]
    public EstadoNotificacion Estado { get; set; } = EstadoNotificacion.Enviada;
}

public enum EstadoNotificacion
{
    Enviada,
    Recibida,
    Leida
}
