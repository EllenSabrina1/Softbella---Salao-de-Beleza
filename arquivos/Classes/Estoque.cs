using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Estoque
    {
        public int Id { get; set; } // id_est
        public string Nome { get; set; } // nome_est
        public string Marca { get; set; } // marca_est
        public string Grupo { get; set; } // grupo_est
        public string Produto { get; set; } // produto_est
        public string Quantidade { get; set; } // quantidade_est
        public string Fracionar { get; set; } // fracionar_est
        public double Custo { get; set; } // custo_est
        public int Lucro { get; set; } // lucro_est
        public string Fornecedor { get; set; } // fornecedor_est
        public string ContatoFornecedor { get; set; } // contato_fornecedor_est
        public string EmailFornecedor { get; set; } // email_fornecedor
        public int IdProdutoFk { get; set; } // id_pro_fk
    }
}
