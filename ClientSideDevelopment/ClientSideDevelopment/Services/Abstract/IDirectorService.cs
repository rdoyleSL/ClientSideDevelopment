// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDirectorService.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the IDirectorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Services.Abstract
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;

    /// <summary>
    /// The DirectorService interface.
    /// </summary>
    public interface IDirectorService
    {
        /// <summary>
        /// Gets all of the directors.
        /// </summary>
        /// <returns>The directors.</returns>
        IEnumerable<Director> GetAllDirectors();

        /// <summary>
        /// Gets the director.
        /// </summary>
        /// <param name="directorId">The director identifier.</param>
        /// <returns>The director.</returns>
        Director GetDirector(int directorId);
    }
}
