$(document).ready(function () {
    CriaEscutaPostMessageFromIFrame();
});

function CriaEscutaPostMessageFromIFrame() {

    var eventMethod = window.addEventListener ? "addEventListener" : "attachEvent";
    var eventer = window[eventMethod];
    var messageEvent = eventMethod == "attachEvent" ? "onmessage" : "message";
        
    eventer(messageEvent, function (e) {

        $("#listarProfissional").modal("hide");
        $("#CodigoProfissional").val(e.data.CodigoProfissional);
        TxtPesquisarProfissional();

    }, false);

}