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

    using ClientSideDevelopment.Models;
    using ClientSideDevelopment.Repositories.Abstract;

    /// <summary>
    /// The movie repository.
    /// </summary>
    public class MovieRepository : IMovieRepository
    {
        /// <summary>
        /// The client side development context.
        /// </summary>
        private readonly ClientSideDevelopmentContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="MovieRepository" /> class.
        /// </summary>
        /// <param name="clientSideDevelopmentContext">The client side development context.</param>
        public MovieRepository()
        {
            this.context = new ClientSideDevelopmentContext();
        }

        /// <summary>
        /// Gets all the movies.
        /// </summary>
        /// <returns>The movies.</returns>
        public IEnumerable<Movie> GetAllMovies()
        {
            return this.context.Movies;
        }
    }
}