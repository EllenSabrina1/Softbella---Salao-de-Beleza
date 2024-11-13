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
    /// Lógica interna para Cadastro_servico.xaml
    /// </summary>
    public partial class Cadastro_servico : Window
    {
        public Cadastro_servico()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Agendamento window = new Agendamento();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
          Relatorio_servico relatorio_Servico = new Relatorio_servico();
            relatorio_Servico.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           Receber receber = new Receber();
            receber.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
           ConsultarCliente consultarCliente = new ConsultarCliente();
            consultarCliente.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
           ConsultaFichaAnaminetica consultaFichaAnaminetica = new ConsultaFichaAnaminetica();
            consultaFichaAnaminetica.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }
    }
}
