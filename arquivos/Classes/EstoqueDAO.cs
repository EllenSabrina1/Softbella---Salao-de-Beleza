using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class EstoqueDao
    {
        private string connectionString;

        public EstoqueDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Estoque estoque)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Estoque (nome_est, marca_est, grupo_est, produto_est, quantidade_est, fracionar_est, " +
                               "custo_est, lucro_est, fornecedor_est, contato_fornecedor_est, email_fornecedor, id_pro_fk) " +
                               "VALUES (@Nome, @Marca, @Grupo, @Produto, @Quantidade, @Fracionar, @Custo, @Lucro, @Fornecedor, " +
                               "@ContatoFornecedor, @EmailFornecedor, @IdProdutoFk)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", estoque.Nome);
                cmd.Parameters.AddWithValue("@Marca", estoque.Marca);
                cmd.Parameters.AddWithValue("@Grupo", estoque.Grupo);
                cmd.Parameters.AddWithValue("@Produto", estoque.Produto);
                cmd.Parameters.AddWithValue("@Quantidade", estoque.Quantidade);
                cmd.Parameters.AddWithValue("@Fracionar", estoque.Fracionar);
                cmd.Parameters.AddWithValue("@Custo", estoque.Custo);
                cmd.Parameters.AddWithValue("@Lucro", estoque.Lucro);
                cmd.Parameters.AddWithValue("@Fornecedor", estoque.Fornecedor);
                cmd.Parameters.AddWithValue("@ContatoFornecedor", estoque.ContatoFornecedor);
                cmd.Parameters.AddWithValue("@EmailFornecedor", estoque.EmailFornecedor);
                cmd.Parameters.AddWithValue("@IdProdutoFk", estoque.IdProdutoFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Estoque estoque)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Estoque SET nome_est = @Nome, marca_est = @Marca, grupo_est = @Grupo, " +
                               "produto_est = @Produto, quantidade_est = @Quantidade, fracionar_est = @Fracionar, " +
                               "custo_est = @Custo, lucro_est = @Lucro, fornecedor_est = @Fornecedor, " +
                               "contato_fornecedor_est = @ContatoFornecedor, email_fornecedor = @EmailFornecedor, " +
                               "id_pro_fk = @IdProdutoFk WHERE id_est = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", estoque.Id);
                cmd.Parameters.AddWithValue("@Nome", estoque.Nome);
                cmd.Parameters.AddWithValue("@Marca", estoque.Marca);
                cmd.Parameters.AddWithValue("@Grupo", estoque.Grupo);
                cmd.Parameters.AddWithValue("@Produto", estoque.Produto);
                cmd.Parameters.AddWithValue("@Quantidade", estoque.Quantidade);
                cmd.Parameters.AddWithValue("@Fracionar", estoque.Fracionar);
                cmd.Parameters.AddWithValue("@Custo", estoque.Custo);
                cmd.Parameters.AddWithValue("@Lucro", estoque.Lucro);
                cmd.Parameters.AddWithValue("@Fornecedor", estoque.Fornecedor);
                cmd.Parameters.AddWithValue("@ContatoFornecedor", estoque.ContatoFornecedor);
                cmd.Parameters.AddWithValue("@EmailFornecedor", estoque.EmailFornecedor);

            }
        }
    }
}
