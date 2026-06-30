namespace WEB.APP.Models
{
    public class ClienteViewModel
    {
        public int IdCliente { get; set; }

        public int IdTipoDocumento { get; set; }

        public string TipoDocumento { get; set; } = string.Empty;

        public string NumeroDocumento { get; set; } = string.Empty;

        public string? nombreCompleto { get; set; }

        public string? Telefono { get; set; }

        public string? Correo { get; set; }

        public string? Direccion { get; set; }

        public string? Ciudad { get; set; }

        public bool Estado { get; set; }

        public string? UsuarioAuditoria { get; set; }

    }
}
