using System.Data.SqlClient;

namespace PraticandoProgramção.MVC.Sql_Server
{
    public class AcessoDados
    {
        private const string ConnectionString = "server = GMS\\SQLEXPRESS; database = EstudosProgramacao;  integrated security=sspi;";
        public SqlConnection AbrirConexao()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message, ex);
                }
                return connection;

            }
        }
        public SqlConnection FecharConexao()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message, ex);
                }
                return connection;
            }
        }
    }
}
