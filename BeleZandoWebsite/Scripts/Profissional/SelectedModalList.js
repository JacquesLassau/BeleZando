function SelecionarProfissionalLinkModal(idProfissional) {

    event.preventDefault();
    var item = document.getElementById(idProfissional).value;

    $.get("/Profissional/SelecionarProfissional?codigoProfissional=" + item, function (response) {

        parent.postMessage(response);

    });    
}