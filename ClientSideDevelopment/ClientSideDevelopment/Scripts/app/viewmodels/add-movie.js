(function ($, postbox, filmSite) {
    "use strict";

    filmSite.AddMovieViewModel = function () {        

        function addMovie() {
            
            var movie = {
                title: $("#movieTitle").val(),
                releaseYear: $("#releaseYear").val(),
                rating: $("#rating option:selected").val()
            };

            filmSite.favouriteMovieService.addMovie(
                movie,
                function(response) {
                    if (response.success === true) {
                        postbox.publish("movieAdded", movie);
                    }
                },
                function() {
                    alert('There was an error adding the movie.');
                }
            );
        };        

        return {
            addMovie: addMovie            
        }
    }

})($, ko.postbox, window.filmSite = window.filmSite || {});