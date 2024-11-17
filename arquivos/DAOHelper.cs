using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ProjetoPDS_SoftBella.Arquivos.Classes
{
    class ClienteDAO
    {
        private static Conexao _Conn = new Conexao();

        // Propriedades do ClienteDAO
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Sexo { get; set; }
        public string TipoCabelo { get; set; }
        public DateTime? DataNasc { get; set; }

        public void Insert(ClienteDAO clienteDao)
        {
            try
            {
                var comando = _Conn.Query();
                comando.CommandText = "INSERT INTO Cliente (cpf_cli, rg_cli, telefone_cli, email_cli, nome_cli, cidade_cli, " +
                    "rua_cli, bairro_cli, numero_cli, sexo_cli, tipo_cabelo_cli, data_nasc_cli) " +
                    "VALUES (@cpf, @rg, @telefone, @email, @nome, @cidade, @rua, @bairro, @numero, @sexo, @tipo_cabelo, @data_nasc)";

                comando.Parameters.AddWithValue("@cpf", clienteDao.Cpf);
                comando.Parameters.AddWithValue("@rg", clienteDao.Rg);
                comando.Parameters.AddWithValue("@telefone", clienteDao.Telefone);
                comando.Parameters.AddWithValue("@email", clienteDao.Email);
                comando.Parameters.AddWithValue("@nome", clienteDao.Nome);
                comando.Parameters.AddWithValue("@cidade", clienteDao.Cidade);
                comando.Parameters.AddWithValue("@rua", clienteDao.Rua);
                comando.Parameters.AddWithValue("@bairro", clienteDao.Bairro);
                comando.Parameters.AddWithValue("@numero", clienteDao.Numero);
                comando.Parameters.AddWithValue("@sexo", clienteDao.Sexo);
                comando.Parameters.AddWithValue("@tipo_cabelo", clienteDao.TipoCabelo);
                comando.Parameters.AddWithValue("@data_nasc", clienteDao.DataNasc);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações.");
                }
            }
            catch (Exception)
            {
                throw; // Repassa a exceção original
            }
        }

        public List<ClienteDAO> List()
        {
            try
            {
                var lista = new List<ClienteDAO>();
                var comando = _Conn.Query();
                comando.CommandText = "SELECT * FROM Cliente";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var cliente = new ClienteDAO
                    {
                        Id = reader.GetInt32("id_cli"),
                        Cpf = reader.GetString("cpf_cli"),
                        Rg = reader.GetString("rg_cli"),
                        Telefone = reader.GetString("telefone_cli"),
                        Email = reader.GetString("email_cli"),
                        Nome = reader.GetString("nome_cli"),
                        Cidade = reader.GetString("cidade_cli"),
                        Rua = reader.GetString("rua_cli"),
                        Bairro = reader.GetString("bairro_cli"),
                        Numero = reader.GetString("numero_cli"),
                        Sexo = reader.GetString("sexo_cli"),
                        TipoCabelo = reader.GetString("tipo_cabelo_cli"),
                        DataNasc = reader.GetDateTime("data_nasc_cli")
                    };
                    lista.Add(cliente);
                }
                reader.Close();

                return lista;
            }
            catch (Exception)
            {
                throw; // Repassa a exceção original
            }
        }
    }
}
