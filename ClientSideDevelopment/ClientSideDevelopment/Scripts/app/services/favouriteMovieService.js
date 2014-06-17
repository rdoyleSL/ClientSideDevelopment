(function ($, postbox, filmSite) {
    "use strict";

    filmSite.favouriteMovieService = (function () {        

        var getMovies = function(successCallback, errorCallback) {
            var success = successCallback || null;
            var error = errorCallback || null;
            $.ajax({
                url: "/Home/GetMovies",
                type: "GET",
                dataType: "json",
                success: function (response) {
                    if (success !== null) {
                        success(response);
                    }
                },
                error: function(xhr, status, errorThrown) {
                    if (error !== null) {
                        error(xhr, status, errorThrown);
                    }
                }
            });
        };

        var addMovie = function(movie, successCallback, errorCallback) {
            var success = successCallback || null;
            var error = errorCallback || null;
            $.ajax({
                url: "/Home/AddNewMovie",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(movie),
                dataType: "json",
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

        return {
            getMovies: getMovies,
            addMovie: addMovie
        }
    })();

})($, ko.postbox, window.filmSite = window.filmSite || {});