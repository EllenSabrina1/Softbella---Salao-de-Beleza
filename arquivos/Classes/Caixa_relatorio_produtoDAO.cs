using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Caixa_relatorio_produtoDAO
    {
        private string connectionString;

        public Caixa_relatorio_produtoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Caixa_relatorio_produto relatorioProduto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Caixa_Relatorio_Produto (id_pro_fk, data_relatorio, tipo_movimentacao, " +
                               "quantidade_movimentada, valor_unitario, valor_total, id_fun_fk) " +
                               "VALUES (@IdProdutoFk, @DataRelatorio, @TipoMovimentacao, @QuantidadeMovimentada, " +
                               "@ValorUnitario, @ValorTotal, @IdFuncionarioFk)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProdutoFk", relatorioProduto.IdProdutoFk);
                cmd.Parameters.AddWithValue("@DataRelatorio", relatorioProduto.DataRelatorio);
                cmd.Parameters.AddWithValue("@TipoMovimentacao", relatorioProduto.TipoMovimentacao);
                cmd.Parameters.AddWithValue("@QuantidadeMovimentada", relatorioProduto.QuantidadeMovimentada);
                cmd.Parameters.AddWithValue("@ValorUnitario", relatorioProduto.ValorUnitario);
                cmd.Parameters.AddWithValue("@ValorTotal", relatorioProduto.ValorTotal);
                cmd.Parameters.AddWithValue("@IdFuncionarioFk", relatorioProduto.IdFuncionarioFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Caixa_relatorio_produto relatorioProduto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Caixa_Relatorio_Produto SET id_pro_fk = @IdProdutoFk, data_relatorio = @DataRelatorio, " +
                               "tipo_movimentacao = @TipoMovimentacao, quantidade_movimentada = @QuantidadeMovimentada, " +
                               "valor_unitario = @ValorUnitario, valor_total = @ValorTotal, id_fun_fk = @IdFuncionarioFk " +
                               "WHERE id_relatorio = @IdRelatorio";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdRelatorio", relatorioProduto.IdRelatorio);
                cmd.Parameters.AddWithValue("@IdProdutoFk", relatorioProduto.IdProdutoFk);
                cmd.Parameters.AddWithValue("@DataRelatorio", relatorioProduto.DataRelatorio);
                cmd.Parameters.AddWithValue("@TipoMovimentacao", relatorioProduto.TipoMovimentacao);
                cmd.Parameters.AddWithValue("@QuantidadeMovimentada", relatorioProduto.QuantidadeMovimentada);
                cmd.Parameters.AddWithValue("@ValorUnitario", relatorioProduto.ValorUnitario);
                cmd.Parameters.AddWithValue("@ValorTotal", relatorioProduto.ValorTotal);
                cmd.Parameters.AddWithValue("@IdFuncionarioFk", relatorioProduto.IdFuncionarioFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int idRelatorio)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Caixa_Relatorio_Produto WHERE id_relatorio = @IdRelatorio";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdRelatorio", idRelatorio);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}

