using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MusicaAPI.Models;

namespace MusicaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicaController : Controller
    {
        private List<Musica> musicas;

        public MusicaController()
        {
            musicas = new List<Musica>()
            {
                new Musica("$20", "boygenius", "Indie rock", new DateTime(2023, 3, 31), "the record", "Interscope Records"),
                new Musica("Emily I'm Sorry", "boygenius", "Indie rock", new DateTime(2023, 3, 31), "the record", "Interscope Records"),
                new Musica("True Blue", "boygenius", "Indie rock", new DateTime(2023, 3, 31), "the record", "Interscope Records"),
            };
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Obter()
        {
            return Ok(musicas);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Inserir(Musica musica)
        {
            musicas.Add(musica);

            return Created();
        }
    }
}