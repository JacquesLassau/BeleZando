function SelecionarProfissionalLinkModal(idProfissional) {

    event.preventDefault();
    var item = document.getElementById(idProfissional).value;

    $.get("/Profissional/SelecionarProfissional?codigoProfissional=" + item, function (data) {

        $("#NomeFantasiaProfissional").val(data.NomeFantasiaProfissional); 
        $("#listarProfissional").modal("hide");

    });

    document.getElementById("CodigoProfissional").value = item;
}