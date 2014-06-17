(function (filmSite) {
    "use strict";

    filmSite.httpService = (function () {
    
        var getProperty = function(object, propertyName, defaultValue) {
            if (object === undefined || object === null) {
                return defaultValue;
            }

            if (propertyName === undefined || propertyName === null) {
                return defaultValue;
            }

            return object[propertyName] || defaultValue;
        }

        var globalSuccessHandler = function (url) {
            filmSite.loggingService.log("Ajax success (" + url + ")");
        }

        var globalErrorHandler = function (url, xhr) {
            var response = JSON.parse(xhr.responseText);
            filmSite.loggingService.error("Ajax error (" + url + "): " + response.errorMessage);
        }

        var ajax = function (url, type, data, successCallback, errorCallback, options) {
            var success = successCallback || null;
            var error = errorCallback || null;
            var opts = options || null;

            $.ajax({
                url: url,
                type: type,
                contentType: getProperty(opts, "contentType", "application/json"),
                dataType: getProperty(opts, "dataType", "json"),
                data: data == null ? null : JSON.stringify(data),
                success: function (response) {
                    globalSuccessHandler(url, response);
                    if (success !== null) {
                        success(response);
                    }
                },
                error: function (xhr, status, errorThrown) {
                    globalErrorHandler(url, xhr, status, errorThrown);
                    if (error != null) {
                        error(xhr, status, errorThrown);
                    }
                }
            });
        }

        var get = function (url, successCallback, errorCallback, options) {
            ajax(url, "GET", null, successCallback, errorCallback, options);
        }
 
        var post = function (url, data, successCallback, errorCallback, options) {
            ajax(url, "POST", data, successCallback, errorCallback, options);
        }

        return {
            get: get,
            post: post
        }
    })();

})(window.filmSite = window.filmSite || {});