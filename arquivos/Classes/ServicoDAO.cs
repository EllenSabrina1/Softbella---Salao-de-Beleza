using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    internal class ServicoDAO
    {
        private string connectionString;

        public ServicoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Servico servico)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Servico (grupo_ser, nome_servico_ser, tempo_necessario_ser, profissional_ser, " +
                               "valor_vista_ser, valor_prazo_ser, produtos_utilizados_ser, id_fun_fk) " +
                               "VALUES (@Grupo, @NomeServico, @TempoNecessario, @Profissional, @ValorVista, @ValorPrazo, " +
                               "@ProdutosUtilizados, @IdFuncionarioFk)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Grupo", servico.Grupo);
                cmd.Parameters.AddWithValue("@NomeServico", servico.NomeServico);
                cmd.Parameters.AddWithValue("@TempoNecessario", servico.TempoNecessario);
                cmd.Parameters.AddWithValue("@Profissional", servico.Profissional);
                cmd.Parameters.AddWithValue("@ValorVista", servico.ValorVista);
                cmd.Parameters.AddWithValue("@ValorPrazo", servico.ValorPrazo);
                cmd.Parameters.AddWithValue("@ProdutosUtilizados", servico.ProdutosUtilizados);
                cmd.Parameters.AddWithValue("@IdFuncionarioFk", servico.IdFuncionarioFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Servico servico)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Servico SET grupo_ser = @Grupo, nome_servico_ser = @NomeServico, " +
                               "tempo_necessario_ser = @TempoNecessario, profissional_ser = @Profissional, " +
                               "valor_vista_ser = @ValorVista, valor_prazo_ser = @ValorPrazo, " +
                               "produtos_utilizados_ser = @ProdutosUtilizados, id_fun_fk = @IdFuncionarioFk " +
                               "WHERE id_ser = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", servico.Id);
                cmd.Parameters.AddWithValue("@Grupo", servico.Grupo);
                cmd.Parameters.AddWithValue("@NomeServico", servico.NomeServico);
                cmd.Parameters.AddWithValue("@TempoNecessario", servico.TempoNecessario);
                cmd.Parameters.AddWithValue("@Profissional", servico.Profissional);
                cmd.Parameters.AddWithValue("@ValorVista", servico.ValorVista);
                cmd.Parameters.AddWithValue("@ValorPrazo", servico.ValorPrazo);
                cmd.Parameters.AddWithValue("@ProdutosUtilizados", servico.ProdutosUtilizados);
                cmd.Parameters.AddWithValue("@IdFuncionarioFk", servico.IdFuncionarioFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Servico WHERE id_ser = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }




    }
}

