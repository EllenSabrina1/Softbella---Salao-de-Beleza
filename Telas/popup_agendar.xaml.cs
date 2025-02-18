using ProjetoPDS_SoftBella.arquivos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoPDS_SoftBella.Telas
{
    /// <summary>
    /// Lógica interna para popup_agendar.xaml
    /// </summary>
    public partial class popup_agendar : Window
    {
        public popup_agendar()
        {
            InitializeComponent();
        }

        private PopUpAgendar procedimento_ = new PopUpAgendar();
        private PopUpAgendarDAO procedimentoDAO_ = new PopUpAgendarDAO(); 

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                procedimento_.dia = DateTime.Parse(dt_dia.Text);
                procedimento_.retorno = DateTime.Parse(dt_retorno.Text);
                procedimento_.servico = cb_servico.Text;

                procedimento_.horario = txt_horario.Text;
                procedimento_.profissional = cb_profissional.Text;

                procedimento_.tempo = txt_tempo.Text;
                procedimento_.observacoes = txt_obs.Text;

                procedimentoDAO_.Insert(procedimento_); // Insere no banco
                MessageBox.Show("Usuario cadastrado com sucesso.");

                Consultar_Agenda inicioc = new Consultar_Agenda();
                inicioc.Show();
                this.Close(); // Fecha a janela atual
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados: {ex.Message}");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

    }
}
