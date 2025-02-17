using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    internal class FuncionarioDAO
    {
        private string connectionString;

        public FuncionarioDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Funcionario funcionario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Funcionario (cpf_fun, rg_fun, telefone_fun, email_fun, nome_fun, cidade_fun, rua_fun, bairro_fun, numero_fun, sexo_fun, data_nasc_fun, area_atuacao_fun) " +
                               "VALUES (@Cpf, @Rg, @Telefone, @Email, @Nome, @Cidade, @Rua, @Bairro, @Numero, @Sexo, @DataNasc, @AreaAtuacao)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@Rg", funcionario.Rg);
                cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
                cmd.Parameters.AddWithValue("@Rua", funcionario.Rua);
                cmd.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
                cmd.Parameters.AddWithValue("@Numero", funcionario.Numero);
                cmd.Parameters.AddWithValue("@Sexo", funcionario.Sexo);
                cmd.Parameters.AddWithValue("@DataNasc", funcionario.DataNasc);
                cmd.Parameters.AddWithValue("@AreaAtuacao", funcionario.AreaAtuacao);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Funcionario funcionario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Funcionario SET cpf_fun = @Cpf, rg_fun = @Rg, telefone_fun = @Telefone, email_fun = @Email, " +
                               "nome_fun = @Nome, cidade_fun = @Cidade, rua_fun = @Rua, bairro_fun = @Bairro, numero_fun = @Numero, " +
                               "sexo_fun = @Sexo, data_nasc_fun = @DataNasc, area_atuacao_fun = @AreaAtuacao WHERE id_fun = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", funcionario.Id);
                cmd.Parameters.AddWithValue("@Cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@Rg", funcionario.Rg);
                cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@Email", funcionario.Email);
                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
                cmd.Parameters.AddWithValue("@Rua", funcionario.Rua);
                cmd.Parameters.AddWithValue("@Bairro", funcionario.Bairro);
                cmd.Parameters.AddWithValue("@Numero", funcionario.Numero);
                cmd.Parameters.AddWithValue("@Sexo", funcionario.Sexo);
                cmd.Parameters.AddWithValue("@DataNasc", funcionario.DataNasc);
                cmd.Parameters.AddWithValue("@AreaAtuacao", funcionario.AreaAtuacao);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}

