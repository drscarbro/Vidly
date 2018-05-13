using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using DateTime = System.DateTime;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        #region DB Context
        //Initialize new DB Context for EF and Dispose of it when finished
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        #endregion DB Context

        #region MoviesController Actions
        // INDEX: Movie
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(g => g.Genre).ToList();

            return View(movies);
        }

        // NEW: Movie
        public ActionResult New(Movie movie)
        {
            var genreTypes = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = genreTypes
            };
            return View("MovieForm", viewModel);
        }
        // EDIT: Movie
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        // SAVE: Movie
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieIndDb = _context.Movies.Single(c => c.Id == movie.Id);

                movieIndDb.Name = movie.Name;
                movieIndDb.GenreId = movie.GenreId;
                movieIndDb.NumberInStock = movie.NumberInStock;
                movieIndDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
        #endregion MoviesController Actions
    }
}