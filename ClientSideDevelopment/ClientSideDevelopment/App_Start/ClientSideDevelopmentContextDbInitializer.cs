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
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

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
            var directors = new List<Director>
                                {
                                    new Director { DateOfBirth = new DateTime(1959, 1, 28), FirstName = "Frank", Surname = "Darabont", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1939, 4, 7), FirstName = "Francis Ford", Surname = "Coppola", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1970, 7, 30), FirstName = "Christopher", Surname = "Nolan", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1963, 3, 27), FirstName = "Quentin", Surname = "Taantinor", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1929, 1, 3), FirstName = "Sergio", Surname = "Leone", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1946, 12, 18), FirstName = "Steven", Surname = "Spielberg", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1926, 6, 25), FirstName = "Sidney", Surname = "Lumet", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1961, 10, 31), FirstName = "Peter", Surname = "Jackson", Gender = "Male" },
                                    new Director { DateOfBirth = new DateTime(1962, 8, 28), FirstName = "David", Surname = "Fincher", Gender = "Male" }
                                };
            directors.ForEach(d => context.Directors.Add(d));

            var movies = new List<Movie>
                             {
                                 new Movie { Title = "The Shawshank Redemption", ReleaseYear = 1994, Director = directors.ElementAt(0) },
                                 new Movie { Title = "The Godfather", ReleaseYear = 1972, Director = directors.ElementAt(1) },
                                 new Movie { Title = "The Godfather: Part II", ReleaseYear = 1974, Director = directors.ElementAt(1) },
                                 new Movie { Title = "The Dark Knight", ReleaseYear = 2008, Director = directors.ElementAt(2) },
                                 new Movie { Title = "Pulp Fiction", ReleaseYear = 1994, Director = directors.ElementAt(3) },
                                 new Movie { Title = "The Good, the Bad and the Ugly", ReleaseYear = 1966, Director = directors.ElementAt(4) },
                                 new Movie { Title = "Schindler's List", ReleaseYear = 1993, Director = directors.ElementAt(5) },
                                 new Movie { Title = "12 Angry Men", ReleaseYear = 1957, Director = directors.ElementAt(6) },
                                 new Movie { Title = "The Lord of the Rings: The Return of the King", ReleaseYear = 2003, Director = directors.ElementAt(7) },
                                 new Movie { Title = "Fight Club", ReleaseYear = 1999, Director = directors.ElementAt(8) }
                             };
            movies.ForEach(m => context.Movies.Add(m));

            context.SaveChanges();
        }
    }
}