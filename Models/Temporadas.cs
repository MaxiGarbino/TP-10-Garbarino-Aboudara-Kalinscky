namespace TP10_Aboudara_Garbarino_Kalinscky.Models
{
    public class Temporadas{
        public string IdTemporada {get;set;}
        public string IdSerie {get;set;}
        public string NumeroTemporada {get;set;}
        public string TituloTemporada {get;set;}
    }
    public Temporadas(){

    }
    public Temporadas(int IdTemporada = 0, int IdSerie = 0, int NumeroTemporada = 0, string TituloTemporada = ""){
        this.IdTemporada = IdTemporada;
        this.IdSerie= IdSerie;
        this.NumeroTemporada = NumeroTemporada;
        this.TituloTemporada = TituloTemporada;
    }
}