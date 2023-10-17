namespace TP10_Aboudara_Garbarino_Kalinscky.Models;
    public class Temporadas{
        public int IdTemporada {get;set;}
        public int IdSerie {get;set;}
        public int NumeroTemporada {get;set;}
        public string TituloTemporada {get;set;}
    
    public Temporadas(){

    }

    public Temporadas(int IdTemporada = 0, int IdSerie = 0, int NumeroTemporada = 0, string TituloTemporada = ""){
        this.IdTemporada = IdTemporada;
        this.IdSerie= IdSerie;
        this.NumeroTemporada = NumeroTemporada;
        this.TituloTemporada = TituloTemporada;
    }
    }