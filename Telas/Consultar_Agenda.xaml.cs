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
    /// Lógica interna para Consultar_Agenda.xaml
    /// </summary>
    public partial class Consultar_Agenda : Window
    {
        public Consultar_Agenda()
        {
            InitializeComponent();
            Carregaragenda();
        }

        private void Carregaragenda()
        {
            PopUpAgendarDAO Dao = new PopUpAgendarDAO();
            List<PopUpAgendar> agendas = Dao.GetPop();

            Agendamentos.ItemsSource = agendas;

        }

        private void Agendamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PopUpAgendarDAO dao = new PopUpAgendarDAO();
            List<PopUpAgendar> agendas = dao.GetPop();

            Agendamentos.ItemsSource = agendas;
        }

        private void Voltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow inicio = new MainWindow(); // Instancia a janela anterior
            inicio.Show(); // Exibe a janela anterior
            this.Close(); // Fecha a janela atual
        }

        private void EditarAgendamento_Click(object sender, RoutedEventArgs e)
        {
            // Pega o agendamento selecionado
            var agendamento = (sender as Button).CommandParameter as PopUpAgendar;
            if (agendamento != null)
            {
                // Lógica para editar
                MessageBox.Show($"Editar Agendamento: {agendamento.id}");
            }
        }

        // Evento para o botão Excluir
        private void ExcluirAgendamento_Click(object sender, RoutedEventArgs e)
        {
            // Pega o agendamento selecionado
            var agendamento = (sender as Button).CommandParameter as PopUpAgendar;
            if (agendamento != null)
            {
                // Lógica para excluir
                MessageBox.Show($"Excluir Agendamento: {agendamento.id}");
            }
        }

        private void btnAgendar_Click(object sender, RoutedEventArgs e)
        {

        }
    

    private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
            this.Close();
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
            CadastrarEstoque cadastrarEstoque = new CadastrarEstoque();
            cadastrarEstoque.Show();
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
