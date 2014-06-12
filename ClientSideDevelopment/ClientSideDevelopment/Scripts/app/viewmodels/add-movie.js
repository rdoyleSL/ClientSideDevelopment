(function ($, filmSite) {
    "use strict";

    filmSite.AddMovieViewModel = function () {

        var movieAdded = function() {};

        function addMovie() {

            var movie = {
                title: $("#movieTitle").val(),
                releaseYear: $("#releaseYear").val(),
                rating: $("#rating option:selected").val()
            };

            $.ajax({
                url: "/Home/AddNewMovie",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(movie),
                dataType: "json",
                success: function (response) {
                    if (response.success === true) {
                        movieAdded(new filmSite.MovieViewModel(movie.title, movie.releaseYear, movie.rating));
                    }
                },
                error: function (xhr, status, error) {
                    alert('There was an error adding the movie.');
                }
            });
        }

        return {
            addMovie: addMovie,
            movieAdded: movieAdded
        }
    }

})($, window.filmSite = window.filmSite || {});