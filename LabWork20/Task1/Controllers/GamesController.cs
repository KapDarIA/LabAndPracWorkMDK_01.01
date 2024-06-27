using Microsoft.AspNetCore.Mvc;
using System.Net;
using Task1.Models;

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        static List<Game> Games = new List<Game>
        {
            new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
            new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
            new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
            new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
            new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
            new Game{IdGame = 6, Name = "Tetris2", Category = "головоломка", Price = 150},
            new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
            new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "аркада", Price = 300},
            new Game{IdGame = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
            new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Category = "платформер", Price = 1000},
        };


        //задание 1
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return Games;
        }

        //задание 2
        [HttpGet("{id:int}")]
        public Game Get(int id)
        {
            return Games.FirstOrDefault(game => game.IdGame == id);
        }

        //задание 3
        [HttpGet("{name}")]
        public IEnumerable<Game> Get(string name)
        {
            return Games.Where(game => game.Category == name.ToLower());
        }

        //задание 4
        [HttpGet("{pageId:int},{size:int}")]
        [ProducesResponseType(typeof(IEnumerable<Game>), (int)HttpStatusCode.OK)]
        public IEnumerable<Game> GetPage(int pageId, int size)
        {
            return Games.Skip(pageId * size).Take(size);
        }

        //задание 5
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)] //Возможные ответы
        public ActionResult Delete(int id)
        {
            var game = Games.FirstOrDefault(game => game.IdGame == id);
            if (Games.Remove(game))
            {
                return StatusCode((int)HttpStatusCode.NoContent);
            }
            return StatusCode((int)HttpStatusCode.InternalServerError);
        }
    }
}