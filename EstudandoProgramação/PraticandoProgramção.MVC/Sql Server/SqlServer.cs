using PraticandoProgramção.MVC.Entidades;
using System.Data.SqlClient;

namespace PraticandoProgramção.MVC.Sql_Server
{
    public class SqlServer : AcessoDados
    {  
        public List<ClubesFutebol> BuscarDados()
        {
            var clubes = new List<ClubesFutebol>();
            var clube = new ClubesFutebol();
            using (var command = new SqlCommand())
            {

                command.Connection = AbrirConexao();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select * from ClubesFutebol";
                // A Query acima será para a leitura de dados então para ler utilizamos o seguinte comando abaixo:
                SqlDataReader reader = command.ExecuteReader();
                

                while (reader.Read())                
                {
                    clube.Id = Convert.ToInt32(reader["Id"].ToString());
                    clube.NomeClube = reader["NomeClube"].ToString();
                    clube.QdeVitoria =Convert.ToInt32(reader["QdeVitoria"].ToString());
                    clube.Pontuacao = Convert.ToInt32(reader["Pontuacao"].ToString());
                    clubes.Add(clube);
                }
                FecharConexao();
                return clubes;
            }
        }
    }
}
