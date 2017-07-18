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

    return customeruiObj;

});



NetBeeTicketAPP.controller("customerUIController", function ($scope, CustomerUIService) {
    $scope.message = "Customer CP";

    CustomerUIService.getAll().then(function (result) {
        $scope.ctms = result;
    });
});