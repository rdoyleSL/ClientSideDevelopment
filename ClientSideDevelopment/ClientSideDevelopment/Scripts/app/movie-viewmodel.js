(function (filmSite) {
    "use strict";

    filmSite.MovieViewModel = (function (title, year, rating) {
        this.title = ko.observable(title);
        this.year = ko.observable(year);
        this.rating = ko.observable(rating);
        
        return {
            title: title,
            year: year,
            rating: rating
        }
    });

})(window.filmSite = window.filmSite || {});