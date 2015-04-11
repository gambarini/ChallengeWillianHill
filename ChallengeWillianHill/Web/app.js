"use strict";

var app = angular.module('app', []);
app.controller('controller', function($scope, $http) {
    $scope.test= "John";
    
    
    $http.get('/Customer').success(function(data){
        $scope.customers = data;
    });
    
    $scope.dangerRate = function(rate){
        return rate > 60?'danger':'';
    }
                        
    
});


