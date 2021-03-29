using System;
using System.Collections.Generic;
using API.Helpers;
using API.Models;
using Domain;

namespace API.Data
{
    public interface IMoviesRepo
    {
        PagedList<Movie> GetAllMoves(string sorting_order,Pagination pagination);
        Movie GetMovieById(int id);
    }
  
    
}