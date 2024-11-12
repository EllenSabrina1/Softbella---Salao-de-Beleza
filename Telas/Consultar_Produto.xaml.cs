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
    /// Lógica interna para Consultar_Produto.xaml
    /// </summary>
    public partial class Consultar_Produto : Window
    {
        private List<Produto> produtos;

        // CollectionView para manipular os dados no DataGrid
        private CollectionView collectionView;

        public Consultar_Produto()
        {
            InitializeComponent();
            CarregarDados();

        }
        public class Produto
        {
            public int ID { get; set; }
            public string produto { get; set; }
            public string Nome { get; set; }
            public string Marca { get; set; }
            public string UniMedida { get; set; }
            public decimal Custo { get; set; }
            public decimal Lucro { get; set; }
            public TimeSpan Tempo { get; set; }
        }
        private void CarregarDados()
        {
            var produtos = new List<Produto>
            {
                new Produto { ID = 1, produto = "001", Nome = "Shampoo", Marca = "Bella", UniMedida = "Unidade", Custo = 30, Lucro = 10, Tempo = new TimeSpan(0, 5, 0) },
                new Produto { ID = 2, produto = "002", Nome = "Condicionador", Marca = "Bella", UniMedida = "Unidade", Custo = 34, Lucro = 12, Tempo = new TimeSpan(0, 10, 0) },
                new Produto { ID = 3, produto = "003", Nome = "Escova", Marca = "Soft", UniMedida = "Unidade", Custo = 50, Lucro = 40, Tempo = new TimeSpan(0, 2, 0) }
            };

            collectionView = new CollectionView(produtos);

            dataGridProduto.ItemsSource = collectionView;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string termoBusca = txtBusca.Text.ToLower();

            string campoFiltro = string.Empty;
            if (rbProduto.IsChecked == true)
                campoFiltro = "Produto";
            else if (rbNome.IsChecked == true)
                campoFiltro = "Nome";
            else if (rbMarca.IsChecked == true)
                campoFiltro = "Marca";

            // Aplicando o filtro na CollectionView com base no campo selecionado
            collectionView.Filter = item =>
            {
                Produto produto = item as Produto;
                if (produto == null) return false;

                // Comparando o campo escolhido com o termo de busca
                switch (campoFiltro)
                {
                    case "Produto":
                        return produto.produto.ToLower().Contains(termoBusca);
                    case "Nome":
                        return produto.Nome.ToLower().Contains(termoBusca);
                    case "Marca":
                        return produto.Marca.ToLower().Contains(termoBusca);
                    default:
                        return false;
                }
            };
        }
    }
}
