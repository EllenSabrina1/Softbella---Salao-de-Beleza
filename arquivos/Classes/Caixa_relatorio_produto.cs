using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Caixa_relatorio_produto
    {
       
            public int IdRelatorio { get; set; } // id_relatorio
            public int IdProdutoFk { get; set; } // id_pro_fk
            public DateTime DataRelatorio { get; set; } // data_relatorio
            public string TipoMovimentacao { get; set; } // tipo_movimentacao
            public int QuantidadeMovimentada { get; set; } // quantidade_movimentada
            public double ValorUnitario { get; set; } // valor_unitario
            public double ValorTotal { get; set; } // valor_total
            public int IdFuncionarioFk { get; set; } // id_fun_fk
        
    }

}

