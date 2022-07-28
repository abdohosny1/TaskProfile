////angular.module("myApp").factory("characterFactory", function ($http) {
////    var getAll = [];
////    function getAllCharacter() {
////        return  $http.get('https://localhost:44391/api/ProfileExper');
////    }

////    return {
////        getAll: getAllCharacter

////    }, addProduct: function(obj) {
////        getAll.push(obj);
////    }
////});


//angular.module("myApp").factory("characterFactory", function ($http) {

//    function getAllCharacter() {
//        // $http({
//        //     method:'Get',
//        //     url:'https://www.breakingbadapi.com/api/characters'})
//        return $http.get('https://localhost:44391/api/ProfileExper');
//    }

//    return {
//        getAll: getAllCharacter
//    }
//});


//$(document).ready(function () {
//    //$('#progress').show();

//    //getAlldata();
//    //getAllProfileExperience();
//});

//function getAllProfileExperience() {

//    $.ajax({
//        url: 'https://localhost:44391/api/ProfileExper',
//        method: "Get",
//        success: function (data) {
//            console.log(data);
//            $('#showcount').html(data);
//        },
//        errot: function () {
//            alert("Some thing with wrong");
//        }

//    });
//}