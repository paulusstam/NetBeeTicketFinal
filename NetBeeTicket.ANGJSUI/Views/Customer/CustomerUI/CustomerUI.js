NetBeeTicketAPP.factory("CustomerUIService", function ($http) {
    customeruiObj = {};

    customeruiObj.getAll = function () {
        var ctms;

        ctms = $http({ method: "Get", url: "http://localhost:52144/api/Customer" }).
            then(function (response) {
                return response.data;

            });
        return ctms;

    };

    customeruiObj.createCustomer = function (emp) {
        var Ctm;

        Ctm = $http({ method: "Post", url: "http://localhost:52144/api/Customer", data: emp }).
            then(function (response) {
                return response.data;
            }, function (error) {
                return error.data;

            });
        return Ctm;

    };

    return customeruiObj;

});



NetBeeTicketAPP.controller("customerUIController", function ($scope, CustomerUIService, utilityService) {
    $scope.message = "Customer CP";

    CustomerUIService.getAll().then(function (result) {
        $scope.ctms = result;
    });

    $scope.Sort = function (col) {
        $scope.key = col;
        $scope.AscOrDesc = !$scope.AscOrDesc;
    };
    $scope.createCustomer = function (Ctm) {
        Ctm.Password = utilityService.randomPassword();
        CustomerUIService.createCustomer(Ctm).then(function (result) {
            $scope.message = "You have successfully created the Customer with ID: " + result.CustomerId;
            $scope.Flg = true;
            CustomerUIService.getAll().then(function (result) {
                $scope.ctms = result;
        });

            utilityService.myAlert();
        });
    };
});