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
    /// Lógica interna para CadastroProduto.xaml
    /// </summary>
    public partial class CadastroProduto : Window
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Caixa caixa = new Caixa();
            caixa.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Receber receber = new Receber();
            receber.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CadastrarEstoque cadastrarEstoque = new CadastrarEstoque(); 
            cadastrarEstoque.Show();    
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ConsultaFichaAnaminetica consultaFichaAnaminetica = new ConsultaFichaAnaminetica();
            consultaFichaAnaminetica.Show();
            this.Close();
        }
    }
}
