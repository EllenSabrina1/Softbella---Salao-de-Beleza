using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Agenda_RapidaDAO
    {
        private string connectionString;

        public Agenda_RapidaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Agenda_Rapida agenda)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Agenda_Rapida (id_agen, nome_agen, hora_agen, tempo_agen, servico_agen, profissional_agen) " +
                               "VALUES (@Id, @Nome, @Hora, @Tempo, @Servico, @Profissional)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", agenda.Id);
                cmd.Parameters.AddWithValue("@Nome", agenda.Nome);
                cmd.Parameters.AddWithValue("@Hora", agenda.Hora);
                cmd.Parameters.AddWithValue("@Tempo", agenda.Tempo);
                cmd.Parameters.AddWithValue("@Servico", agenda.Servico);
                cmd.Parameters.AddWithValue("@Profissional", agenda.Profissional);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Agenda_Rapida agenda)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Agenda_Rapida SET nome_agen = @Nome, hora_agen = @Hora, " +
                               "tempo_agen = @Tempo, servico_agen = @Servico, profissional_agen = @Profissional " +
                               "WHERE id_agen = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", agenda.Id);
                cmd.Parameters.AddWithValue("@Nome", agenda.Nome);
                cmd.Parameters.AddWithValue("@Hora", agenda.Hora);
                cmd.Parameters.AddWithValue("@Tempo", agenda.Tempo);
                cmd.Parameters.AddWithValue("@Servico", agenda.Servico);
                cmd.Parameters.AddWithValue("@Profissional", agenda.Profissional);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Agenda_Rapida WHERE id_agen = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Agenda_Rapida BuscarPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Agenda_Rapida WHERE id_agen = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Agenda_Rapida
                        {
                            Id = (int)reader["id_agen"],
                            Nome = reader["nome_agen"].ToString(),
                            Hora = (TimeSpan)reader["hora_agen"],
                            Tempo = (TimeSpan)reader["tempo_agen"],
                            Servico = reader["servico_agen"].ToString(),
                            Profissional = reader["profissional_agen"].ToString()
                        };
                    }
                }
            }
            return null; // Retorna null se não encontrar
        }

        public List<Agenda_Rapida> BuscarTodos()
        {
            List<Agenda_Rapida> agendas = new List<Agenda_Rapida>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Agenda_Rapida";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        agendas.Add(new Agenda_Rapida
                        {
                            Id = (int)reader["id_agen"],
                            Nome = reader["nome_agen"].ToString(),
                            Hora = (TimeSpan)reader["hora_agen"],
                            Tempo = (TimeSpan)reader["tempo_agen"],
                            Servico = reader["servico_agen"].ToString(),
                            Profissional = reader["profissional_agen"].ToString()
                        });
                    }
                }
            }
            return agendas; // Retorna a lista de agendamentos
        }
    }
}
