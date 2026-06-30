using System;
using System.Collections.Generic;
using System.Text;

namespace WEB.Application.features.clientes.DTOs.Responses
{
    public class RegistrarClienteResponse
    {
        public int IdCliente { get; set; }

        public string Mensaje { get; set; } = string.Empty;
    }
}
