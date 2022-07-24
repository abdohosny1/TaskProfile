// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



var app = angular.module('myApp', []);


app.controller('myCtrl', function ($scope, $http) {


    //characterFactory.getAll()
    //    .then(function (data) {
    //        $scope.mess = "hello";
    //        $scope.myWelcome = data.data;

    //    });
    $http({
        method: "GET",
        url: "https://localhost:44391/api/ProfileExper"
    }).then(function mySuccess(response) {
        $scope.myWelcome = response.data;
        console.log("data ="+response);
    }, function myError(response) {
        $scope.myWelcome = response.statusText;
    });

});

app.controller("experController", function ($scope, $http) {

 
    $scope.exp = {
        profileId:1,
    };


    //5. create submitStudentForm() function. This will be called when user submits the form
    $scope.submitExpercincerForm = function () {
        console.log($scope.student);
        console.log($scope.exp);

        $http({
            method: "POST",
            data: $scope.exp,
            url: "https://localhost:44391/api/ProfileExper"
        }).then(function mySuccess(response) {

       
        }, function myError(response) {
            $scope.myWelcome = response.statusText;
        });


    };
});


