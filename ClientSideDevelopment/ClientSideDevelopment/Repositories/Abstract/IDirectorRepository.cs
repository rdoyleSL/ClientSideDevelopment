// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDirectorRepository.cs" company="2014">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the IDirectorRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Repositories.Abstract
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;

    /// <summary>
    /// The DirectorRepository interface.
    /// </summary>
    public interface IDirectorRepository
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
