(function (filmSite) {
    "use strict";

    filmSite.MovieViewModel = (function (id, title, criticsConsensus) {
        id = ko.observable(id || null);
        title = ko.observable(title || null);
        criticsConsensus = ko.observable(criticsConsensus || null);

        var relatedTitles = ko.observableArray([]);

        function loadRelatedTitles() {
            if (id() === null) {
                return;
            }

            filmSite.rottenTomatoesService.getRelatedMovies(
                id(),
                function(response) {
                    relatedTitles.removeAll();

                    if (response.movies.length === 0) {
                        return;
                    }

                    for (var i = 0; i < response.movies.length; i++) {
                        var movie = response.movies[i];
                        relatedTitles.push(new filmSite.RelatedMovieInfoViewModel(
                                movie.posters.thumbnail,
                                movie.title,
                                movie.year,
                                movie.ratings.audience_score,
                                movie.ratings.critics_score
                        ));
                    }
                },
                function() {
                    alert("There was an error retrieving related movies.");
                }
            );
        }

        loadRelatedTitles();

        return {
            id: id,
            title: title,
            criticsConsensus: criticsConsensus,
            relatedTitles: relatedTitles
        }
    });

})(window.filmSite = window.filmSite || {});