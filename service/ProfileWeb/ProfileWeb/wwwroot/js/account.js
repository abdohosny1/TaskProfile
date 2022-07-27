
var app = angular.module('myApp', []);


app.controller('myregister', function ($scope, $http, $window, $location) {


    $scope.register = function () {
        var senddata = {
            firstName: $scope.user.firstName,
            lastName: $scope.user.lastName,
            username: $scope.user.email,
            email: $scope.user.email,
            password: $scope.user.password
        }
        window.location = "#/\TaskProfile\service\ProfileWeb\ProfileWeb\Views\Account\Login.cshtml";
        $window.location.href = "#/\TaskProfile\service\ProfileWeb\ProfileWeb\Views\Account\Login.cshtml";
        $location.path("#/\TaskProfile\service\ProfileWeb\ProfileWeb\Views\Account\Login.cshtml");
        
       
        //$http({
        //    method: "POST",
        //    data: senddata,
        //    url: "https://localhost:44391/api/Auth/Register"
        //}).then(function mySuccess(response) {


        //    console.log("data =" + response.data);
         
        //    alert("done");


        //}, function myError(response) {
        //    // $scope.myWelcome = response.statusText;
        //});
    }

  

    
    

});


app.controller('loginControl', function ($scope, $http, $window, $location) {


    $scope.register = function () {
        //var senddata = {
        //    firstName: $scope.user.firstName,
        //    lastName: $scope.user.lastName,
        //    username: $scope.user.email,
        //    email: $scope.user.email,
        //    password: $scope.user.password
        //}
        //window.location = "#/Login.cshtml";
        //$window.location.href = "#/Login.cshtml";
        //$location.path("#/Login.cshtml");

        //$http({
        //    method: "POST",
        //    data: senddata,
        //    url: "https://localhost:44391/api/Auth/Register"
        //}).then(function mySuccess(response) {


        //    console.log("data =" + response.data);

        //    alert("done");


        //}, function myError(response) {
        //    // $scope.myWelcome = response.statusText;
        //});
    }






});




