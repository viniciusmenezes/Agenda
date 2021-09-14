using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AgendaApp.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace AgendaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HttpClient client = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            client.BaseAddress = new Uri("https://localhost:44353/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<IActionResult> Index()
        {
            var retorno = await client.GetAsync("Contatos");
            List<Contato> contatos = JsonConvert.DeserializeObject<List<Contato>>(await retorno.Content.ReadAsStringAsync());
                        
            return View(contatos);
        }

        public IActionResult CriarContato()
        {            
            return View(new Contato());
        }

        [HttpPost]
        public async Task<IActionResult> CriarContato(Contato contato)
        {
            var retorno = await client.PostAsync("NovoContato", new StringContent(JsonConvert.SerializeObject(contato), Encoding.UTF8, "application/json"));

            if (retorno.IsSuccessStatusCode)
                return RedirectToAction("Index");
            else
                return View(contato);
        }
                
        public async Task<IActionResult> EditarContato(int id)
        {
            var retorno = await client.GetAsync($"BuscarContato/{id}");
            return View(JsonConvert.DeserializeObject<Contato>(await retorno.Content.ReadAsStringAsync()));
        }

        [HttpPost]
        public async Task<IActionResult> EditarContato(Contato contato)
        {
            var retorno = await client.PostAsync("EditarContato", new StringContent(JsonConvert.SerializeObject(contato), Encoding.UTF8, "application/json"));

            if (retorno.IsSuccessStatusCode)
                return RedirectToAction("Index");
            else
                return View(contato);
        }

        public async Task<IActionResult> Pesquisar(string pesquisa)
        {
            var retorno = await client.GetAsync($"Pesquisar/{pesquisa}");

            if (retorno.IsSuccessStatusCode)    
                return View(JsonConvert.DeserializeObject<Contato>(await retorno.Content.ReadAsStringAsync()));
            else
                return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeletarContato(int id)
        {
            var retorno = await client.GetAsync($"ExcluirContato/{id}");
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
