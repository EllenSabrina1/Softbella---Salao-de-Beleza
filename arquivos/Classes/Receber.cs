using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Receber
    {
        public int Id { get; set; } // id_receber
        public int IdClienteFk { get; set; } // id_cli_fk
        public double ValorTotal { get; set; } // valor_total
        public double ValorPago { get; set; } // valor_pago
        public double SaldoDevido { get; set; } // saldo_devido
        public DateTime DataVencimento { get; set; } // data_vencimento
        public DateTime? DataPagamento { get; set; } // data_pagamento
        public string StatusPagamento { get; set; } // status_pagamento
        public string FormaPagamento { get; set; } // forma_pagamento
        public string DescricaoRecebimento { get; set; } // descricao_recebimento
        public int IdFuncionarioFk { get; set; } // id_fun_fk
    }
}
