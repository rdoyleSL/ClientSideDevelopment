// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMovieRepository.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the IMovieRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Repositories.Abstract
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;

    /// <summary>
    /// The MovieRepository interface.
    /// </summary>
    public interface IMovieRepository
    {
        /// <summary>
        /// Gets all the movies.
        /// </summary>
        /// <returns>The movies.</returns>
        IEnumerable<Movie> GetAllMovies();
    }
}
