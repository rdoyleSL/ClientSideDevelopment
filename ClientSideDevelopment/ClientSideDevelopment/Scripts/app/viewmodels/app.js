(function ($, postbox, filmSite) {
    "use strict";

    filmSite.AppViewModel = function() {
        var favouritesViewModel = ko.observable(new filmSite.FavouritesViewModel(postbox)),
            addMovieViewModel = ko.observable(new filmSite.AddMovieViewModel(postbox)),
            selectedMovie = ko.observable();

        return {
            addMovieViewModel: addMovieViewModel,
            favouritesViewModel: favouritesViewModel,            
            selectedMovie: selectedMovie
        }
    };

})($, ko.postbox, window.filmSite = window.filmSite || {});