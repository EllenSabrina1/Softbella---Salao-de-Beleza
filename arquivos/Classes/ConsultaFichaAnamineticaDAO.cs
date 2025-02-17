using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    internal class ConsultaFichaAnamineticaDAO
    {

        private string connectionString;

        public ConsultaFichaAnamineticaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(ConsultarFichaAnaminetica ficha)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Ficha_anamnetica (tipo_cabelo, textura_cabelo, comprimento_cabelo, caracteristicas_cabelo, densidade_cabelo, gravida, procedimento_capilar_3m, usa_prancha_secador_modelador, frequentou_piscina_30d, alergia, tratamento_medico, outro_problema_info) VALUES (@tipo_cabelo, @textura_cabelo, @comprimento_cabelo, @caracteristicas_cabelo, @densidade_cabelo, @gravida, @procedimento_capilar_3m, @usa_prancha_secador_modelador, @frequentou_piscina_30d, @alergia, @tratamento_medico, @outro_problema_info)", connection);
                command.Parameters.AddWithValue("@tipo_cabelo", ficha.TipoCabelo);
                command.Parameters.AddWithValue("@textura_cabelo", ficha.TexturaCabelo);
                command.Parameters.AddWithValue("@comprimento_cabelo", ficha.ComprimentoCabelo);
                command.Parameters.AddWithValue("@caracteristicas_cabelo", ficha.CaracteristicasCabelo);
                command.Parameters.AddWithValue("@densidade_cabelo", ficha.DensidadeCabelo);
                command.Parameters.AddWithValue("@gravida", ficha.Gravida);
                command.Parameters.AddWithValue("@procedimento_capilar_3m", ficha.ProcedimentoCapilar3M);
                command.Parameters.AddWithValue("@usa_prancha_secador_modelador", ficha.UsaPranchaSecadorModelador);
                command.Parameters.AddWithValue("@frequentou_piscina_30d", ficha.FrequentouPiscina30D);
                command.Parameters.AddWithValue("@alergia", ficha.Alergia);
                command.Parameters.AddWithValue("@tratamento_medico", ficha.TratamentoMedico);
                command.Parameters.AddWithValue("@outro_problema_info", ficha.OutroProblemaInfo);
                command.ExecuteNonQuery();
            }
        }

        public void Atualizar(ConsultarFichaAnaminetica ficha)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE Ficha_anamnetica SET tipo_cabelo = @tipo_cabelo, textura_cabelo = @textura_cabelo, comprimento_cabelo = @comprimento_cabelo, caracteristicas_cabelo = @caracteristicas_cabelo, densidade_cabelo = @densidade_cabelo, gravida = @gravida, procedimento_capilar_3m = @procedimento_capilar_3m, usa_prancha_secador_modelador = @usa_prancha_secador_modelador, frequentou_piscina_30d = @frequentou_piscina_30d, alergia = @alergia, tratamento_medico = @tratamento_medico, outro_problema_info = @outro_problema_info");
            }
        }
    }
}
