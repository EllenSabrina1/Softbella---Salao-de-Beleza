using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Funcionario
    {
        public int Id { get; set; } // id_fun
        public string Cpf { get; set; } // cpf_fun
        public string Rg { get; set; } // rg_fun
        public string Telefone { get; set; } // telefone_fun
        public string Email { get; set; } // email_fun
        public string Nome { get; set; } // nome_fun
        public string Cidade { get; set; } // cidade_fun
        public string Rua { get; set; } // rua_fun
        public string Bairro { get; set; } // bairro_fun
        public string Numero { get; set; } // numero_fun
        public string Sexo { get; set; } // sexo_fun
        public DateTime DataNasc { get; set; } // data_nasc_fun
        public string AreaAtuacao { get; set; } // area_atuacao_fun

        class Program
        {
            static void Main(string[] args)
            {
                // Criando uma nova instância de Funcionario
                Funcionario funcionario = new Funcionario
                {
                    Id = 1,
                    Cpf = "123.456.789-00",
                    Rg = "12.345.678-9",
                    Telefone = "(11) 98765-4321",
                    Email = "funcionario@example.com",
                    Nome = "Maria da Silva",
                    Cidade = "Rio de Janeiro",
                    Rua = "Rua Exemplo",
                    Bairro = "Bairro Exemplo",
                    Numero = "456",
                    Sexo = "Feminino",
                    DataNasc = new DateTime(1985, 5, 15),
                    AreaAtuacao = "Desenvolvimento de Software"
                };

                // Exibindo os dados do funcionario
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Email: {funcionario.Email}");
                Console.WriteLine($"Data de Nascimento: {funcionario.DataNasc.ToShortDateString()}");
                Console.WriteLine($"Área de Atuação: {funcionario.AreaAtuacao}");
            }
        }

    }
}
