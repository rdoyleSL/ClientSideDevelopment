(function ($, filmSite) {
    "use strict";

    filmSite.AppViewModel = function() {
        var favouritesViewModel = ko.observable(new filmSite.FavouritesViewModel()),
            addMovieViewModel = ko.observable(new filmSite.AddMovieViewModel()),
            selectedMovie = ko.observable();

        return {
            addMovieViewModel: addMovieViewModel,
            favouritesViewModel: favouritesViewModel,            
            selectedMovie: selectedMovie
        }
    };

})($, window.filmSite = window.filmSite || {});