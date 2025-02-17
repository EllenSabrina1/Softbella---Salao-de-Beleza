using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Produto
    {
        public int Id { get; set; } // id_pro
        public string Nome { get; set; } // nome_pro
        public string Marca { get; set; } // marca_pro
        public string Grupo { get; set; } // grupo_pro
        public string EstoqueVenda { get; set; } // estoque_venda_pro
        public string MedidaUnidade { get; set; } // medida_unidade_pro
        public string NomeFornecedor { get; set; } // nome_fornecedor_pro
        public string ContatoFornecedor { get; set; } // contato_fornecedor_pro
        public string Cidade { get; set; } // cidade_pro
        public int Custo { get; set; } // custo_pro
        public double PrecoVenda { get; set; } // preco_venda_pro
        public int Lucro { get; set; } // lucro_pro
    }
}
