
//var app = angular.module('myApp', []);


// app.controller('myCtrl', function ($scope, $http) {

//     $scope.alz="abdo"
//     $scope.listTitle = [];
//     $scope.listcompany = [];
//     $scope.nameMonthstart = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
//     $scope.names = ["Java", "PHP", ".Net", "AngularJS", "C/C++"];
//     console.log(nameMonthstart);


//     var getTitle = function () {
//         $http({
//             method: "GET",
//             url: "https://localhost:44391/api/Titles"
//         }).then(function mySuccess(response) {

//             angular.forEach(response.data, function (title) {
//                 $scope.listTitle.push(title.name);

//             });
//             console.log("data =" + $scope.listTitle);

   
//         }, function myError(response) {
//            // $scope.myWelcome = response.statusText;
//         });
//     }

//     var getCompany = function () {
//         $http({
//             method: "GET",
//             url: "https://localhost:44391/api/Companies"
//         }).then(function mySuccess(response) {

//             angular.forEach(response.data, function (title) {
//                 $scope.listcompany.push(title.name);

//             });
//             console.log("data =" + $scope.listTitle);


//         }, function myError(response) {
//             // $scope.myWelcome = response.statusText;
//         });
//     }
//     getTitle();
//     getCompany();

//     $scope.complete = function (string) {
//         var output = [];
//         angular.forEach($scope.listTitle, function (title) {
//             if (title.toLowerCase().indexOf(string.toLowerCase()) >= 0)
//             {
//                 output.push(title);
//             }
//         });
//         $scope.filterTitle = output;
//     }

//     $scope.completeCompany = function (string) {
//         var output = [];
//         angular.forEach($scope.listcompany, function (title) {
//             if (title.toLowerCase().indexOf(string.toLowerCase()) >= 0) {
//                 output.push(title);
//             }
//         });
//         $scope.filterCompany = output;
//     }

//     $scope.fillTextBox = function (string) {
//         $scope.exp.Title = string;
//         $scope.hidethis = true;

//     }

//     $scope.fillTextBoxCompany = function (string) {
//         $scope.exp.CompanyName = string;
//         $scope.hidecompany = true;

//     }

    

//     var init = function () {
     

//        $http({
//            method: "GET",
//            url: "https://localhost:44391/api/ProfileExper"
//           }).then(function mySuccess(response) {
//            $scope.myWelcome = response.data;
//            console.log("data =" + response);
//        }, function myError(response) {
//            $scope.myWelcome = response.statusText;
//       });
//     }
//     init();
//     $scope.hideUpdate = function () {
      
//         $('#updatesumbit').hide();
//         $('#addsumbit').show();
//     }
//    $scope.deleteFunction = function (id) {
//        console.log(id);
//        var check = confirm("Are You Delete You Experience ?")
//        if (check) {

//            $http({
//                method: "Delete",
//                url: "https://localhost:44391/api/ProfileExper/"+id
//            }).then(function mySuccess(response) {
//                console.log("Done");

//                init();

//            }, function myError(response) {
//                $scope.myWelcome = response.statusText;
//            });
//        }

//     }

//     $scope.exp = {
//         profileId: 1,
//         branch: "",
//         companyName:"",
//         description:"",
//         skill:"",
//         skill:false,
//         current: false,
//         title:""

//     };
//     $scope.UpdateFunction = function (item) {
//         $('#updatesumbit').show();
//         $('#addsumbit').hide();

//         console.log(item);
//         //$scope.exp = {}
//         console.log($scope.Title);
//         $scope.exp = {
//             branch: item.branch,
//             companyName: item.companyName,
//             Description: item.description,
//             current: item.current,
//             description: item.description,
//             skill: item.skill,
//             title: item.title,
//             id:item.id,
//             profileId: 1,
//         }
       

//         $scope.exp.Title = item.title
//         $scope.exp.CompanyName = item.companyName
//         $scope.exp.Branch = item.branch
//         $scope.exp.Description = item.description
//         $scope.exp.Skill = item.skill
//         $scope.exp.Current = item.current
       

        

        

          
         

//     }
//     $scope.submitUpdateExpercincerForm = function (exp) {
//         console.log(exp)
//         $http({
//             method: "put",
//             url: "https://localhost:44391/api/ProfileExper/" + exp.id,
//             data: exp
//         }).then(function mySuccess(response) {
//             console.log("Done");

//             init();
//             $('#myModal').modal('hide');

           
//         }, function myError(response) {
//             $scope.myWelcome = response.statusText;
//         });
//     }
     

   


//    $scope.submitExpercincerForm = function (exp) {
//        console.log($scope.student);
//        console.log($scope.exp);

       

//        $http({
//            method: "POST",
//            data: exp,
//            url: "https://localhost:44391/api/ProfileExper"
//        }).then(function mySuccess(response) {

//              init();
//              $('#myModal').modal('hide');
//            $scope.exp.Title = "";
//            $scope.exp.CompanyName = "";
//            $scope.exp.Branch = "";
//            $scope.exp.Description = "";
//            $scope.exp.Skill = false
//            $scope.exp.Current = false

//             },   function myError(response) {
//              $scope.myWelcome = response.statusText;
//          });


//     };

//});




