using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Persistence;
using ProEventos.Domain;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
   
        
        private readonly ProEventosContext _context;
        public EventoController(ProEventosContext context)
        {
            _context = context;
        }




        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        

        [HttpGet("{id}")]
        public  Evento GetById(int id)
        {

           return _context.Eventos.FirstOrDefault(evento => evento.Id ==id);

        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo put com o id {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com o id = {id}";
        }
    }
}
