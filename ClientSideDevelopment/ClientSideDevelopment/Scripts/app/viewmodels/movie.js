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

            $.ajax({
                url: "http://api.rottentomatoes.com/api/public/v1.0/movies/" + id() + "/similar.json?apikey=jvasufnuxk3mhhghbmcq9a2h&callback=?",
                type: "GET",
                dataType: "jsonp",
                success: function (related) {
                    relatedTitles.removeAll();
                    for (var i = 0; i < related.movies.length; i++) {
                        var movie = related.movies[i];
                        relatedTitles.push(new filmSite.RelatedMovieInfoViewModel(
                                movie.posters.thumbnail,
                                movie.title,
                                movie.year,
                                movie.ratings.audience_score,
                                movie.ratings.critics_score
                            ));

                        //$("#related-titles-table").append("<tr><td><img class=\"th radius\" src=\"" + movie.posters.thumbnail + "\"></img></td><td>" + movie.title + "</td><td>" + movie.year + "</td><td>" + movie.ratings.audience_score + "%</td><td>" + movie.ratings.critics_score + "%</td></tr>");
                    }
                },
                error: function (xhr, status, error) {
                    alert(status);
                }
            });
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