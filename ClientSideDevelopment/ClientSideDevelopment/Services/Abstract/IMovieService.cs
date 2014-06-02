// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMovieService.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the IMovieService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Services.Abstract
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;

    /// <summary>
    /// The MovieService interface.
    /// </summary>
    public interface IMovieService
    {
        /// <summary>
        /// Gets all the movies.
        /// </summary>
        /// <returns>The movies.</returns>
        IEnumerable<Movie> GetAllMovies();
    }
}
