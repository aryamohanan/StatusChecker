using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatusChecker.services.SuperHeroService;

namespace StatusChecker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;
     public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAll()
        {
            var superHeros = _superHeroService.GetAll();
            return Ok(superHeros);
        }
        [HttpGet("{id}")]
        //     [Route("{id}")]
        public async Task<ActionResult<List<SuperHero>>> GetSingle(int id)
        {
            var superHeros = _superHeroService.GetSingle(id);
            return Ok(superHeros);

        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var superHeros = _superHeroService.AddHero(hero);
            return Ok(superHeros);
        }
            [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero hero)
        {
            var superHeros = _superHeroService.UpdateHero(hero);
            return Ok(superHeros);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            return Ok(result);
        }
    }
}