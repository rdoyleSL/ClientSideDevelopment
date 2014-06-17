(function (filmSite) {
    "use strict";

    filmSite.rottenTomatoesService = (function () {

        var getMovieDetails = function (movieTitle, successCallback, errorCallback) {
            var success = successCallback || null;
            var error = errorCallback || null;
            $.ajax({
                url: "http://api.rottentomatoes.com/api/public/v1.0/movies.json?apikey=jvasufnuxk3mhhghbmcq9a2h&q=" + encodeURIComponent(movieTitle) + "&page_limit=1&callback=?",
                type: "GET",
                dataType: "jsonp",
                success: function (response) {
                    if (success !== null) {
                        success(response);
                    }
                },
                error: function (xhr, status, errorThrown) {
                    if (error !== null) {
                        error(xhr, status, errorThrown);
                    }
                }
            });
        }        

        var getRelatedMovies = function (movieId, successCallback, errorCallback) {
            var success = successCallback || null;
            var error = errorCallback || null;
            $.ajax({
                url: "http://api.rottentomatoes.com/api/public/v1.0/movies/" + movieId + "/similar.json?apikey=jvasufnuxk3mhhghbmcq9a2h&callback=?",
                type: "GET",
                dataType: "jsonp",
                success: function (response) {
                    if (success !== null) {
                        success(response);
                    }
                },
                error: function (xhr, status, errorThrown) {
                    if (error != null) {
                        error(xhr, status, errorThrown);
                    }
                }
            });
        }

        return {
            getMovieDetails: getMovieDetails,
            getRelatedMovies: getRelatedMovies
        }
    })();

})(window.filmSite = window.filmSite || {});