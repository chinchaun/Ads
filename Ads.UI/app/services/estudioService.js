(function () {
    'use strict';

    var serviceId = 'estudioService';
    angular.module('app').factory(serviceId,
            ['common', '$http', estudioService]);

    function estudioService(common, $http) {
        var $q = common.$q;

        var service = {
            getAll: getAll,
        };

        return service;

        function getAll() {

            var url = 'api/Estudio';

            return $http.get(url)
                        .success(function (response) {
                            if (response) {
                                return response;
                            }
                        });

        };

    };

})();