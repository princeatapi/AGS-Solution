StackApp.controller('StackSearch', ['$scope', 'StackAppSvc', function ($scope, StackAppSvc) {


    $scope.searchKey = "";
    $scope.searchResults = [];
    $scope.topSearches = [];

    $scope.search = function () {

        StackAppSvc.searchStackOverflow($scope.searchKey).then(function (response) {

            console.log(response.data);
            $scope.searchResults = response.data;

        });

    }

    $scope.refresh = function () {

        StackAppSvc.getAllQuries().then(function (data) {
            $scope.topSearches = data;
        });
    }



    StackAppSvc.getAllQuries().then(function (data) {

        $scope.topSearches = data;
    });

}]);