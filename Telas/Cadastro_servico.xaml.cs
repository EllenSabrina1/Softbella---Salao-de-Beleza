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
          CadastroFuncionario window = new CadastroFuncionario();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Relatorio_servico window = new Relatorio_servico();
            window.Show();
        }
    }
}
