namespace WEB.APP.Models
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string NumeroDocUsuario { get; set; } = string.Empty;
        public string? Nombres{ get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }

    }
}
