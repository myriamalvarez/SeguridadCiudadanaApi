using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Apellido { get; set; }

    [Required]
    public string Dni { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    public decimal? Latitud { get; set; }

    public decimal? Longitud { get; set; }

    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    public RolUsuario Rol { get; set; } = RolUsuario.Ciudadano;
}

public enum RolUsuario
{
    Ciudadano,
    Autoridad,
    Administrador
}
