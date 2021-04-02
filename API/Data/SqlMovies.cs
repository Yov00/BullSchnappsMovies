using System;
using System.Collections.Generic;
using System.Linq;
using API.Helpers;
using API.Models;
using DataAccess;
using Domain;

namespace API.Data
{
    public class SqlMovies : IMoviesRepo
    {
        private readonly DataContext _context;

        public SqlMovies(DataContext context)
        {
            _context = context;
        }

         public PagedList<Movie> GetAllMoves(string sorting_order,Pagination pagination)
         {

            var movies = from m in _context.Movies
                            select m;

            switch(sorting_order)
            {
                case "release_date":
                  movies = movies.OrderBy(m => m.Release_date);
                    break;
                case "release_date_desc":
                     movies = movies.OrderByDescending(movies => movies.Release_date);
                    break;
                case "original_title":
                    movies = movies.OrderBy(m => m.Original_title);
                    break;
                case "original_title_desc":
                    movies = movies.OrderByDescending(m => m.Original_title);
                    break;
                default:
                movies = movies.OrderByDescending(m => m.Release_date);
                    break;
            }
            return PagedList<Movie>.ToPagedList(movies, pagination.PageNumber, pagination.PageSize);

        }
        public Movie GetMovieById(int id)
         {
            var movie = _context.Movies.First(m => m.Id == id);
            return movie;
        }

    }
}