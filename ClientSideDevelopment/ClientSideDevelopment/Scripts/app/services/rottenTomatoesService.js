(function (filmSite) {
    "use strict";

    filmSite.rottenTomatoesService = (function () {

        var getMovieDetails = function (movieTitle, successCallback, errorCallback) {
            var url = "http://api.rottentomatoes.com/api/public/v1.0/movies.json?apikey=jvasufnuxk3mhhghbmcq9a2h&q=" + encodeURIComponent(movieTitle) + "&page_limit=1&callback=?";
            filmSite.httpService.get(url, successCallback, errorCallback, { dataType: "jsonp" });
        }        

        var getRelatedMovies = function (movieId, successCallback, errorCallback) {
            var url = "http://api.rottentomatoes.com/api/public/v1.0/movies/" + movieId + "/similar.json?apikey=jvasufnuxk3mhhghbmcq9a2h&callback=?";
            filmSite.httpService.get(url, successCallback, errorCallback, { dataType: "jsonp" });
        }

        return {
            getMovieDetails: getMovieDetails,
            getRelatedMovies: getRelatedMovies
        }
    })();

})(window.filmSite = window.filmSite || {});