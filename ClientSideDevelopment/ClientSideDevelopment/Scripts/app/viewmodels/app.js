(function ($, postbox, filmSite) {
    "use strict";

    filmSite.AppViewModel = function() {
        var favouritesViewModel = ko.observable(new filmSite.FavouritesViewModel()),
            addMovieViewModel = ko.observable(new filmSite.AddMovieViewModel()),
            movieDetailsViewModel = ko.observable(new filmSite.MovieDetailViewModel()),
            selectedMovie = ko.observable();

        return {
            addMovieViewModel: addMovieViewModel,
            favouritesViewModel: favouritesViewModel,
            movieDetailsViewModel: movieDetailsViewModel,
            selectedMovie: selectedMovie
        }
    };

})($, ko.postbox, window.filmSite = window.filmSite || {});