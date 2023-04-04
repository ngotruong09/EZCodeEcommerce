var l = abp.localization.getResource("ProductService");
var productService = window.eZCode.productService.products.product;
var createModal = new abp.ModalManager({
    viewUrl: abp.appPath + 'ProductService/Products/CreateModal',
    scriptUrl: '/Pages/ProductService/Products/createModal.js?_v=1', //Lazy Load URL
    modalClass: 'createModal'
});
var editModal = new abp.ModalManager({
    viewUrl: abp.appPath + "ProductService/Products/EditModal",
    scriptUrl: "/Pages/ProductService/Products/editModal.js",
    modalClass: "editModal"
});

$(function () {
    //SetDatatable();
    var dataTable = SetGrid();

    $("#btnCreate").click(function (e) {
        e.preventDefault();
        createModal.open();
    });
    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    editModal.onResult(function () {
        dataTable.ajax.reload();
    });
});

function SetGrid() {
   return $('#ProductsTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            ajax: abp.libs.datatables.createAjax(productService.getList),
            columnDefs: [
                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open(
                                            {
                                                id: data.record.id
                                            }
                                        );
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    action: function (data) {
                                        productService.delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l("Xoa Thanh Cong"));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Description'),
                    data: "description"
                },
                {
                    title: l('Price'),
                    data: "price"
                }
            ]
        })
    );
}


function Edit(data) {
    console.log(data.record.id);
}

function Delete(data) {
    console.log(data.record.id);
}

function getFilter() {
    return {
        filterText: "",
        name: "",
        description: "",
        priceMin: null,
        priceMax: null
    };
};