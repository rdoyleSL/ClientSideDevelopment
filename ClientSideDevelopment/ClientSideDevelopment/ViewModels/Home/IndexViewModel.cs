// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndexViewModel.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the IndexViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.ViewModels.Home
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;

    /// <summary>
    /// The index view model.
    /// </summary>
    public class IndexViewModel
    {
        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        public IEnumerable<Movie> Movies { get; set; }

        /// <summary>
        /// Gets or sets the directors.
        /// </summary>
        public IEnumerable<Director> Directors { get; set; } 
    }
}