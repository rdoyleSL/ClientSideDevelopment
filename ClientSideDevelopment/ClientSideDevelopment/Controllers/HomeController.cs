// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Controllers
{
    using System;
    using System.Web.Mvc;

    using ClientSideDevelopment.Services.Abstract;
    using ClientSideDevelopment.ViewModels.Home;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : BaseController
    {
        /// <summary>
        /// The movie service.
        /// </summary>
        private readonly IMovieService movieService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        /// <param name="movieService">The movie Service.</param>
        public HomeController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        /// <summary>
        /// The index page.
        /// </summary>
        /// <returns>The <see cref="ActionResult"/>.</returns>
        public ActionResult Index()
        {
            var movies = this.movieService.GetAllMovies();            
            var model = new IndexViewModel { Movies = movies };
            return this.View(model);
        }

        /// <summary>
        /// Gets the movies.
        /// </summary>
        /// <returns>The collection of movies</returns>
        public JsonResult GetMovies()
        {
            try
            {
                var movies = this.movieService.GetAllMovies();
                return this.JsonSuccess(movies, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exception)
            {
                return this.JsonError(exception.Message);                
            }            
        }

        /// <summary>
        /// Adds the new movie.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="releaseYear">The release year.</param>
        /// <param name="rating">The rating.</param>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        [HttpPost]
        public JsonResult AddNewMovie(string title, int releaseYear, int rating)
        {
            try
            {                
                this.movieService.AddNewMovie(title, releaseYear, rating);
                return this.JsonSuccess();
            }
            catch (Exception exception)
            {
                return this.JsonError(exception.Message);
            }
        }
    }
}