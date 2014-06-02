// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientSideDevelopmentContextDbInitializer.cs" company="Scott Logic Ltd">
//   Copyright (c) Scott Logic Ltd 2014. All rights reserved.
// </copyright>
// <summary>
//   Defines the ClientSideDevlopmentContextDbInitializer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClientSideDevelopment
{
    using System.Collections.Generic;
    using System.Data.Entity;

    using ClientSideDevelopment.Models;

    /// <summary>
    /// The client side development context database initializer.
    /// </summary>
    public class ClientSideDevelopmentContextDbInitializer : DropCreateDatabaseIfModelChanges<ClientSideDevelopmentContext>
    {
        /// <summary>
        /// The seed.
        /// </summary>
        /// <param name="context">The context.</param>
        protected override void Seed(ClientSideDevelopmentContext context)
        {
            var movies = new List<Movie>
                             {
                                 new Movie { Title = "The Shawshank Redemption", ReleaseYear = 1994, MovieId = 0 },
                                 new Movie { Title = "The Godfather", ReleaseYear = 1972, MovieId = 1 },
                                 new Movie { Title = "The Godfather: Part II", ReleaseYear = 1974, MovieId = 2 },
                                 new Movie { Title = "The Dark Knight", ReleaseYear = 2008, MovieId = 3 },
                                 new Movie { Title = "Pulp Fiction", ReleaseYear = 1994, MovieId = 4 },
                                 new Movie { Title = "The Good, the Bad and the Ugly", ReleaseYear = 1966, MovieId = 5 },
                                 new Movie { Title = "Schindler's List", ReleaseYear = 1993, MovieId = 6 },
                                 new Movie { Title = "12 Angry Men", ReleaseYear = 1957, MovieId = 7 },
                                 new Movie { Title = "The Lord of the Rings: The Return of the King", ReleaseYear = 2003, MovieId = 8 },
                                 new Movie { Title = "Fight Club", ReleaseYear = 1999, MovieId = 9 }
                             };
            movies.ForEach(m => context.Movies.Add(m));

            context.SaveChanges();
        }
    }
}