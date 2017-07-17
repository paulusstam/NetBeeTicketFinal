$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("active");
});

var NetBeeTicketAPP = angular.module("NetBeeTicketAPP", ["ngRoute"]);

NetBeeTicketAPP.config(function ($routeProvider, $httpProvider) {
    $routeProvider.when("/Home", { templateUrl: "Views/Shared/Home/Home.html" });
    $routeProvider.when("/Login", { templateUrl: "Views/Shared/Login/Login.html" });
    $routeProvider.when("/Logout", {});
    $routeProvider.when("/PasswordRecovery", { templateUrl: "Views/Shared/PasswordRecovery/PasswordRecovery.html" });
    $routeProvider.when("CustomerUI", { templateUrl: "Views/Customer/CustomerUI/CustomerUI.html" });
    $routeProvider.when("/CustomerProfile", { templateUrl: "Views/Customer/CustomerUpdate/CustomerUpdate.html" });
    $routeProvider.otherwise({ redirectTo: "/Home" });
});