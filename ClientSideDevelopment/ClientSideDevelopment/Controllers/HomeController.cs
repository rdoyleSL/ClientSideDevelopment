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
        /// Initializes a new instance of the <see cref="HomeController"/> class.
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
    }
}
