var StackApp = angular.module('StackApp', []);
var baseUrl = 'http://localhost:58807/api/';

StackApp.config(['$qProvider', function ($qProvider) {
    $qProvider.errorOnUnhandledRejections(false);
}]);

