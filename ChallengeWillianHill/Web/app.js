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

    $scope.stakeHighlight = function(customerId, stake){

    	var foundCustomerDanger = $scope.customers.filter(function(item) {
    	 	return item.Id == customerId && stake > (item.AverageBet*30);
    	 });	

    	 if (foundCustomerDanger.length != 0) return "danger";

    	 var foundCustomerWarning = $scope.customers.filter(function(item) {
    	 	return item.Id == customerId && stake > (item.AverageBet*10);
    	 });

    	 return foundCustomerWarning.length == 0 ? "" : "warning";
    }
                        
    
});


