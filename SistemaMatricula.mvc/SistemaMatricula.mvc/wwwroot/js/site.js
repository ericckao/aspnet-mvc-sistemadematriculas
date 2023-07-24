

//Jquery fazendo referencia ao nosso documento, quando estiver pronto, irá executar o codigo abaixo.
$(document).ready(function () {
    $('#matriculas').DataTable({

        "pageLength": 5,
        "lengthMenu": [5, 10, 25, 50, 100],

        //Configurando para PT-BR alguns topicos.
        language: {
            "decimal": "",
            "emptyTable": "No data available in table",
            "info": "Mostrando _START_ de _END_ de _TOTAL_ entradas",
            "infoEmpty": "Showing 0 to 0 of 0 entries",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ entradas",
            "loadingRecords": "Loading...",
            "processing": "Processing...",
            "search": "Procurar:",
            "zeroRecords": "No matching records found",
            "paginate": {
                "first": "Primeiro",
                "last": "Ultimo",
                "next": "Proximo",
                "previous": "Anterior"
            },
            "aria": {
                "sortAscending": ": activate to sort column ascending",
                "sortDescending": ": activate to sort column descending"
            }
        }
    });


    // CONFIGURANDO O TEMPO EM QUE A MENSAGEM DE SUCESSO IRÁ APARECER EM TELA.
    setTimeout(function ()
    {
        $(".alert").fadeOut("slow", function ()
        {
            $(this).alert("close");
        })
    }, 5000)

});
