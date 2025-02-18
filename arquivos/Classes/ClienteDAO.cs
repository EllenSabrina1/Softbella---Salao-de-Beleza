using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ClienteDAO
    {
        private static Conexao _Conn = new Conexao();

        public void Insert(Cliente obj)
        {
            try
            {
                var comando = _Conn.Query();
                comando.CommandText = "INSERT INTO Cliente (cpf_cli, rg_cli, telefone_cli, email_cli, nome_cli, cidade_cli, rua_cli, bairro_cli, numero_cli, sexo_cli, tipo_cabelo_cli, data_nasc_cli, observacoes_cli) " +
                                      "VALUES (@cpf, @rg, @telefone, @email, @nome, @cidade, @rua, @bairro, @numero, @sexo, @tipoCabelo, @dataNascimento, @observacoes);";

                comando.Parameters.AddWithValue("@cpf", obj.cpf);
                comando.Parameters.AddWithValue("@rg", obj.rg);
                comando.Parameters.AddWithValue("@telefone", obj.telefone);
                comando.Parameters.AddWithValue("@email", obj.email);
                comando.Parameters.AddWithValue("@nome", obj.nome);
                comando.Parameters.AddWithValue("@cidade", obj.cidade);
                comando.Parameters.AddWithValue("@rua", obj.rua);
                comando.Parameters.AddWithValue("@bairro", obj.bairro);
                comando.Parameters.AddWithValue("@numero", obj.numero);
                comando.Parameters.AddWithValue("@sexo", obj.sexo);
                comando.Parameters.AddWithValue("@tipoCabelo", obj.tipo_cabelo);
                comando.Parameters.AddWithValue("@dataNascimento", obj.data_nasc);
                comando.Parameters.AddWithValue("@observacoes", obj.observacoes);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public void Update(Cliente obj)
        {
            try
            {
                var comando = _Conn.Query();
                comando.CommandText = "UPDATE Cliente SET cpf_cli = @cpf, rg_cli = @rg, telefone_cli = @telefone, email_cli = @email, nome_cli = @nome, cidade_cli = @cidade, " +
                                      "rua_cli = @rua, bairro_cli = @bairro, numero_cli = @numero, sexo_cli = @sexo, tipo_cabelo_cli = @tipoCabelo, data_nasc_cli = @dataNascimento, " +
                                      "observacoes_cli = @observacoes WHERE id_cli = @id;";

                comando.Parameters.AddWithValue("@cpf", obj.cpf);
                comando.Parameters.AddWithValue("@rg", obj.rg);
                comando.Parameters.AddWithValue("@telefone", obj.telefone);
                comando.Parameters.AddWithValue("@email", obj.email);
                comando.Parameters.AddWithValue("@nome", obj.nome);
                comando.Parameters.AddWithValue("@cidade", obj.cidade);
                comando.Parameters.AddWithValue("@rua", obj.rua);
                comando.Parameters.AddWithValue("@bairro", obj.bairro);
                comando.Parameters.AddWithValue("@numero", obj.numero);
                comando.Parameters.AddWithValue("@sexo", obj.sexo);
                comando.Parameters.AddWithValue("@tipoCabelo", obj.tipo_cabelo);
                comando.Parameters.AddWithValue("@dataNascimento", obj.data_nasc);
                comando.Parameters.AddWithValue("@observacoes", obj.observacoes);
                comando.Parameters.AddWithValue("@id", obj.Id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao atualizar as informações");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar : " + ex.Message, ex);
            }
        }

        public void Delete(Cliente obj)
        {
            try
            {
                var comando = _Conn.Query();

                comando.CommandText = "DELETE FROM Cliente WHERE id_cli = @id;";

                comando.Parameters.AddWithValue("@id", obj.Id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao excluir as informações.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                var comando = _Conn.Query();
                comando.CommandText = "SELECT cpf_cli, telefone_cli, email_cli, nome_cli FROM Cliente;"; 

                MySqlDataReader reader = comando.ExecuteReader();

                
                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        cpf = reader.GetString("cpf_cli"),
                        telefone = reader.GetString("telefone_cli"),
                        email = reader.GetString("email_cli"),
                        nome = reader.GetString("nome_cli")
                    };
                    clientes.Add(cliente);
                }

                reader.Close(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clientes;

        }


    }

    public class ClienteDTO : INotifyPropertyChanged
    {
        private static Conexao _conn = new Conexao();

        private bool _selecionado;
        public bool Selecionado
        {
            get { return _selecionado; }
            set
            {
                if (_selecionado != value)
                {
                    _selecionado = value;
                    OnPropertyChanged(nameof(Selecionado)); 
                }
            }
        }

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                var comando = _conn.Query(); 
                comando.CommandText = "SELECT cpf_cli, telefone_cli, email_cli, nome_cli FROM Cliente;"; 

                MySqlDataReader reader = comando.ExecuteReader();

               
                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        cpf = reader.GetString("cpf_cli"),
                        telefone = reader.GetString("telefone_cli"),
                        email = reader.GetString("email_cli"),
                        nome = reader.GetString("nome_cli")
                    };
                    clientes.Add(cliente);
                }

                reader.Close(); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return clientes;

        }

    }

}

