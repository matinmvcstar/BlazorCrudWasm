using BlazorCrudWasm.Data;
using BlazorCrudWasm.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudWasm.Controllers
{
    [Route("api/videogames")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly DataContext _context;

        public VideoGamesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGamesAsync()
        {
            return await _context.VideoGames.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetGameByIdAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);
            if(result == null) 
                return NotFound("Game Not Found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);
            if (result == null)
                return NotFound("Game Not Found");

            _context.VideoGames.Remove(result);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VideoGame>> UpdateGameAsync(int id, VideoGame updatedGame)
        {
            var dtGame = await _context.VideoGames.FindAsync(id);
            if (dtGame == null)
                return NotFound("Game Not Found");

            dtGame.Title = updatedGame.Title;
            dtGame.Publisher = updatedGame.Publisher;
            dtGame.ReleaseYear = updatedGame.ReleaseYear;

            await _context.SaveChangesAsync();

            return Ok(dtGame);
        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddGameAsync(VideoGame newGame)
        {
            _context.VideoGames.Add(newGame);
            await _context.SaveChangesAsync();

            return Ok(newGame);
        }
    }
}
