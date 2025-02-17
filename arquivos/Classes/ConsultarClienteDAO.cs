using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ConsultarClienteDAO
    {
        private string connectionString;

        public ConsultarClienteDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(ConsultarCliente consultarCliente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ConsultarCliente (nome_con_cli, rg_con_cli, rua_con_cli, num_con_cli, " +
                               "bairro_con_cli, cidade_con_cli, id_con_cli_fk) " +
                               "VALUES (@Nome, @Rg, @Rua, @Numero, @Bairro, @Cidade, @IdClienteFk)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", consultarCliente.Nome);
                cmd.Parameters.AddWithValue("@Rg", consultarCliente.Rg);
                cmd.Parameters.AddWithValue("@Rua", consultarCliente.Rua);
                cmd.Parameters.AddWithValue("@Numero", consultarCliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", consultarCliente.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", consultarCliente.Cidade);
                cmd.Parameters.AddWithValue("@IdClienteFk", consultarCliente.IdClienteFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(ConsultarCliente consultarCliente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE ConsultarCliente SET nome_con_cli = @Nome, rg_con_cli = @Rg, rua_con_cli = @Rua, " +
                               "num_con_cli = @Numero, bairro_con_cli = @Bairro, cidade_con_cli = @Cidade, " +
                               "id_con_cli_fk = @IdClienteFk WHERE id_con_cli = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", consultarCliente.Id);
                cmd.Parameters.AddWithValue("@Nome", consultarCliente.Nome);
                cmd.Parameters.AddWithValue("@Rg", consultarCliente.Rg);
                cmd.Parameters.AddWithValue("@Rua", consultarCliente.Rua);
                cmd.Parameters.AddWithValue("@Numero", consultarCliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", consultarCliente.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", consultarCliente.Cidade);
                cmd.Parameters.AddWithValue("@IdClienteFk", consultarCliente.IdClienteFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ConsultarCliente WHERE id_con_cli = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}

