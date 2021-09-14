using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    [Route("api/")]
    public class AgendaController : Controller
    {
        private iContatosService _service;

        public AgendaController(iContatosService service)
        {
            _service = service;
        }
        
        [HttpGet("Contatos")]
        public dynamic Contatos()
        {
            return _service.Contatos();
        }
        
        [HttpGet("BuscarContato/{id}")]
        public dynamic Contato(int id)
        {
            return _service.BuscarContato(id);
        }

        [HttpGet("Pesquisar/{nome}")]
        public dynamic Pesquisar(string nome)
        {
            return _service.Pesquisar(nome);
        }

        [HttpPost("NovoContato")]
        public dynamic NovoContato([FromBody]dynamic Obj)
        {
            return _service.NovoContato(Obj);
        }

        [HttpPost("EditarContato")]
        public dynamic EditarContato([FromBody]dynamic Obj)
        {
            return _service.EditarContato(Obj);
        }

        [HttpGet("ExcluirContato/{id}")]
        public dynamic ExcluirContato(int id)
        {
            return _service.ExcluirContato(id);
        }
    }
}