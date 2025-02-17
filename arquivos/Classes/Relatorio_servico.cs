using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Relatorio_servico
    {
        public int Id { get; set; } // id_rel_ser
        public string NomeServico { get; set; } // nome_servico_rel_ser
        public DateTime TempoPrevisto { get; set; } // tempo_previsto_rel_ser
        public string Observacao { get; set; } // observacao_rel_ser
        public string Profissional { get; set; } // profissional_rel_ser
        public double ValorVista { get; set; } // valor_vista_rel_ser
        public double ValorPrazo { get; set; } // valor_prazo_rel_ser
        public int IdServicoFk { get; set; } // id_ser_fk
    }
}
