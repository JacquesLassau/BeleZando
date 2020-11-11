function FnTxtPesquisarAtendente() {

    event.preventDefault();
    var item = document.getElementById("CodigoAtendente").value;

    if (item == "")
        item = 0;

    $.get("/Atendente/SelecionarAtendente?codigoAtendente=" + item, function (data) {

        if (data.EmailAtendente != null) {
            $(function () {
                $("#listarAtendente").modal("hide");
                $("#NomeAtendente").val(data.NomeAtendente);    
            });
        } 
    });
}

function FnBtnPesquisarAtendente() {

    document.getElementById("NomeAtendente").value = null;
    document.getElementById("CodigoAtendente").value = null;

}