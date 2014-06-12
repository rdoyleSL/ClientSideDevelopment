(function (filmSite) {
    "use strict";

    filmSite.MovieViewModel = (function (title, year, rating) {
        title = ko.observable(title);
        year = ko.observable(year);
        rating = ko.observable(rating);

        function viewRelatedTitles() {
            $("#critics-concensus").text("");
            $("#related-titles-table tbody").empty();
            $.ajax({
                url: "http://api.rottentomatoes.com/api/public/v1.0/movies.json?apikey=jvasufnuxk3mhhghbmcq9a2h&q=" + encodeURIComponent(title()) + "&page_limit=1&callback=?",
                type: "GET",
                dataType: "jsonp",
                success: function (response) {
                    $("#critics-concensus").text(response.movies[0].critics_consensus);
                    var movieId = response.movies[0].id;

                    // Get related titles:
                    $.ajax({
                        url: "http://api.rottentomatoes.com/api/public/v1.0/movies/" + movieId + "/similar.json?apikey=jvasufnuxk3mhhghbmcq9a2h&callback=?",
                        type: "GET",
                        dataType: "jsonp",
                        success: function (related) {               
                            for (var i = 0; i < related.movies.length; i++) {
                                var movie = related.movies[i];
                                $("#related-titles-table").append("<tr><td><img class=\"th radius\" src=\"" + movie.posters.thumbnail + "\"></img></td><td>" + movie.title + "</td><td>" + movie.year + "</td><td>" + movie.ratings.audience_score + "%</td><td>" + movie.ratings.critics_score + "%</td></tr>");
                            }
                        },
                        error: function (xhr, status, error) {
                            alert(status);
                        }
                    });

                },
                error: function (xhr, status, error) {
                    alert(status);
                }
            });
        }

        return {
            title: title,
            year: year,
            rating: rating,
            viewRelatedTitles: viewRelatedTitles
        }
    });

})(window.filmSite = window.filmSite || {});