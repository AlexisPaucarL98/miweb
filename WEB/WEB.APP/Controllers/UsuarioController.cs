using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WEB.APP.Models;

namespace WEB.APP.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UsuariosController(
        IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();

            var response =
                await client.GetAsync("https://localhost:44327/Usuario/ListarUsuario");

            if (!response.IsSuccessStatusCode)
            {
                return View(new List<UsuarioViewModel>());
            }

            var json =
                await response.Content.ReadAsStringAsync();

            var usuarios =
                JsonSerializer.Deserialize<
                    List<UsuarioViewModel>>(
                        json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

            return View(usuarios);
        }
    }
}
