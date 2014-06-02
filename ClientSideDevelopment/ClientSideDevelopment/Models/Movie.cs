// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Movie.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the Movie type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Models
{
    /// <summary>
    /// The model representing a movie.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the movie identifier.
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// Gets or sets the movie title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the release year.
        /// </summary>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the director.
        /// </summary>
        public virtual Director Director { get; set; }
    }
}