"use strict";

var app = angular.module('app', []);
app.controller('controller', function($scope, $http) {
    
    $http.get('/Customer').success(function(dataCustomers){
        $scope.customers = dataCustomers;

        $http.get('/Bet/Unsettle').success(function(dataBets){

        	$scope.bets = dataBets;

        });

    });

    $scope.dangerRate = function(rate){
        return rate > 60?'danger':'';
    }

    $scope.customerHighlight = function(customerId){
    	 var foundCustomer = $scope.customers.filter(function(item) {
    	 	return item.Id == customerId && item.WinRate > 60
    	 });

    	 return foundCustomer.length == 0 ? "" : "danger";
    }
                        
    
});


