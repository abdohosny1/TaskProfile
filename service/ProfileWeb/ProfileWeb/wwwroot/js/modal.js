//modal controller and service definitions
app.controller('ModalCtrl', ModalCtrl);
app.service('ModalEditor', ModalEditor);

function ModalEditor($http, $uibModal, $rootScope) {
    var service = {};
    service.openModal = openModal;

    function openModal() {

        $uibModal.open({
            templateUrl: 'modalTemplate.html',     //modal template
            controller: ['$uibModalInstance', '$rootScope', '$scope', ModalCtrl] // pass the controller associated with the modal

        });

    }

    return service;
}

function ModalCtrl($uibModalInstance, $rootScope, $scope) {
    //define functions used by the modal

    $scope.ok = function () {

        $uibModalInstance.close()
    }

    $scope.cancel = function () {

        $uibModalInstance.close()
    }

}