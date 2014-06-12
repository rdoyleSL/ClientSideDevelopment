(function (filmSite) {
    "use strict";

    filmSite.RelatedMovieInfoViewModel = (function (poster, title, year, audienceScore, criticsScore) {
        poster = ko.observable(poster);
        title = ko.observable(title);
        year = ko.observable(year);
        audienceScore = ko.observable(audienceScore);
        criticsScore = ko.observable(criticsScore);

        return {
            poster: poster,
            title: title,
            year: year,
            audienceScore: audienceScore,
            criticsScore: criticsScore
        }
    });

})(window.filmSite = window.filmSite || {});