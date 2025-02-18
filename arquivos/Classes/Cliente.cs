using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
        public string sexo { get; set; }
        public string tipo_cabelo { get; set; }
        public DateTime? data_nasc { get; set; }
        public string observacoes { get; set; } 
        public Cliente(int id, string cpf, string rg, string telefone, string email, string nome, string cidade, string rua, string bairro, string numero, string sexo, string tipo_cabelo, DateTime? data_nasc, string observacoes)
        {
            Id = id;
            this.cpf = cpf;
            this.rg = rg;
            this.telefone = telefone;
            this.email = email;
            this.nome = nome;
            this.cidade = cidade;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.sexo = sexo;
            this.tipo_cabelo = tipo_cabelo;
            this.data_nasc = data_nasc;
            this.observacoes = observacoes;
        }
        public Cliente()
        {

        }
    }

}
