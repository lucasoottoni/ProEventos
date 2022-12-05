using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
<<<<<<< HEAD
   
        
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
            
=======
    
      
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            this._context = context;
>>>>>>> 69b924b9c9c83399a59caa6877b6bde56123250b

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
<<<<<<< HEAD
            return  _context.Eventos.Where(evento => evento.EventoId ==id);
=======
            
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId ==id);
>>>>>>> 69b924b9c9c83399a59caa6877b6bde56123250b
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
