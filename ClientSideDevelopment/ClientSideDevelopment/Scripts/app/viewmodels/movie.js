(function (filmSite) {
    "use strict";

    filmSite.MovieViewModel = (function (title, year, rating) {
        title = ko.observable(title);
        year = ko.observable(year);
        rating = ko.observable(rating);

        return {
            title: title,
            year: year,
            rating: rating            
        }
    });

})(window.filmSite = window.filmSite || {});