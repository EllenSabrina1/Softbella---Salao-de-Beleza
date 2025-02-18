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
    /// Lógica interna para CadastroDeCliente.xaml
    /// </summary>


    public partial class CadastroDeCliente : Window
    {

        private Cliente cliente_ = new Cliente(); // Objeto cliente
        private ClienteDAO clienteDAO_ = new ClienteDAO(); // Objeto responsável por acessar o banco de dados
        public CadastroDeCliente()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked4(object sender, RoutedEventArgs e)
        {
            cliente_.tipo_cabelo = "Liso"; // Atribui "Liso" quando esse radio button for selecionado
        }

        private void RadioButton_Checked5(object sender, RoutedEventArgs e)
        {
            cliente_.tipo_cabelo = "Ondulado"; // Atribui "Ondulado" quando esse radio button for selecionado
        }

        private void RadioButton_Checked6(object sender, RoutedEventArgs e)
        {
            cliente_.tipo_cabelo = "Cacheado"; // Atribui "Cacheado" quando esse radio button for selecionado
        }

        private void RadioButton_Checked7(object sender, RoutedEventArgs e)
        {
            cliente_.tipo_cabelo = "Crespo"; // Atribui "Crespo" quando esse radio button for selecionado
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cliente_.sexo = "Masculino"; // Atribui "Masculino" quando esse radio button for selecionado
        }

        // Método chamado quando o RadioButton "Feminino" é selecionado
        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            cliente_.sexo = "Feminino"; // Atribui "Feminino" quando esse radio button for selecionado
        }

        // Método chamado quando o RadioButton "Outro" é selecionado
        private void RadioButton_Checked3(object sender, RoutedEventArgs e)
        {
            cliente_.sexo = "Outro"; // Atribui "Outro" quando esse radio button for selecionado
        }

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Preenche os dados do cliente a partir da interface

                cliente_.nome = txt_nome.Text;
                cliente_.cpf = txt_cpf.Text;
                cliente_.rg = txt_rg.Text;
                cliente_.telefone = txt_telefone.Text;
                cliente_.email = txt_email.Text;
                cliente_.cidade = txt_cidade.Text;
                cliente_.rua = txt_rua.Text;
                cliente_.bairro = txt_bairro.Text;
                cliente_.numero = txt_numero.Text;
                //cliente_.sexo = rb_masculino.IsChecked == true ? "Masculino" : "Feminino"; // RadioButton para sexo

                if (rb_masculino.IsChecked == true)
                {
                    cliente_.sexo = "Masculino";
                }
                else if (rb_feminino.IsChecked == true)
                {
                    cliente_.sexo = "Feminino";
                }

                else if (rb_outro.IsChecked == true)
                {
                    cliente_.sexo = "Outro";
                }



                //cliente_.tipoCabelo = rb_liso.IsChecked == true ? "Liso" : "Cacheado"; // RadioButton para tipo de cabelo

                if (rb_liso.IsChecked == true)
                {
                    cliente_.tipo_cabelo = "Liso";
                }
                else if (rb_ondulado.IsChecked == true)
                {
                    cliente_.tipo_cabelo = "Ondulado";
                }
                else if (rb_cacheado.IsChecked == true)
                {
                    cliente_.tipo_cabelo = "Cacheado";
                }
                else if (rb_crespo.IsChecked == true)
                {
                    cliente_.tipo_cabelo = "Crespo";
                }

                cliente_.data_nasc = DateTime.Parse(dt_nascimento.Text);
                cliente_.observacoes = txt_observacoes.Text;

                // Insere os dados no banco
                clienteDAO_.Insert(cliente_);
                MessageBox.Show("Cliente cadastrado com sucesso.");

                Agendamento listaCli = new Agendamento(); // Instancia a janela de consulta
                listaCli.Show(); // Exibe a janela de consulta
                this.Close(); // Fecha a janela atual
            }



            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados: {ex.Message}");
            }
        }


        ///-----

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroDeCliente cadastroDeCliente = new CadastroDeCliente();
            cadastroDeCliente.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Consultar_Agenda consultar_Agenda = new Consultar_Agenda();
            consultar_Agenda.Show();
            this.Close();
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
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
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

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

    }
    
}
