
/// <reference path="../../../scripts/angular.js" />
/// <reference path="../../../scripts/angular-route.js" />

var myApp = angular.module("myApp", ["ngRoute"]);
myApp.config(function ($routeProvider) {
    $routeProvider
        .when("/home", {
            templateUrl: "Templates/Home.html",
            controller: "HomeController"
        })
        .when("/courses", {
            templateUrl: "Templates/Courses.html",
            controller: "HomeController"
        })
        .when("/students", {
            templateUrl: "Templates/Students.html",
            controller: "HomeController"
        });
    $locationProvider.html5Mode(true);
});
myApp.controller("HomeController", function ($scope) {
    $scope.message = "Home Page";
});