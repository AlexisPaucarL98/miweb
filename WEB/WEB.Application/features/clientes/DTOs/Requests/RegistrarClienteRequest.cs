using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
public class RegistrarClienteRequest
{
    [Required]
    public int IdTipoDocumento { get; set; }

    [Required]
    [MaxLength(15)]
    public string NumeroDocumento { get; set; } = string.Empty;

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? RazonSocial { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Ciudad { get; set; }

    [Required]
    public int UsuarioAuditoria { get; set; }
}