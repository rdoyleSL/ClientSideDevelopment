(function (filmSite) {
    "use strict";

    filmSite.loggingService = (function () {
        
        var log = function (message) {
            console.log(message);
        }

        var error = function (message) {
            console.log(message);
        }

        return {
            log: log,
            error: error
        }
    })();

})(window.filmSite = window.filmSite || {});