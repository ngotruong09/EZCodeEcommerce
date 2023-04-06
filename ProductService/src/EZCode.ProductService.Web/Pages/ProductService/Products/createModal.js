abp.modals.createModal = function () {

    function initModal(modalManager, args) {
        var $modal = modalManager.getModal();
        console.log('initialized the modal...');
    };

    return {
        initModal: initModal
    };
};