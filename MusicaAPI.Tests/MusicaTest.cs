using Microsoft.AspNetCore.Mvc;
using MusicaAPI.Controllers;

namespace MusicaAPI.Tests
{
    public class MusicaTest
    {
        [Fact]
        public void VerificarStatusCodeObter()
        {
            var musicaCtrl = new MusicaController();
            var retorno = musicaCtrl.Obter() as OkObjectResult;
            
            Assert.Equal(200, retorno.StatusCode);
        }

        [Fact]
        public void VerificarNumeroMusicas()
        {
            var musicaCtrl = new MusicaController();
            var retorno = musicaCtrl.Obter() as OkObjectResult;
            var musicas = retorno.Value as IEnumerable<Models.Musica>;

            Assert.Equal(3, musicas.Count());
        }
    }
}