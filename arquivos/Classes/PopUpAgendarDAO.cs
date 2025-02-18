using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class PopUpAgendarDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(PopUpAgendar obj)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "INSERT INTO pop_up_agendar (dia_pop, retorno_pop, serviço_pop, hora_pop, tempo_pop, profissional_pop, observacoes_pop) VALUES (@dia, @retorno, @servico, @horario, @tempo, @profissional, @observacoes);";

                comando.Parameters.AddWithValue("@dia", obj.dia);
                comando.Parameters.AddWithValue("@retorno", obj.retorno);
                comando.Parameters.AddWithValue("@servico", obj.servico);
                comando.Parameters.AddWithValue("@horario", obj.horario);
                comando.Parameters.AddWithValue("@tempo", obj.tempo);
                comando.Parameters.AddWithValue("@profissional", obj.profissional);
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

        public List<PopUpAgendar> GetPop()
        {
            List<PopUpAgendar> agendas = new List<PopUpAgendar>();

            try
            {
                var comando = _conn.Query();
                comando.CommandText = "SELECT id_pop, dia_pop, retorno_pop, serviço_pop, hora_pop, tempo_pop, profissional_pop, observacoes_pop FROM pop_up_agendar; ";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    PopUpAgendar agenda = new PopUpAgendar
                    {
                        id = reader.GetInt32("id_pop"),
                        dia = reader.GetDateTime("dia_pop"),
                        retorno = reader.GetDateTime("retorno_pop"),
                        servico = reader.GetString("serviço_pop"),
                        horario = reader.GetTimeSpan(4).ToString(@"hh\:mm"), // Conversão correta
                        tempo = reader.GetTimeSpan(5).ToString(@"hh\:mm"),
                        profissional = reader.GetString("profissional_pop"),
                        observacoes = reader.GetString("observacoes_pop")
                    };
                    agendas.Add(agenda);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return agendas;
        }
        public void Update(PopUpAgendar obj)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "UPDATE pop_up_agendar SET dia_pop = @dia, retorno_pop = @retorno, serviço_pop = @servico, hora_pop = @horario, tempo_pop = @tempo, profissional_pop = @profissional WHERE id_pop = @id;";

                // Define os parâmetros para a atualização
                comando.Parameters.AddWithValue("@dia", obj.dia);
                comando.Parameters.AddWithValue("@retorno", obj.retorno);
                comando.Parameters.AddWithValue("@servico", obj.servico);
                comando.Parameters.AddWithValue("@horario", obj.horario);
                comando.Parameters.AddWithValue("@tempo", obj.tempo);
                comando.Parameters.AddWithValue("@profissional", obj.profissional);
                comando.Parameters.AddWithValue("@observacoes", obj.observacoes);
                comando.Parameters.AddWithValue("@id", obj.id);



                foreach (PopUpAgendar str in GetPop())
                {
                    if (str.id == obj.id)
                    {
                        comando.Parameters.AddWithValue("@id", str.id);
                    }
                }

                // Executa o comando e verifica o resultado
                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao atualizar as informações");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar: " + ex.Message, ex);
            }
        }
        public void Delete(PopUpAgendar obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "delete from pop_up_agendar where id_pop = @id;";

                comando.Parameters.AddWithValue("@id", obj.id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
