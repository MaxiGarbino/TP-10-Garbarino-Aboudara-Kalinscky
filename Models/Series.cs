namespace TP10_Aboudara_Garbarino_Kalinscky.Models;
    public class Series
    {
        public int IdSerie {get;set;}
        public string Nombre {get;set;}
        public int AñoInicio {get;set;}
        public string Sinopsis {get;set;}
        public string ImagenSerie {get;set;}
    
    public Series(){

    }
    public Series(int IdSerie = 0, string Nombre = "", int AñoInicio = 0, string Sinopsis = "", string ImagenSerie = ""){
        this.IdSerie = IdSerie;
        this.Nombre = Nombre;
        this.AñoInicio = AñoInicio;
        this.Sinopsis = Sinopsis;
        this.ImagenSerie = ImagenSerie;
    }
    }