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
    }
}
