using PraticandoProgramção.MVC.Entidades;
using System.Data.SqlClient;

namespace PraticandoProgramção.MVC.Sql_Server
{
    public class SqlServer : AcessoDados
    {  
        public List<ClubesFutebol> BuscarDados()
        {
            var clubes = new List<ClubesFutebol>();
            using (var command = new SqlCommand())
            {

                command.Connection = AbrirConexao();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select Id, NomeClube, QdeVitoria, Pontuacao from ClubesFutebol";
                // A Query acima será para a leitura de dados então para ler utilizamos o seguinte comando abaixo:
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())                
                {
                    clubes.Add(new ClubesFutebol
                    {
                        Id = Convert.ToInt32(reader["Id"].ToString()),
                        NomeClube = reader["NomeClube"].ToString(),
                        QdeVitoria = Convert.ToInt32(reader["QdeVitoria"].ToString()),
                        Pontuacao = Convert.ToInt32(reader["Pontuacao"].ToString())
                    });
                }
                FecharConexao();
                return clubes;
            }
        }
    }
}
