// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    //$('#progress').show();

    //getAlldata();
    getAllProfileExperience();
});

function getAllProfileExperience() {

    $.ajax({
        url: 'https://localhost:44391/api/ProfileExper',
        method: "Get",
        success: function (data) {
            console.log(data);
            $('#showcount').html(data);
        },
        errot: function () {
            alert("Some thing with wrong");
        }

    });
}

var app = angular.module('myApp', ['ui.bootstrap']);
app.controller('myCtrl', function ($scope, $http, $uibModal, ModalEditor) {
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

studentApp.controller("formController", function ($scope, $http) {

    //3. attach originalStudent model object
    $scope.originalStudent = {
        firstName: 'James',
        lastName: 'Bond',
        DoB: new Date('01/31/1980'),
        gender: 'male',
        trainingType: 'online',
        maths: false,
        physics: true,
        chemistry: true
    };

    //4. copy originalStudent to student. student will be bind to a form 
    $scope.student = angular.copy($scope.originalStudent);

    //5. create submitStudentForm() function. This will be called when user submits the form
    $scope.submitStudnetForm = function () {

        var onSuccess = function (data, status, headers, config) {
            alert('Experince saved successfully.');
        };

        var onError = function (data, status, headers, config) {
            alert('Error occured.');
        }

        $http.post('https://localhost:44391/api/ProfileExper', { student: $scope.student })
            .success(onSuccess)
            .error(onError);

    };

    //6. create resetForm() function. This will be called on Reset button click.  
    $scope.resetForm = function () {
        $scope.student = angular.copy($scope.OriginalStudent);
    };
});
app.controller('myApp', function mainController($scope, $uibModal, ModalEditor) {

    var vm = this;

    $scope.openModal = function () {

        console.log("button clicked")
        ModalEditor.openModal()

    }
})
