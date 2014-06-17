(function (filmSite) {
    "use strict";

    filmSite.MovieInfoViewModel = (function (title, year, rating) {
        title = ko.observable(title || null);
        year = ko.observable(year || null);
        rating = ko.observable(rating || null);

        return {
            title: title,
            year: year,
            rating: rating
        }
    });

})(window.filmSite = window.filmSite || {});