function SelecionarClienteLinkModal(idCliente) {

    event.preventDefault();
    var item = document.getElementById(idCliente).value;

    $.get("/Cliente/SelecionarCliente?codigoCliente=" + item, function (data) {

        $("#NomeCliente").val(data.NomeCliente); 
        $("#listarCliente").modal("hide");

    });

    document.getElementById("CodigoCliente").value = item;
}