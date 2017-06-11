StackApp.factory('StackAppSvc', ['$http', function ($http) {

    return {
        getAllQuries: function () {
            return $http.get(baseUrl + 'Stack').then(function (response) {
                return response.data;
            });
        },

        searchStackOverflow: function (key) {
            var config = {
                params: { searchKey: key },
                headers: { 'Accept': 'application/json' }
            };
            return $http.get(baseUrl + "Stack", config);
            
        }
    }
}]);