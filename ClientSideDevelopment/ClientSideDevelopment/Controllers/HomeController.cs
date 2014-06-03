﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Controllers
{
    using System.Web.Mvc;

    using ClientSideDevelopment.Services.Abstract;
    using ClientSideDevelopment.ViewModels.Home;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// The movie service.
        /// </summary>
        private readonly IMovieService movieService;

        /// <summary>
        /// The director service.
        /// </summary>
        private readonly IDirectorService directorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        /// <param name="movieService">The movie Service.</param>
        /// <param name="directorService">The director Service.</param>
        public HomeController(IMovieService movieService, IDirectorService directorService)
        {
            this.movieService = movieService;
            this.directorService = directorService;
        }

        /// <summary>
        /// The index page.
        /// </summary>
        /// <returns>The <see cref="ActionResult"/>.</returns>
        public ActionResult Index()
        {
            var movies = this.movieService.GetAllMovies();
            var directors = this.directorService.GetAllDirectors();

            var model = new IndexViewModel { Movies = movies, Directors = directors };

            return this.View(model);
        }

        /// <summary>
        /// Adds the new movie.
        /// </summary>
        /// <param name="movieTitle">The movie title.</param>
        /// <param name="releaseYear">The release year.</param>
        /// <param name="directorId">The director identifier.</param>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        [HttpPost]
        public JsonResult AddNewMovie(string movieTitle, int releaseYear, int directorId)
        {
            this.movieService.AddNewMovie(movieTitle, releaseYear, directorId);

            return new JsonResult();
        }
    }
}
