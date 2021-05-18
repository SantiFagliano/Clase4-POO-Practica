$(document).ready(function () {
    $('#table_id').DataTable();
    /*
    Swal.fire({
        title: 'Error!',
        text: 'Do you want to continue',
        icon: 'error',
        confirmButtonText: 'Cool'
    })*/
     $('#btnGenerarGanador').click(function (e) {
         e.preventDefault();
 
         $.ajax({
             type: "POST",                                              // tipo de request que estamos generando
             url: 'Home/BuscarGanador',                    // URL al que vamos a hacer el pedido
             data: null,                                                // data es un arreglo JSON que contiene los parámetros que 
             // van a ser recibidos por la función del servidor
             contentType: "application/json; charset=utf-8",            // tipo de contenido
             dataType: "json",                                          // formato de transmición de datos
             async: true,                                               // si es asincrónico o no
             success: function (resultado) {                            // función que va a ejecutar si el pedido fue exitoso
                 var num = resultado.d;
                 $('#lblResultado').text('Número aleatorio es ' + num);
             },
             error: function (XMLHttpRequest, textStatus, errorThrown) { // función que va a ejecutar si hubo algún tipo de error en el pedido
                 var error = eval("(" + XMLHttpRequest.responseText + ")");
                 aler(error.Message);
             }
         });
     })
});