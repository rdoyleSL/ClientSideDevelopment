(function ($, postbox, filmSite) {
    "use strict";

    filmSite.AddMovieViewModel = function () {

        var title = ko.observable("");
        var releaseYear = ko.observable();
        var selectedRating = ko.observable();
        var ratings = ko.observableArray([ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ]);

        function resetForm() {
            title("");
            releaseYear(null);
            selectedRating(ratings()[0]);
        }

        function addMovie() {
            
            var movie = {
                title: title(),
                releaseYear: releaseYear(),
                rating: selectedRating()
            };

            filmSite.favouriteMovieService.addMovie(
                movie,
                function() {
                    postbox.publish("movieAdded", movie);
                    resetForm();
                },
                function() {
                    filmSite.loggingService.log("There was an error adding the movie.");
                }
            );
        };        

        return {
            title: title,
            releaseYear: releaseYear,
            selectedRating: selectedRating,
            ratings: ratings,
            addMovie: addMovie
        }
    }

})($, ko.postbox, window.filmSite = window.filmSite || {});