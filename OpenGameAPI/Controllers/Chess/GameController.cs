using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenChess;
using OpenGame;

namespace OpenGameAPI.Controllers
{
    [Route("api/chess/game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public async Task<Game> GetGame(string id)
        {
            if (!Guid.TryParse(id, out Guid guid))
                return null;

            if (!GameManager.Games.TryGetValue(guid, out Game? g))
                return null;
            
            return g;
        }
    }
}
