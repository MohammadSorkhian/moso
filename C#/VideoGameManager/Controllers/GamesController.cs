using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameManager.DataAccess;

namespace VideoGameManager.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController: ControllerBase
    {
        private readonly VideoGameDataContext context;

        public GamesController(VideoGameDataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Game> GetAllGames()
        {
            return context.Games;
        }

        [HttpPost]
        public async Task< Game> AddGame([FromBody]Game newGame)
        {
            context.Add(newGame);

            await context.SaveChangesAsync();
            return newGame;
        }
    }
}
