(function ($, ko, postbox, filmSite) {
    "use strict";

    filmSite.MovieDetailViewModel = function () {
        var movie = ko.observable(new filmSite.MovieViewModel());

        postbox.subscribe("movieSelected", function (movieTitle) {            
            loadMovieDetails(movieTitle);
        });

        function loadMovieDetails(movieTitle) {            
            $('#related-titles').foundation('reveal', 'open');

            $.ajax({
                url: "http://api.rottentomatoes.com/api/public/v1.0/movies.json?apikey=jvasufnuxk3mhhghbmcq9a2h&q=" + encodeURIComponent(movieTitle) + "&page_limit=1&callback=?",
                type: "GET",
                dataType: "jsonp",
                success: function (response) {
                    var movieId = response.movies[0].id;
                    var criticsConsensus = response.movies[0].critics_consensus;
                    
                    movie(new filmSite.MovieViewModel(movieId, movieTitle, criticsConsensus));
                },
                error: function (xhr, status, error) {
                    alert(status);
                }
            });
        }

        return {
            movie: movie
        }
    };

})($, ko, ko.postbox, window.filmSite = window.filmSite || {});