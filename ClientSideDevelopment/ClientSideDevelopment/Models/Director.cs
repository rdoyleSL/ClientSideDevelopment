// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Director.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the Director type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The model representing a director.
    /// </summary>
    public class Director
    {
        /// <summary>
        /// Gets or sets the director identifier.
        /// </summary>
        public int DirectorId { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        public virtual ICollection<Movie> Movies { get; set; } 
    }
}