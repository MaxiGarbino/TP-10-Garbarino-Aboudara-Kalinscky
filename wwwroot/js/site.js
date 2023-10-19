function MostrarTemporadas(IDS) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetalleTemporadaAjax',
        data: {IDSerie: IDS},
        success:
            function (response){
                console.log(response);
                $("#TituloSerie").html("Temporadas");

                let texto = "<p>";
                response.forEach(element => {
                    texto+="Nombre de la temporada: " + element.tituloTemporada +"<br>";
                    texto+="Temporada N°: " + element.numeroTemporada + "<br>";
                }); 
                texto+="</p>"
                
                $("#infoSerie").html(texto);
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
        url: '/Home/VerDetalleActoresAjax',
        data: {IDSerie: IDS},
        success:
            function (response){
                console.log(response);
                $("#TituloSerie").html("Actores");
                let texto = "<p>";
                let i = 1;
                response.forEach(element => {
                    texto+="Nombre del actor N°"+i+": "+element.nombre +"<br>";
                    i+=1;
                }); 
                texto+="</p>"
                $("#infoSerie").html(texto);
                
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
function MostrarInfoSerie(IDS) {
    $.ajax({

        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetalleSerieAjax',
        data: {IDSerie: IDS},
        success:
            function (response){
                console.log(response);
                $("#TituloSerie").html("Detalle de la serie" + response.nombre);

                let texto = "<p> Año de estreno: " +response.añoInicio + "<br>";
                texto+= "Sintesis: " + response.sinopsis + "<br>";
                texto+= "<img src='" + response.imagenSerie + "' class='img-fluid '></p>";
                $("#infoSerie").html(texto);
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

