(function ($, filmSite) {
    "use strict";

    filmSite.FilmSiteViewModel = function () {
        var movies = ko.observableArray([]);

        function loadMovies() {
            movies.removeAll();
            $.ajax({
                url: "/Home/GetMovies",
                type: "GET",
                dataType: "json",
                success: function (response) {
                    for (var i = 0; i < response.length; i++) {
                        var movie = response[i];
                        movies.push(ko.observable(new filmSite.MovieViewModel(movie.Title, movie.ReleaseYear, movie.Rating)));
                    }
                }
            });
        }

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
                        movies.push(ko.observable(new filmSite.MovieViewModel(movie.title, movie.releaseYear, movie.rating)));
                    }
                },
                error: function (xhr, status, error) {
                    alert('There was an error adding the movie.');
                }
            });            
        }

        loadMovies();

        return {
            movies: movies,
            addMovie: addMovie
        }
    };

})($, window.filmSite = window.filmSite || {});