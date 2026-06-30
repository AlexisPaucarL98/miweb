using System;
using System.Collections.Generic;
using System.Text;

namespace WEB.Application
{
    public class ClienteResponse
    {
        public int IdCliente { get; set; }
        public string TipoDocumento { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string? RazonSocial {  get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public bool Estado { get; set; }
        public string? UsuarioAuditoria { get; set; }

    }
}


