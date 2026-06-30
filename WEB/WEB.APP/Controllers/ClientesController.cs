using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WEB.APP.Models;

namespace WEB.APP.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ClientesController(
        IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();

            var response =
                await client.GetAsync("https://localhost:44327/Clientes/Listar");

            if (!response.IsSuccessStatusCode)
            {
                return View(new List<ClienteViewModel>());
            }

            var json =
                await response.Content.ReadAsStringAsync();

            var clientes =  
                JsonSerializer.Deserialize<
                    List<ClienteViewModel>>(
                        json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });

            return View(clientes);
        }
    }

        
}
