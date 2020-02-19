using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_LESSON.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmptyController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {

            return Ok(pokemons);
        }
        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "EkaNs", Strenght = 67},
            new Pokemon() {Name = "bULBasAur", Strenght = 200},
            new Pokemon() {Name = "Eva-Lena", Strenght = 9001}
        };
    }
}