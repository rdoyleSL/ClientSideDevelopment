// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovieRepository.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved. 
// </copyright>
// <summary>
//   The movie repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Repositories.Concrete
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using ClientSideDevelopment.Models;
    using ClientSideDevelopment.Repositories.Abstract;

    /// <summary>
    /// The movie repository.
    /// </summary>
    public class MovieRepository : IMovieRepository
    {
        /// <summary>
        /// Gets all the movies.
        /// </summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAllMovies()
        {
            using (var context = new ClientSideDevelopmentContext())
            {
                return context.Movies.Include(m => m.Director).ToList();
            }
        }

        /// <summary>
        /// Adds the new movie.
        /// </summary>
        /// <param name="movie">The movie.</param>
        /// <returns>The movie that has been added.</returns>
        public Movie AddNewMovie(Movie movie)
        {
            using (var context = new ClientSideDevelopmentContext())
            {
                context.Movies.Add(movie);
                context.SaveChanges();
            }

            return movie;
        }
    }
}