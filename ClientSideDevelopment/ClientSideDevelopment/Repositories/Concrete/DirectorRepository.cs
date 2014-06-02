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
    }
}