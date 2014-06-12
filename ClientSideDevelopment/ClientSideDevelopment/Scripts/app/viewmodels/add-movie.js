(function ($, postbox, filmSite) {
    "use strict";

    filmSite.AddMovieViewModel = function () {        

        function addMovie() {

            var movie = {
                title: $("#movieTitle").val(),
                releaseYear: $("#releaseYear").val(),
                rating: $("#rating option:selected").val()
            };

            $.ajax({
                url: "/Home/AddNewMovie",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(movie),
                dataType: "json",
                success: function (response) {
                    if (response.success === true) {
                        postbox.publish("movieAdded", movie);
                    }
                },
                error: function (xhr, status, error) {
                    alert('There was an error adding the movie.');
                }
            });
        }

        return {
            addMovie: addMovie            
        }
    }

})($, ko.postbox, window.filmSite = window.filmSite || {});