using System.Data.SqlClient;

namespace PraticandoProgramção.MVC
{
    public class AcessoDados
    {
        SqlConnection connection = new SqlConnection();
        public AcessoDados()
        {
            connection.ConnectionString = "server = GMS\\SQLEXPRESS; database = EstudosProgramacao;  integrated security=sspi;";
        }

        public SqlConnection AbrirConexao()
        {

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            return connection;
        }
        public SqlConnection FecharConexao()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            return connection;
        }
    }
}
