(function ($, postbox, filmSite) {
    "use strict";

    filmSite.FavouritesViewModel = function () {
        var movies = ko.observableArray([]);

        function loadMovies() {
            movies.removeAll();
            filmSite.favouriteMovieService.getMovies(function(response) {
                for (var i = 0; i < response.length; i++) {
                    var movie = response[i];
                    movies.push(ko.observable(new filmSite.MovieInfoViewModel(movie.title, movie.releaseYear, movie.rating)));
                }
            });
        }

        function viewRelatedTitles(movie) {
            postbox.publish("movieSelected", movie.title());
        }

        postbox.subscribe("movieAdded", function(movie) {
            movies.push(ko.observable(new filmSite.MovieInfoViewModel(movie.title, movie.releaseYear, movie.rating)));
        });

        loadMovies();

        return {
            movies: movies,
            viewRelatedTitles: viewRelatedTitles
        }
    };

})($, ko.postbox, window.filmSite = window.filmSite || {});