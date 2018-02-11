
function getEncryptionKey() {
   var userName= document.getElementById("usr").value;
   var Password = document.getElementById("pwd").value;

 

    $.ajax({
        crossDomain: false,
        async: true,
        method: "POST",
        url: "http://localhost:42206/GatewayService.svc/GenerateEncryptionKey",
        headers: {
            "content-type": "application/json",
            "cache-control": "no-cache",
            "postman-token": "05285e30-2026-25a8-5a85-d66179494abd"
        },
        data: { UserName: userName, Password: Password }
    })
  .done(function (msg) {
      store.set('encryptionKey', { name: 'msg' })
        
    });
    
   
}

function payment() {
    //encryptian to be implement
    encryptionKey = store.get('encryptionKey');
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://localhost:42206/GatewayService.svc/GenerateEncryptionKey",
        "method": "POST",
        "headers": {
            "content-type": "application/json",
            "cache-control": "no-cache"
        },
        "data": "{\n\t\"ProcessingCode\":\"999000\",\n\"SystemTraceNr\":36,\n\"FunctionCode\":1324,\n\"CardNo\":\"4712345601012222\", \n\"CardHolder\" :\"Ahmed Mohamed\" ,\n\"AmountTrxn\":1000,\nCurrencyCode:840 \n\n\t\n}"
    }

    $.ajax(settings).done(function (response) {
        alert(response);
    });


}

