using Microsoft.AspNetCore.Mvc;
using WEB.Application;

namespace WEB.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    //DEFINICION
    public class ClientesController : Controller
    {
        private readonly ClienteService _service;

        //CONSTRUCTOR
        public ClientesController(ClienteService service)
        {
           _service = service;
        }
        //ACCION A REALIZAR
        [HttpGet]
        [Route("Listar")]
        public async Task<IActionResult> Listar()
        {
            var cliente = await _service.ListarClientesAsync();

            return Ok(cliente);
        }

        [HttpGet]
        [Route("ObtenerCliente")]
        public async Task<IActionResult> ObtenerClientePorDocumentoAsync(string numeroDocumento)
        {
            var cliente = await _service.ObtenerClientePorDocumentoAsync(numeroDocumento);

            return Ok(cliente);
        }

        [HttpGet]
        [Route("ActualizarEstadoCliente")]
        public async Task<IActionResult> ActualizarEstadoClienteAsync(int idCliente)
        {
            var cliente = await _service.ActualizarEstadoClienteAsync(idCliente);

            return Ok(cliente);
        }
        [HttpGet]
        [Route("ELIMINARCLIENTE")]
        public async Task<IActionResult> ELIMINARCLIENTEAsync(int idCliente)
        {
            var cliente = await _service.ELIMINARCLIENTEAsync(idCliente);

            return Ok(cliente);
        }

        [HttpPost]
        [Route("Registrar")]
        public async Task<IActionResult>
        Registrar([FromBody] RegistrarClienteRequest request)
        {
            int response =
                await _service.RegistrarAsync(request);

            return Created(
                $"api/clientes/{response}",
                response);
        }
    }
}