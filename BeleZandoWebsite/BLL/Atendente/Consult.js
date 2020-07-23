$(document).ready(function () {
    CriaEscutaPostMessageFromIFrame();
});

function CriaEscutaPostMessageFromIFrame() {
    var eventMethod = window.addEventListener ? "addEventListener" : "attachEvent";
    var eventer = window[eventMethod];
    var messageEvent = eventMethod == "attachEvent" ? "onmessage" : "message";

    // Listen to message from child window
    eventer(messageEvent, function (e) {
        $("#listarAtendente").modal("hide");
        $("#CodigoAtendente").val(e.data.CodigoAtendente);
        TxtPesquisarAtendente();
    }, false);
}