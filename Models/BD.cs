using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP_10_Garbarino_Aboudara_Kalinscky.Models;


public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=BDSeries;Trusted_Connection=True;";
    
    public static List<Series> series = new List<Series>();
    public static List<Series> listarSeries() {
        List<Series> series;
         using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            series = db.Query<Series>(sql).ToList();
        }
        return series;
    }
    public static List<Temporadas> temporadas = new List<Temporadas>();
    public static List<Temporadas> listarTemporadas(int IdSerie) {
        List<Temporadas> temporadas;
         using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Temporadas where IdSerie = @pIdSerie";
            temporadas = db.Query<Temporadas>(sql, new {pIdSerie = IdSerie}).ToList();
        }
        return temporadas;
    }
    public static List<Actores> actores = new List<Actores>();
    public static List<Actores> listarActores(int IdSerie) {
        List<Actores> actores;
         using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores where IdSerie = @pIdSerie";
            actores = db.Query<Temporadas>(sql, new {pIdSerie = IdSerie}).ToList();
        }
        return actores;
    }
}