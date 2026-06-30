using Microsoft.AspNetCore.Mvc;
using WEB.Application;
using WEB.Application.features.usuarios.Services;

namespace WEB.API.Controllers
{
   
        [ApiController]
        [Route("[controller]")]

        //DEFINICION
        public class UsuarioController : Controller
        {
            private readonly UsuarioService _service;

            //CONSTRUCTOR
            public UsuarioController(UsuarioService service)
            {
                _service = service;
            }
            //ACCION A REALIZAR
            [HttpGet]
            [Route("ListarUsuario")]
            public async Task<IActionResult> ListarUsuarios()
            {
                var usuario = await _service.ListarUsuariosAsync();

                return Ok(usuario);
            }
        }
}
