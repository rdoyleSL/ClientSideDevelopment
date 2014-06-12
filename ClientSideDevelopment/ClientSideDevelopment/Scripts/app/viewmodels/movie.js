(function (filmSite) {
    "use strict";

    filmSite.MovieViewModel = (function (id, title, criticsConsensus) {
        id = ko.observable(id);
        title = ko.observable(title);
        criticsConsensus = ko.observable(criticsConsensus);
        
        return {
            id: id,
            title: title,
            criticsConsensus: criticsConsensus
        }
    });

})(window.filmSite = window.filmSite || {});