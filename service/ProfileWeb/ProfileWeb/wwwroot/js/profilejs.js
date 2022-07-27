
var app = angular.module('myApp', []);


app.controller('myCtrl', function ($scope, $http) {

    $scope.listTitle = [];
    $scope.listcompany = [];

    $scope.nameMonthstart = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
    console.log($scope.nameMonthstart);
    //get years
    var year = new Date().getFullYear();
    var range = [];
    range.push(year);
    for (var i = 1; i < 30; i++) {
        range.push(year - i);
    }
    $scope.years = range;
    console.log($scope.years);


    var getTitle = function () {
        $http({
            method: "GET",
            url: "https://localhost:44391/api/Titles"
        }).then(function mySuccess(response) {

            angular.forEach(response.data, function (title) {
                $scope.listTitle.push(title.name);

            });
            console.log("data =" + $scope.listTitle);


        }, function myError(response) {
            // $scope.myWelcome = response.statusText;
        });
    }

    var getCompany = function () {
        $http({
            method: "GET",
            url: "https://localhost:44391/api/Companies"
        }).then(function mySuccess(response) {

            angular.forEach(response.data, function (title) {
                $scope.listcompany.push(title.name);

            });
            console.log("data =" + $scope.listcompany);


        }, function myError(response) {
            // $scope.myWelcome = response.statusText;
        });
    }
    getTitle();
    getCompany();

    $scope.complete = function (string) {
        var output = [];
        angular.forEach($scope.listTitle, function (titlee) {
                if (titlee.toLowerCase().indexOf(string.toLowerCase()) >= 0) {
                    output.push(titlee);
                }
        });
        $scope.filterTitle = output;
    }

    $scope.completeCompany = function (string) {
        var output = [];
        angular.forEach($scope.listcompany, function (title) {
            if (title.toLowerCase().indexOf(string.toLowerCase()) >= 0) {
                output.push(title);
            }
        });
        $scope.filterCompany = output;
    }

    $scope.fillTextBox = function (string) {
        $scope.exp.Title = string;
        $scope.hidethis = true;

    }

    $scope.fillTextBoxCompany = function (string) {
        $scope.exp.CompanyName = string;
        $scope.hidecompany = true;

    }



    var init = function () {


        $http({
            method: "GET",
            url: "https://localhost:44391/api/ProfileExper"
        }).then(function mySuccess(response) {
            $scope.myWelcome = response.data;
            console.log("data =" + response);
        }, function myError(response) {
            $scope.myWelcome = response.statusText;
        });
    }
    init();
    $scope.hideUpdate = function () {

        $('#updatesumbit').hide();
        $('#addsumbit').show();
        emptyForm()

    }
  
    $scope.deleteFunction = function (id) {
        console.log(id);
        var check = confirm("Are You Delete You Experience ?")
        if (check) {

            $http({
                method: "Delete",
                url: "https://localhost:44391/api/ProfileExper/" + id
            }).then(function mySuccess(response) {
                console.log("Done");

                init();

            }, function myError(response) {
                $scope.myWelcome = response.statusText;
            });
        }

    }

  
    $scope.UpdateFunction = function (item) {
        $('#updatesumbit').show();
        $('#addsumbit').hide();

        console.log(item);
        //$scope.exp = {}
        console.log($scope.Title);
        $scope.exp = {
            branch: item.branch,
            companyName: item.companyName,
            Description: item.description,
            current: item.current,
            description: item.description,
            skill: item.skill,
            title: item.title,
            id: item.id,
            profileId: 1,
        }


        $scope.exp.Title = item.title
        $scope.exp.CompanyName = item.companyName
        $scope.exp.Branch = item.branch
        $scope.exp.Description = item.description
        $scope.exp.Skill = item.skill
        $scope.exp.Current = item.current

        var date = new Date(item.startDate);
        var dateend = new Date(item.endDate);


        yearstart = 0;
        lengthYears = $scope.years.length;
        for (var i = 0; i <= lengthYears; i++) {
            if ($scope.years[i] === date.getFullYear()) {
                yearstart=i
            }
        }

        yearend = 0;
        for (var i = 0; i <= lengthYears; i++) {
            if ($scope.years[i] === dateend.getFullYear()) {
                yearend = i
            }
        }

        $scope.exp.startMonth = (date.getMonth())
        $scope.exp.endMonth = (dateend.getMonth())

        $scope.exp.startYear = yearstart
        $scope.exp.endYear = yearend

        console.log(dateend.getMonth()+1)
        console.log(dateend.getFullYear())
        console.log(yearstart)









    }
    $scope.submitUpdateExpercincerForm = function (exp) {
        console.log(exp)

        $scope.GetStartDate = $scope.getTime(exp.startMonth, exp.startYear) + "/" + "1" + "/" + exp.startYear
        $scope.GetendDate = $scope.getTime(exp.endMonth, exp.startYear) + "/" + "1" + "/" + exp.endYear
        //console.log($scope.GetStartDate);


        $scope.newDateStart = new Date($scope.GetStartDate);
        $scope.newDateend = new Date($scope.GetendDate);

        $scope.sendObj = {
            profileId: 1,
            branch: exp.Branch,
            companyName: exp.CompanyName,
            description: exp.Description,
            title: exp.Title,
            skill: exp.Skill,
            current: exp.Current,
            startDate: $scope.newDateStart,
            endDate: $scope.newDateend
        }
        $http({
            method: "put",
            url: "https://localhost:44391/api/ProfileExper/" + exp.id,
            data: $scope.sendObj
        }).then(function mySuccess(response) {
            console.log("Done");

            init();
            $('#myModal').modal('hide');


        }, function myError(response) {
            $scope.myWelcome = response.statusText;
        });
    }



    $scope.getTime = function getMonthFromString(mon, year) {
        return new Date(Date.parse(mon + " 1 " + year)).getMonth() + 1
    }

   var emptyForm = function () {
        $scope.exp.Title = "";
        $scope.exp.CompanyName = "";
        $scope.exp.Branch = "";
        $scope.exp.Description = "";
        $scope.exp.Skill = false
        $scope.exp.Current = false
       $scope.exp.startMonth = ""
       $scope.exp.startYear = ""
       $scope.exp.endMonth = ""
       $scope.exp.endYear = -""
    }

    $scope.AddSumbit = function (exp) {
      

        $scope.GetStartDate = $scope.getTime(exp.startMonth, exp.startYear) + "/" + "1" +"/"+ exp.startYear
        $scope.GetendDate = $scope.getTime(exp.endMonth, exp.startYear) + "/" + "1" + "/" + exp.endYear
        //console.log($scope.GetStartDate);

      
        $scope.newDateStart = new Date($scope.GetStartDate);
        $scope.newDateend = new Date($scope.GetendDate);

   


        $scope.sendObj = {
            profileId: 1,
            branch: exp.Branch,
            companyName: exp.CompanyName,
            description: exp.Description,
            title: exp.Title,
            skill: exp.Skill,
            current: exp.Current,
            startDate: $scope.newDateStart,
            endDate: $scope.newDateend
        }
        console.log($scope.sendObj);
      

        //if (!($scope.Title === "")) {

            $http({
                method: "POST",
                data: $scope.sendObj,
                url: "https://localhost:44391/api/ProfileExper"
                }).then(function mySuccess(response) {
                init();
                $('#myModal').modal('hide');
                    emptyForm()


              }, function myError(response) {
                $scope.myWelcome = response.statusText;
            });
        

  


    };

});




