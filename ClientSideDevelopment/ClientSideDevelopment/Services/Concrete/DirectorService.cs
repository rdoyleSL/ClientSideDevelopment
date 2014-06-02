// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DirectorService.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   The director service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Services.Concrete
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;
    using ClientSideDevelopment.Repositories.Abstract;
    using ClientSideDevelopment.Services.Abstract;

    /// <summary>
    /// The director service.
    /// </summary>
    public class DirectorService : IDirectorService
    {
        /// <summary>
        /// The director repository.
        /// </summary>
        private readonly IDirectorRepository directorRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorService" /> class.
        /// </summary>
        /// <param name="directorRepository">The director repository.</param>
        public DirectorService(IDirectorRepository directorRepository)
        {
            this.directorRepository = directorRepository;
        }

        /// <summary>
        /// The get all directors.
        /// </summary>
        /// <returns>The directors.</returns>
        public IEnumerable<Director> GetAllDirectors()
        {
            return this.directorRepository.GetAllDirectors();
        }
    }
}