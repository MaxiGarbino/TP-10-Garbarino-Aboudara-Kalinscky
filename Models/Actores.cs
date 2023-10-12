namespace TP10_Aboudara_Garbarino_Kalinscky.Models{
    public class Actores{
        public int IdActor {get; set;}
        public int IdSerie {get; set;}
        public string Nombre {get; set;}
    
        public Actores(){

        }
        public Actores(int IdActor = 0, int IdSerie = 0, string Nombre = ""){
            this.IdActor = IdActor;
            this.IdSerie = IdSerie;
            this.Nombre = Nombre;
        }
    }
}