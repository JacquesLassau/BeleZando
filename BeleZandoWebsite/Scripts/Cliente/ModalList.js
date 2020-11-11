function FnTxtPesquisarCliente() {

    event.preventDefault();    

    document.getElementById("NomeCliente").value = null;

    var item = document.getElementById("CodigoCliente").value;

    if (item == "")
        item = 0;

    $.get("/Cliente/SelecionarCliente?codigoCliente=" + item, function (data) {
          
        if (data.EmailCliente != null) {
            $(function () {
                $("#NomeCliente").val(data.NomeCliente);                
                $("#listarCliente").modal("hide");
            });
        }
    });
}

function FnBtnPesquisarCliente() {

    $("#CodigoCliente").val(null);  
    $("#NomeCliente").val(null);    
     
}