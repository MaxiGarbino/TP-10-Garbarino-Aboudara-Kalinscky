using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

namespace TP_10_Garbarino_Aboudara_Kalinscky

public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=BDSeries;Trusted_Connection=True;";
    

    public static list<Series> listarSeries() {
        list<Series> series;
         using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            series = db.Query<Series>(sql).ToList();
        }
        return series;
    }

    private static list<Temporadas> listarTemporadas(int IdSerie) {
        list<Temporadas> temporadas;
         using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Temporadas where IdSerie = @pIdSerie";
            temporadas = db.Query<Temporadas>(sql, new {pIdSerie = IdSerie}).ToList();
        }
        return temporadas;
    }

     private static list<Actores> listarActores(int IdSerie) {
        list<Actores> actores;
         using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores where IdSerie = @pIdSerie";
            actores = db.Query<Temporadas>(sql, new {pIdSerie = IdSerie}).ToList();
        }
        return actores;
    }
}