﻿using ProjetoPDS_SoftBella.Telas;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoPDS_SoftBella
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Cadastro_servico window = new Cadastro_servico();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cadastro_servico window = new Cadastro_servico();
            window.Show();
        }
    }
}
