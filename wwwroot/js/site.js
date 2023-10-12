function MostrarTemporada(IDS) {
    $.ajax({

        type: 'POST',
        dataType: 'JSON',
        url: '/Home/Index',
        data: {IDSerie: IDS},
        success:
            function (response){
                $("#TituloTemporada").html("Nombre de la temporada: " + response.TituloTemporada);
                $("#NumeroTemporada").html("Temporada N°: " +response.NumeroTemporada);
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
                $("#NombreActor").html("Nombre del actor " +response.Nombre);
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
                $("#NombreSerie").html("Nombre: " + response.Nombre);
                $("#AñoInicio").html("Año de estreno: " +response.AñoInicio);
                $("#Sinopsis").html("Sintesis: " + response.Sinopsis);
                $("#ImagenSerie").attr("src","/"+response.Nombre);
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

