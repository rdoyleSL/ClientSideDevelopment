// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DirectorRepository.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the DirectorRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Repositories.Concrete
{
    using System.Collections.Generic;
    using System.Linq;

    using ClientSideDevelopment.Models;
    using ClientSideDevelopment.Repositories.Abstract;

    /// <summary>
    /// The director repository.
    /// </summary>
    public class DirectorRepository : IDirectorRepository
    {
        /// <summary>
        /// Gets all of the directors.
        /// </summary>
        /// <returns>The directors.</returns>
        public IEnumerable<Director> GetAllDirectors()
        {
            using (var context = new ClientSideDevelopmentContext())
            {
                return context.Directors.ToList();
            }
        }

        /// <summary>
        /// Gets the director.
        /// </summary>
        /// <param name="directorId">The director identifier.</param>
        /// <returns>The director.</returns>
        public Director GetDirector(int directorId)
        {
            using (var context = new ClientSideDevelopmentContext())
            {
                return context.Directors.SingleOrDefault(d => d.DirectorId == directorId);
            }
        }
    }
}