using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Relatorio_servicoDAO
    {
        private string connectionString;

        public Relatorio_servicoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Relatorio_servico relatorioServico)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Relatorio_Servico (nome_servico_rel_ser, tempo_previsto_rel_ser, " +
                               "observacao_rel_ser, profissional_rel_ser, valor_vista_rel_ser, valor_prazo_rel_ser, id_ser_fk) " +
                               "VALUES (@NomeServico, @TempoPrevisto, @Observacao, @Profissional, @ValorVista, @ValorPrazo, @IdServicoFk)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NomeServico", relatorioServico.NomeServico);
                cmd.Parameters.AddWithValue("@TempoPrevisto", relatorioServico.TempoPrevisto);
                cmd.Parameters.AddWithValue("@Observacao", relatorioServico.Observacao);
                cmd.Parameters.AddWithValue("@Profissional", relatorioServico.Profissional);
                cmd.Parameters.AddWithValue("@ValorVista", relatorioServico.ValorVista);
                cmd.Parameters.AddWithValue("@ValorPrazo", relatorioServico.ValorPrazo);
                cmd.Parameters.AddWithValue("@IdServicoFk", relatorioServico.IdServicoFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Relatorio_servico relatorioServico)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Relatorio_Servico SET nome_servico_rel_ser = @NomeServico, " +
                               "tempo_previsto_rel_ser = @TempoPrevisto, observacao_rel_ser = @Observacao, " +
                               "profissional_rel_ser = @Profissional, valor_vista_rel_ser = @ValorVista, " +
                               "valor_prazo_rel_ser = @ValorPrazo, id_ser_fk = @IdServicoFk " +
                               "WHERE id_rel_ser = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", relatorioServico.Id);
                cmd.Parameters.AddWithValue("@NomeServico", relatorioServico.NomeServico);
                cmd.Parameters.AddWithValue("@TempoPrevisto", relatorioServico.TempoPrevisto);
                cmd.Parameters.AddWithValue("@Observacao", relatorioServico.Observacao);
                cmd.Parameters.AddWithValue("@Profissional", relatorioServico.Profissional);
                cmd.Parameters.AddWithValue("@ValorVista", relatorioServico.ValorVista);
                cmd.Parameters.AddWithValue("@ValorPrazo", relatorioServico.ValorPrazo);
                cmd.Parameters.AddWithValue("@IdServicoFk", relatorioServico.IdServicoFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Relatorio_Servico WHERE id_rel_ser = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}

