(function ($, ko, postbox, filmSite) {
    "use strict";

    filmSite.MovieDetailViewModel = function () {
        var title = ko.observable(),
            releaseYear = ko.observable(),
            rating = ko.observable();

        postbox.subscribe("movieSelected", function (movieTitle) {
            title(movieTitle);
            $('#related-titles').foundation('reveal', 'open');
        });

        return {
            title: title,
            releaseYear: releaseYear,
            rating: rating
        }
    };

})($, ko, ko.postbox, window.filmSite = window.filmSite || {});