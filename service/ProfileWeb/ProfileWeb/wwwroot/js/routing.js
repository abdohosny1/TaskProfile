(function () {
    var mod = angular.module("myApp", ['ngRoute']);

    mod.config(function ($stateProvider, $locationProvider) {
        // funcProvider.setMess="Hello Abdo";
        $stateProvider.state('home', {
            URL: "/home",
            templateUrl: "home/Index",
            controller: "homeControl",

        })
           
            .state('register', {   //use queery string
                URL: "/register",
                templateUrl: "Account/Register",
                controller: "myregister",
            })
            .state('expericence', {   //use queery string
                URL: "/expericence",
                templateUrl: "profile/Index",
                controller: "myCtrl",
            })
            .state('login', {   //use queery string
                URL: "/login",
                templateUrl: "/Account/Login",
                controller: "loginControl",
            })
            



        // .otherwise({
        //     redirectTo: "/cplus"
        // });
        //  $locationProvider.html5Mode(
        //     {enabled:true,requireBase:false}
        //     );

    })



})()