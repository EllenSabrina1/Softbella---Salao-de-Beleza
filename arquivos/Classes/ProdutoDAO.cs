using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ProdutoDAO
    {
        private string connectionString;

        public ProdutoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Produto produto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Produto (nome_pro, marca_pro, grupo_pro, estoque_venda_pro, medida_unidade_pro, " +
                               "nome_fornecedor_pro, contato_fornecedor_pro, cidade_pro, custo_pro, preco_venda_pro, lucro_pro) " +
                               "VALUES (@Nome, @Marca, @Grupo, @EstoqueVenda, @MedidaUnidade, @NomeFornecedor, @ContatoFornecedor, " +
                               "@Cidade, @Custo, @PrecoVenda, @Lucro)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                cmd.Parameters.AddWithValue("@Grupo", produto.Grupo);
                cmd.Parameters.AddWithValue("@EstoqueVenda", produto.EstoqueVenda);
                cmd.Parameters.AddWithValue("@MedidaUnidade", produto.MedidaUnidade);
                cmd.Parameters.AddWithValue("@NomeFornecedor", produto.NomeFornecedor);
                cmd.Parameters.AddWithValue("@ContatoFornecedor", produto.ContatoFornecedor);
                cmd.Parameters.AddWithValue("@Cidade", produto.Cidade);
                cmd.Parameters.AddWithValue("@Custo", produto.Custo);
                cmd.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
                cmd.Parameters.AddWithValue("@Lucro", produto.Lucro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Produto produto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Produto SET nome_pro = @Nome, marca_pro = @Marca, grupo_pro = @Grupo, " +
                               "estoque_venda_pro = @EstoqueVenda, medida_unidade_pro = @MedidaUnidade, " +
                               "nome_fornecedor_pro = @NomeFornecedor, contato_fornecedor_pro = @ContatoFornecedor, " +
                               "cidade_pro = @Cidade, custo_pro = @Custo, preco_venda_pro = @PrecoVenda, lucro_pro = @Lucro " +
                               "WHERE id_pro = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", produto.Id);
                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                cmd.Parameters.AddWithValue("@Grupo", produto.Grupo);
                cmd.Parameters.AddWithValue("@EstoqueVenda", produto.EstoqueVenda);
                cmd.Parameters.AddWithValue("@MedidaUnidade", produto.MedidaUnidade);
                cmd.Parameters.AddWithValue("@NomeFornecedor", produto.NomeFornecedor);
                cmd.Parameters.AddWithValue("@ContatoFornecedor", produto.ContatoFornecedor);
                cmd.Parameters.AddWithValue("@Cidade", produto.Cidade);
                cmd.Parameters.AddWithValue("@Custo", produto.Custo);
                cmd.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
                cmd.Parameters.AddWithValue("@Lucro", produto.Lucro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}

