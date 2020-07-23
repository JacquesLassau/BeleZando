function TxtPesquisarProfissional() {

    event.preventDefault();

    document.getElementById("NomeFantasiaProfissional").value = null;

    var item = document.getElementById("CodigoProfissional").value;

    if (item == "")
        item = 0;

    $.get("/Profissional/SelecionarProfissional?codigoProfissional=" + item, function (data) {

        if (data.EmailProfissional != null) {
            $(function () {
                $("#NomeFantasiaProfissional").val(data.NomeFantasiaProfissional);
                $("#listarProfissional").modal("hide");
            });
        }
    });
}

function BtnPesquisarProfissional() {

    $("#CodigoProfissional").val(null);
    $("#NomeFantasiaProfissional").val(null);

}