﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientSideDevelopmentContext.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the ClientSideDevelopmentContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment.Models
{
    using System.Data.Entity;

    /// <summary>
    /// The client side development context.
    /// </summary>
    public class ClientSideDevelopmentContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideDevelopmentContext"/> class.
        /// </summary>
        public ClientSideDevelopmentContext() : base("ClientSideDevelopmentContext")
        {
        }

        /// <summary>
        /// Gets or sets the directors.
        /// </summary>
        public IDbSet<Director> Directors { get; set; }

        /// <summary>
        /// Gets or sets the movies.
        /// </summary>
        public IDbSet<Movie> Movies { get; set; } 
    }
}