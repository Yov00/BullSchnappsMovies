using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MoviesController(IMoviesRepo repository)
        {
            _repository = repository;
        }

        public IMoviesRepo _repository { get; private set; }

        [HttpGet]
        [EnableQuery]
        public IActionResult GetMovies([FromQuery] string sortingOrder,[FromQuery]int pageNumber, [FromQuery]int pageSize)
        {
            string orderBy = "default_order";
            Pagination pagination = new Pagination
            {
                PageNumber = pageNumber>0 ? pageNumber : 1,
                PageSize = pageSize>0 ? pageSize : 20
            };

            if(sortingOrder != null)
            {
                orderBy = sortingOrder;
            }

            var movies = _repository.GetAllMoves(orderBy,pagination);
            var metadata = new
            {
                CurrentPage = pagination.PageNumber,
                movies.PageSize,
                movies.TotalCount,
                movies.HasNext,
                movies.HasPrevious,
             

            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            if(movies.Any())
            {
                return Ok(movies);
            }

            return Ok("aaa");
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetSingleMovie(int id)
        {
            var movie = _repository.GetMovieById(id);
            if(movie != null)
            {
                return Ok(movie);
            }
            return NotFound();
        }
        
    }
}