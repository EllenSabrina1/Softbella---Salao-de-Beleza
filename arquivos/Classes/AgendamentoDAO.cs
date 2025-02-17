using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    internal class AgendamentoDAO
    {

        private string connectionString;

        public AgendamentoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Agendamento agendamento)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO agendamento (cpf_Agdt, nome_Agdt, email_Agdt, celular_Agdt) VALUES (@cpf, @nome, @email, @celular)", connection);
                command.Parameters.AddWithValue("@cpf", agendamento.CpfAgdt);
                command.Parameters.AddWithValue("@nome", agendamento.NomeAgdt);
                command.Parameters.AddWithValue("@email", agendamento.EmailAgdt);
                command.Parameters.AddWithValue("@celular", agendamento.CelularAgdt);
                command.ExecuteNonQuery();
            }
        }

        public void Atualizar(Agendamento agendamento)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE agendamento SET cpf_Agdt = @cpf, nome_Agdt = @nome, email_Agdt = @email, celular_Agdt = @celular WHERE id_Agdt = @id", connection);
                command.Parameters.AddWithValue("@id", agendamento.IdAgdt);
                command.Parameters.AddWithValue("@cpf", agendamento.CpfAgdt);
                command.Parameters.AddWithValue("@nome", agendamento.NomeAgdt);
                command.Parameters.AddWithValue("@email", agendamento.EmailAgdt);
                command.Parameters.AddWithValue("@celular", agendamento.CelularAgdt);
                command.ExecuteNonQuery();
            }
        }

        public void Deletar(int idAgdt)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM agendamento WHERE id_Agdt = @id", connection);
                command.Parameters.AddWithValue("@id", idAgdt);
                command.ExecuteNonQuery();
            }
        }

        public Agendamento BuscarPorId(int idAgdt)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM agendamento WHERE id_Agdt = @id", connection);
                command.Parameters.AddWithValue("@id", idAgdt);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Agendamento
                        {
                            IdAgdt = reader.GetInt32("id_Agdt"),
                            CpfAgdt = reader.GetString("cpf_Agdt"),
                            NomeAgdt = reader.GetString("nome_Agdt"),
                            EmailAgdt = reader.GetString("email_Agdt"),
                            CelularAgdt = reader.GetString("celular_Agdt")
                        };
                    }
                }
            }
            return null;
        }

      
    }
 }
