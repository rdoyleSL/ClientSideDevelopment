(function ($, ko, postbox, filmSite) {
    "use strict";

    filmSite.MovieDetailViewModel = function () {
        var movie = ko.observable(new filmSite.MovieViewModel());

        postbox.subscribe("movieSelected", function (movieTitle) {            
            loadMovieDetails(movieTitle);
        });

        function loadMovieDetails(movieTitle) {            
            $('#related-titles').foundation('reveal', 'open');
            filmSite.rottenTomatoesService.getMovieDetails(
                movieTitle,
                function (response) {
                    if (response.movies.length === 0) {
                        return;
                    }

                    var movieId = response.movies[0].id;
                    var criticsConsensus = response.movies[0].critics_consensus;

                    movie(new filmSite.MovieViewModel(movieId, movieTitle, criticsConsensus));
                },
                function() {
                    filmSite.loggingService.log("There was an error retrieving related movies.");
                }
            );
        }

        return {
            movie: movie
        }
    };

})($, ko, ko.postbox, window.filmSite = window.filmSite || {});