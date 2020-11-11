function SelecionarClienteLinkModal(idCliente) {

    event.preventDefault();
    var item = document.getElementById(idCliente).value;

    $.get("/Cliente/SelecionarCliente?codigoCliente=" + item, function (response) {

        parent.postMessage(response);

    });    
}