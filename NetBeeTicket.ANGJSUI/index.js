$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("active");
});

var NetBeeTicketAPP = angular.module("NetBeeTicketAPP", ["ngRoute", 'angularUtils.directives.dirPagination']);

NetBeeTicketAPP.config(function ($routeProvider, $httpProvider) {
    $routeProvider.when("/Home", { templateUrl: "Views/Shared/Home/Home.html", controller:"homeController" });
    $routeProvider.when("/Login", { templateUrl: "Views/Shared/Login/Login.html", controller: "loginController" });
    $routeProvider.when("/Logout", {  });
    $routeProvider.when("/PasswordRecovery", { templateUrl: "Views/Shared/PasswordRecovery/PasswordRecovery.html", controller: "passwordRecoveryController" });
    $routeProvider.when("/CustomerUI", { templateUrl: "Views/Customer/CustomerUI/CustomerUI.html", controller: "customerUIController" });
    $routeProvider.when("/CustomerProfile", { templateUrl: "Views/Customer/CustomerUpdate/CustomerUpdate.html", controller: "customerUpdateController" });
    $routeProvider.otherwise({ redirectTo: "/Home" });
});

NetBeeTicketAPP.factory("utilityService", function () {
    utilityObj = {};

    utilityObj.randomPassword = function () {
        return Math.random().toString(36).substr(2, 5);
    };

    utilityObj.myAlert = function () {
        $("#alert").fadeTo(2000, 500).slideUp(1000, function () {
            $("#alert").slideUp(1000);

        });
    };

    return utilityObj;
});