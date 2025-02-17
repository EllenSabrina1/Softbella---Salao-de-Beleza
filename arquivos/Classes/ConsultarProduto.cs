using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ConsultaProduto
    {
        public int Id { get; set; } // id_con
        public string Produto { get; set; } // produto_con
        public string Nome { get; set; } // nome_con
        public string Marca { get; set; } // marca_con
        public int Quantidade { get; set; } // quantidade_con
        public double Custo { get; set; } // custo_con
        public double Lucro { get; set; } // lucro_con
    }
}
