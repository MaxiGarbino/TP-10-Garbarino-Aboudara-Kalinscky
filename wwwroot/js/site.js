function MostrarTemporadas(IDS) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/Index',
        data: {IDSerie: IDS},
        success:
            function (response){
                alert("hola");
                $("#TituloModal").html("Temporadas");
                $("#Info1").html("Nombre de la temporada: " + response.TituloTemporada);
                $("#Info2").html("Temporada N°: " +response.NumeroTemporada);
            },
            error : function(xhr,status){
                alert("Disculpe, hubo un problema, Matias Aboudara hizo algo mal");
            },
            complete: function(xhr,status){
                console.log('Peticion realizada')
            }

    }
    );
}
function MostrarActores(IDS) {
    $.ajax({

        type: 'POST',
        dataType: 'JSON',
        url: '/Home/Index',
        data: {IDSerie: IDS},
        success:
            function (response){
                $("#TituloModal").html("Actores");
                $("#Info1").html("Nombre del actor " +response.Nombre);
            },
        error : function(xhr,status){
            alert("Disculpe, hubo un problema, Matias Aboudara hizo algo mal");
        },
        complete: function(xhr,status){
            console.log('Peticion realizada')
        }


    }
    );
}
function MostrarSeries(IDS) {
    $.ajax({

        type: 'POST',
        dataType: 'JSON',
        url: '/Home/Index',
        data: {IDSerie: IDS},
        success:
            function (response){
                $("#TituloModal").html("Detalle de la serie");
                $("#Info1").html("Nombre: " + response.Nombre);
                $("#Info2").html("Año de estreno: " +response.AñoInicio);
                $("#Info3").html("Sintesis: " + response.Sinopsis);
                $("#Info4").attr("src","/"+response.Nombre);
            },
            error : function(xhr,status){
                alert("Disculpe, hubo un problema, Matias Aboudara hizo algo mal");
            },
            complete: function(xhr,status){
                console.log('Peticion realizada')
            }

    }
    );
}

