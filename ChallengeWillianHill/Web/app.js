"use strict";

var app = angular.module('app', []);
app.controller('controller', function($scope, $http) {
    $scope.test= "John";
    
    
    $http.get('/Customer').success(function(data){
        $scope.customers = data;
    });

    $http.get('/Bet/Unsettle').success(function(data){
        $scope.bets = data;
    });
    
    $scope.dangerRate = function(rate){
        return rate > 60?'danger':'';
    }
                        
    
});


