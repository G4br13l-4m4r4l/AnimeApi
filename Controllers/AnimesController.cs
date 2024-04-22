using Anime.Context;
using Anime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Anime.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimesController : Controller
    {
        private readonly AppDbContext _context;

        public AnimesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Animes>> GetAll()
        {
            var animes = _context.Animes.ToList();
            if (animes is null)
                return NotFound("Não foi encontrado nenhum anime na lista...");

            return Ok(animes);  
        }

        [HttpGet("{id:int}", Name ="ObterUm")]
        public ActionResult<Animes> GetOne(int id) { 
            var anime = _context.Animes.FirstOrDefault(a=>a.AnimeId == id);
            if(anime is null)
                return NotFound("Anime especificado não encontrado...");

            return Ok(anime);
        }
        [HttpPost]
        public ActionResult Adicionar(Animes animes)
        {
            if (animes is null)
                return BadRequest();

            _context.Animes.Add(animes);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterUm", new {id = animes.AnimeId}, animes);
        }

        [HttpPut("{id:int}")]
        public ActionResult Edit(int id,Animes animes)
        {
            if (id != animes.AnimeId)
                return BadRequest();

            _context.Entry(animes).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(animes);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var anime = _context.Animes.FirstOrDefault(a=>a.AnimeId == id);

            if (anime is null)
                return NotFound("Anime não encontrado na lista para deletar...");

            _context.Animes.Remove(anime);
            _context.SaveChanges();
            return Ok(anime);
        }
    }
}
