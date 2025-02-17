using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Consultar_agendaDAO
    {
        private string connectionString;

        public Consultar_agendaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Consultar_agenda agenda)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO consultar_agenda (cpf_conAgen, nom_conAgene, email_conAgen, celular_conAgen, id_pop_fk) " +
                               "VALUES (@Cpf, @Nome, @Email, @Celular, @IdPopupFk)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cpf", agenda.Cpf);
                cmd.Parameters.AddWithValue("@Nome", agenda.Nome);
                cmd.Parameters.AddWithValue("@Email", agenda.Email);
                cmd.Parameters.AddWithValue("@Celular", agenda.Celular);
                cmd.Parameters.AddWithValue("@IdPopupFk", agenda.IdPopupFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Consultar_agenda agenda)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE consultar_agenda SET nom_conAgene = @Nome, email_conAgen = @Email, " +
                               "celular_conAgen = @Celular, id_pop_fk = @IdPopupFk WHERE cpf_conAgen = @Cpf";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cpf", agenda.Cpf);
                cmd.Parameters.AddWithValue("@Nome", agenda.Nome);
                cmd.Parameters.AddWithValue("@Email", agenda.Email);
                cmd.Parameters.AddWithValue("@Celular", agenda.Celular);
                cmd.Parameters.AddWithValue("@IdPopupFk", agenda.IdPopupFk);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar(string cpf)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM consultar_agenda WHERE cpf_conAgen = @Cpf";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cpf", cpf);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Consultar_agenda BuscarPorCpf(string cpf)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM consultar_agenda WHERE cpf_conAgen = @Cpf";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Cpf", cpf);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Consultar_agenda
                        {
                            Id = (int)reader["id_conAgen"],
                            Cpf = reader["cpf_conAgen"].ToString(),
                            Nome = reader["nom_conAgene"].ToString(),
                            Email = reader["email_conAgen"].ToString(),
                            Celular = reader["celular_conAgen"].ToString(),
                            IdPopupFk = (int)reader["id_pop_fk"]
                        };
                    }
                }
            }
            return null; // Retorna null se não encontrar
        }

    }
}
