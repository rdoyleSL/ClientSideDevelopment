(function (filmSite) {
    "use strict";

    filmSite.favouriteMovieService = (function () {        

        var getMovies = function (successCallback, errorCallback) {
            filmSite.httpService.get("/Home/GetMovies", successCallback, errorCallback);            
        };

        var addMovie = function (movie, successCallback, errorCallback) {
            filmSite.httpService.post("/Home/AddNewMovie", movie, successCallback, errorCallback);
        }

        return {
            getMovies: getMovies,
            addMovie: addMovie
        }
    })();

})(window.filmSite = window.filmSite || {});