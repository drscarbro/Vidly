using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return movie;
            }
        }

        [HttpPost]
        public Movie CreateMovie(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                throw  new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
            }

            return movie;
        }

        [HttpPut]
        public void UpdateMovie(int id, Movie movie)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
                if (movieInDb == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
                else
                {
                    movieInDb.Id = id;
                    movieInDb.Name = movie.Name;
                    movieInDb.GenreId = movie.GenreId;
                    movieInDb.ReleaseDate = movie.ReleaseDate;
                    movieInDb.NumberInStock = movie.NumberInStock;
                }
            }
            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                _context.Movies.Remove(movieInDb);
            }

            _context.SaveChanges();
        }

    }
}
