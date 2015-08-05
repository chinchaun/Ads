(function () {
    'use strict';

    var serviceId = 'pacienteService';
    angular.module('app').factory(serviceId,
            ['common', '$http', pacienteService]);

    function pacienteService(common, $http) {
        var $q = common.$q;

        var service = {
            getAll: getAll,
        };

        return service;

        function getAll() {

            var url = 'api/Paciente';

            return $http.get(url)
                        .success(function (response) {
                            if (response) {
                                return response;
                            }
                        });

        };

    };

})();