using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using API.Models;
using DataAccess;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumeController : ControllerBase
    {
        private IHttpClientFactory _clientFactory;

        public DataContext _context { get; }

        public ConsumeController(IHttpClientFactory clientFactory,DataContext context)
        {
            _clientFactory = clientFactory;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
           
            int pages = 427;
            for ( int page = 0; page <= pages;page++){

           
                var request = new HttpRequestMessage(HttpMethod.Get,
               $"https://api.themoviedb.org/3/movie/top_rated?api_key=someShit&language=en-US&page={page}"
                );

            var client = _clientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);

                if(response.IsSuccessStatusCode)
                {
                    ListMovies movies = await response.Content.ReadFromJsonAsync<ListMovies>();
                    
                    if(movies.Results!=null)
                    {
                            
                            foreach(var m in movies.Results)
                            {
                                Movie newMovie = new Movie
                                {
                                    Id = m.Id,
                                    Title = m.Title,
                                    Overview = m.Overview,
                                    Adult = m.Adult,
                                    Backdrop_path = m.Backdrop_path,
                                    Original_language = m.Original_language,
                                    Original_title = m.Original_title,
                                    Popularity = m.Popularity,
                                    Poster_path = m.Poster_path,
                                    Release_date = m.Release_date,
                                    Video = m.Video,
                                    Vote_avarage = m.Vote_avarage,
                                    Vote_count = m.Vote_count
                                };
                                await _context.Movies.AddAsync(newMovie);
                        }
                
                    
                        await _context.SaveChangesAsync();

                    }
                }
            }
            var allMovies = await _context.Movies.ToListAsync();
            if(allMovies.Any())
            {
                 return Ok(allMovies);
            }
            return Ok();
        }

        [Route("delete-all-movies")]
        public async Task<IActionResult> deleteRecords()
        {
            var allmovies = await _context.Movies.ToListAsync();
            
            _context.Movies.RemoveRange(allmovies);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}