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
    /// Lógica interna para Agendamento.xaml
    /// </summary>
    public partial class Agendamento : Window
    {
        public Agendamento()
        {
            InitializeComponent();
            CarregarClientes();
        }

        private void CarregarClientes()
        {
            try
            {
                ClienteDTO clienteDTO = new ClienteDTO();
                List<Cliente> clientes = clienteDTO.GetClientes();

                if (clientes.Count > 0)
                {
                    dgCliente.ItemsSource = clientes;
                }
                else
                {
                    MessageBox.Show("Nenhum cliente encontrado.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar clientes: {ex.Message}");
            }


        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Agenda_Rapida window = new Agenda_Rapida();
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            popup_agendar popup_Agendar = new popup_agendar();
            popup_Agendar.Show();
        }

        private void SaveButton_Click1(object sender, RoutedEventArgs e)
        {
            Consultar_Agenda consultar_Agenda = new Consultar_Agenda();
            consultar_Agenda.Show();
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Receber receber = new Receber();
            receber.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
            this.Close();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ConsultaFichaAnaminetica consultaFichaAnaminetica = new ConsultaFichaAnaminetica();
            consultaFichaAnaminetica.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Relatorio_servico relatorio_Servico = new Relatorio_servico();
            relatorio_Servico.Show();
            this.Close();
        }
    }
}
