function SelecionarAtendenteLinkModal(idAtendente) {

    event.preventDefault();
    var item = document.getElementById(idAtendente).value;

    $.get("/Atendente/SelecionarAtendente?codigoAtendente=" + item, function (data) {
        
        $("#NomeAtendente").val(data.NomeAtendente);         
        $("#listarAtendente").modal("hide");

    });



    document.getElementById("CodigoAtendente").value = item;
}