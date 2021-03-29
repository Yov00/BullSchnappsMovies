using System.Collections.Generic;
using Domain;

namespace API.Models
{
    public class ListMovies
    {
        public Movie[] Results { get; set; }
        public int Page { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}