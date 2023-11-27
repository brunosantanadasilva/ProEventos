using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _eventos = new Evento[] {
            new Evento {
                EventoId = 1,
                Tema = "Video Angular 11 e .Net 5",
                Local = "Online",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto.png"
            },
            new Evento {
                EventoId = 2,
                Tema = "Livro Ruim de Angular e .Net",
                Local = "Online",
                Lote = "Único",
                QtdPessoas = 2,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemUrl = "foto2.png"
            }
        };

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }


        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
