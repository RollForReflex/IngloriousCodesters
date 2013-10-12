var youBoost = angular.module('youBoost', []);

youBoost.controller('ProviderCtrl', ['$scope', function($scope){

    // Gets the providers from .NET Web API
    $scope.getProviders = function () {
        /*$http({
            method: "GET",
            url: "/v1/getAllProviders",

        }).then(function(res){
            $scope.providers = data;
        });*/
        alert("got into this method, dood");
    }

    // Call when controller starts
    $scope.init = function () {
        $scope.createMapOfProviders();
    }

    $scope.createMapOfProviders = function () {
        var map = new GMaps({
            div: '#providerMap',
            lat: '44.490257',
            lng: '-73.184143'
        });

        $scope.getProviders();

        for (var provider in $scope.providers) {
            GMaps.geocode({
                address: provider.address,
                callback: function (results, status) {
                    if(status == "OK"){
                        var latlng = results[0].geometry.location;
                        map.setCenter(latlng.lat(), latlng.lng());
                        map.addMarker({
                            lat: latlng.lat(),
                            lng: latlng.lng()
                        });
                    }
                }
            });
        };
    };

}]);