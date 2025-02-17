using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ReceberDAO
    {
        private string connectionString;

        public ReceberDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Receber receber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Receber (id_cli_fk, valor_total, valor_pago, saldo_devido, " +
                               "data_vencimento, data_pagamento, status_pagamento, forma_pagamento, " +
                               "descricao_recebimento, id_fun_fk) " +
                               "VALUES (@IdClienteFk, @ValorTotal, @ValorPago, @SaldoDevido, @DataVencimento, " +
                               "@DataPagamento, @StatusPagamento, @FormaPagamento, @DescricaoRecebimento, @IdFuncionarioFk)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdClienteFk", receber.IdClienteFk);
                cmd.Parameters.AddWithValue("@ValorTotal", receber.ValorTotal);
                cmd.Parameters.AddWithValue("@ValorPago", receber.ValorPago);
                cmd.Parameters.AddWithValue("@SaldoDevido", receber.SaldoDevido);
                cmd.Parameters.AddWithValue("@DataVencimento", receber.DataVencimento);
                cmd.Parameters.AddWithValue("@DataPagamento", (object)receber.DataPagamento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StatusPagamento", receber.StatusPagamento);
                cmd.Parameters.AddWithValue("@FormaPagamento", receber.FormaPagamento);
                cmd.Parameters.AddWithValue("@DescricaoRecebimento", receber.DescricaoRecebimento);
                cmd.Parameters.AddWithValue("@IdFuncionarioFk", receber.IdFuncionarioFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Receber receber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Receber SET id_cli_fk = @IdClienteFk, valor_total = @ValorTotal, " +
                               "valor_pago = @ValorPago, saldo_devido = @SaldoDevido, data_vencimento = @DataVencimento, " +
                               "data_pagamento = @DataPagamento, status_pagamento = @StatusPagamento, " +
                               "forma_pagamento = @FormaPagamento, descricao_recebimento = @DescricaoRecebimento, " +
                               "id_fun_fk = @IdFuncionarioFk WHERE id_receber = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", receber.Id);
                cmd.Parameters.AddWithValue("@IdClienteFk", receber.IdClienteFk);
                cmd.Parameters.AddWithValue("@ValorTotal", receber.ValorTotal);
                cmd.Parameters.AddWithValue("@ValorPago", receber.ValorPago);
                cmd.Parameters.AddWithValue("@SaldoDevido", receber.SaldoDevido);
                cmd.Parameters.AddWithValue("@DataVencimento", receber.DataVencimento);
                cmd.Parameters.AddWithValue("@DataPagamento", (object)receber.DataPagamento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@StatusPagamento", receber.StatusPagamento);
                cmd.Parameters.AddWithValue("@FormaPagamento", receber.FormaPagamento);
                cmd.Parameters.AddWithValue("@DescricaoRecebimento", receber.DescricaoRecebimento);
                cmd.Parameters.AddWithValue("@IdFuncionarioFk", receber.IdFuncionarioFk);

            }
        }
    }
}

