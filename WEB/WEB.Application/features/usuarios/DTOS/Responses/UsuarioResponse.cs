using System;
using System.Collections.Generic;
using System.Text;

namespace WEB.Application.features.usuarios.DTOS.Responses
{
    public class UsuarioResponse
    {
        public int IdUsuario { get; set; }
        public string NumeroDocUsuario { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public string? Correo { get; set; }

    }
}
