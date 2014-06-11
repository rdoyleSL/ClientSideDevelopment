// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovieService.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the MovieService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Services.Concrete
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;
    using ClientSideDevelopment.Repositories.Abstract;
    using ClientSideDevelopment.Services.Abstract;

    /// <summary>
    /// The movie service.
    /// </summary>
    public class MovieService : IMovieService
    {
        /// <summary>
        /// The movie repository.
        /// </summary>
        private readonly IMovieRepository movieRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieService" /> class.
        /// </summary>
        /// <param name="movieRepository">The movie repository.</param>
        public MovieService(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;            
        }

        /// <summary>
        /// Gets all the movies.
        /// </summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAllMovies()
        {
            return this.movieRepository.GetAllMovies();
        }

        /// <summary>
        /// Adds the new movie.
        /// </summary>
        /// <param name="title">The movie title.</param>
        /// <param name="releaseYear">The release year.</param>
        /// <param name="rating">The rating.</param>
        /// <returns>
        /// The movie that has been added.
        /// </returns>
        public Movie AddNewMovie(string title, int releaseYear, int rating)
        {            
            var movie = new Movie { Title = title, ReleaseYear = releaseYear, Rating = rating };
            return this.movieRepository.AddNewMovie(movie);
        }
    }
}