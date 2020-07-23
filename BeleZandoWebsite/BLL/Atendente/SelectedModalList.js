function SelecionarAtendenteLinkModal(idAtendente) {
    event.preventDefault();
    var item = document.getElementById(idAtendente).value;

    $.get("/Atendente/SelecionarAtendente?codigoAtendente=" + item, function (response) {
        parent.postMessage(response);
    });
}