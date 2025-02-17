using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ConsultarProdutoDAO
    {
        private string connectionString;

        public ConsultarProdutoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(ConsultaProduto consultaProduto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ConsultaProduto (produto_con, nome_con, marca_con, quantidade_con, custo_con, lucro_con) " +
                               "VALUES (@Produto, @Nome, @Marca, @Quantidade, @Custo, @Lucro)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Produto", consultaProduto.Produto);
                cmd.Parameters.AddWithValue("@Nome", consultaProduto.Nome);
                cmd.Parameters.AddWithValue("@Marca", consultaProduto.Marca);
                cmd.Parameters.AddWithValue("@Quantidade", consultaProduto.Quantidade);
                cmd.Parameters.AddWithValue("@Custo", consultaProduto.Custo);
                cmd.Parameters.AddWithValue("@Lucro", consultaProduto.Lucro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(ConsultaProduto consultaProduto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE ConsultaProduto SET produto_con = @Produto, nome_con = @Nome, marca_con = @Marca, " +
                               "quantidade_con = @Quantidade, custo_con = @Custo, lucro_con = @Lucro " +
                               "WHERE id_con = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", consultaProduto.Id);
                cmd.Parameters.AddWithValue("@Produto", consultaProduto.Produto);
                cmd.Parameters.AddWithValue("@Nome", consultaProduto.Nome);
                cmd.Parameters.AddWithValue("@Marca", consultaProduto.Marca);
                cmd.Parameters.AddWithValue("@Quantidade", consultaProduto.Quantidade);
                cmd.Parameters.AddWithValue("@Custo", consultaProduto.Custo);
                cmd.Parameters.AddWithValue("@Lucro", consultaProduto.Lucro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ConsultaProduto WHERE id_con = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ConsultaProduto BuscarPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ConsultaProduto WHERE id_con = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ConsultaProduto
                        {
                            Id = (int)reader["id_con"],
                            Produto = reader["produto_con"].ToString(),
                            Nome = reader["nome_con"].ToString(),
                            Marca = reader["marca_con"].ToString(),
                            Quantidade = (int)reader["quantidade_con"],
                            Custo = (double)reader["custo_con"],
                            Lucro = (double)reader["lucro_con"]
                        };
                    }
                }
            }
            return null; // Retorna null se não encontrar
        }


    }
}

