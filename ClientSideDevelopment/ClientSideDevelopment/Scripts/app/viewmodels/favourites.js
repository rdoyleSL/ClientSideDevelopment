(function ($, filmSite) {
    "use strict";

    filmSite.FavouritesViewModel = function () {
        var movies = ko.observableArray([]);

        function loadMovies() {
            movies.removeAll();
            $.ajax({
                url: "/Home/GetMovies",
                type: "GET",
                dataType: "json",
                success: function (response) {
                    for (var i = 0; i < response.length; i++) {
                        var movie = response[i];
                        movies.push(ko.observable(new filmSite.MovieViewModel(movie.Title, movie.ReleaseYear, movie.Rating)));
                    }
                }
            });
        }

        function addMovie(movie) {
            movies.push(ko.observable(movie));
        }

        loadMovies();

        return {
            movies: movies,
            addMovie: addMovie
        }
    };

})($, window.filmSite = window.filmSite || {});