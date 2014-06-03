// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddNewMovieViewModel.cs" company="Scott Logic">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved. 
// </copyright>
// <summary>
//   The add new movie view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.ViewModels.Home
{
    using System.Collections.Generic;

    using ClientSideDevelopment.Models;

    /// <summary>
    /// The add new movie view model.
    /// </summary>
    public class AddNewMovieViewModel
    {
        /// <summary>
        /// Gets or sets the directors.
        /// </summary>
        public IEnumerable<Director> Directors { get; set; }
    }
}