using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : Controller
    {
        private static List<string> actor1 = new List<string>
        {
            "Chris Hems",
            "Emma Stone",
            "Emma Myers"
        };
        private static List<string> actor2 = new List<string>
        {
            "Tom hiddlestone",
            "Benedict Cumberbatch",
            "beifong"
        };
        private static List<string> actor3 = new List<string>
        {
            "Tom Hanks",
            "Robert Downy",
            "Chris Evans"
        };
        private static List<Movie> _movieList = new List<Movie>
        {
            new Movie("Avenger","Nolan", "Super hero", actor1),
            new Movie("Avatar Aang", "Twinkle toes", "Negara api membuat kekacauan", actor2),
            new Movie("Spiderman","Nolan hemsworth", "Super hero laba", actor3)
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movieList;
        }

        [HttpGet("{index}")]
        public Movie GetByIndex(int index)
        {
            if (index < 0 || index > _movieList.Count)
            {
                return null;
            }
            return _movieList[index];
        }

        [HttpPost]
        public void AddMovie([FromBody] Movie movie)
        {
            _movieList.Add(movie);

        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {

            _movieList.RemoveAt(index);

        }
    }
}
