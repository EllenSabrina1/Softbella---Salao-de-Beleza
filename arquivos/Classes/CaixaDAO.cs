using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class CaixaDao
    {
        private string connectionString;

        public CaixaDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Caixa caixa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Caixa (data_transacao, tipo_transacao, valor_transacao, descricao_transacao, id_fun_fk) " +
                               "VALUES (@data_transacao, @tipo_transacao, @valor_transacao, @descricao_transacao, @id_fun_fk)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@data_transacao", caixa.DataTransacao);
                cmd.Parameters.AddWithValue("@tipo_transacao", caixa.TipoTransacao);
                cmd.Parameters.AddWithValue("@valor_transacao", caixa.ValorTransacao);
                cmd.Parameters.AddWithValue("@descricao_transacao", caixa.DescricaoTransacao);
                cmd.Parameters.AddWithValue("@id_fun_fk", caixa.IdFunFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Caixa caixa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Caixa SET data_transacao = @data_transacao, tipo_transacao = @tipo_transacao, " +
                               "valor_transacao = @valor_transacao, descricao_transacao = @descricao_transacao " +
                               "WHERE id_caixa = @id_caixa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_caixa", caixa.IdCaixa);
                cmd.Parameters.AddWithValue("@data_transacao", caixa.DataTransacao);
                cmd.Parameters.AddWithValue("@tipo_transacao", caixa.TipoTransacao);
                cmd.Parameters.AddWithValue("@valor_transacao", caixa.ValorTransacao);
                cmd.Parameters.AddWithValue("@descricao_transacao", caixa.DescricaoTransacao);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int idCaixa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Caixa WHERE id_caixa = @id_caixa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_caixa", idCaixa);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Caixa BuscarPorId(int idCaixa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Caixa WHERE id_caixa = @id_caixa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_caixa", idCaixa);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Caixa
                    {
                        IdCaixa = (int)reader["id_caixa"],
                        DataTransacao = (DateTime)reader["data_transacao"],
                        TipoTransacao = reader["tipo_transacao"].ToString(),
                        ValorTransacao = (double)reader["valor_transacao"],
                        DescricaoTransacao = reader["descricao_transacao"].ToString(),
                        IdFunFk = (int)reader["id_fun_fk"]
                    };
                }
                return null;
            }
        }

    }
} 