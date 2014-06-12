(function (filmSite) {
    "use strict";

    filmSite.FilmSiteViewModel = function () {
        var movies = ko.observableArray([]);

        function loadMovies() {
            movies.removeAll();
            movies.push(new filmSite.MovieViewModel('test', 1988, 8));
            movies.push(new filmSite.MovieViewModel('test2', 1990, 9));
        }        

        function addMovie(title, year, rating) {
            
        }

        loadMovies();

        return {
            movies: movies,
            addMovie: addMovie
        }
    };

})(window.filmSite = window.filmSite || {});