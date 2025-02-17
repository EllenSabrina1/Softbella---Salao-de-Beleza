using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Servico
    {
        public int Id { get; set; } // id_ser
        public string Grupo { get; set; } // grupo_ser
        public string NomeServico { get; set; } // nome_servico_ser
        public string TempoNecessario { get; set; } // tempo_necessario_ser
        public string Profissional { get; set; } // profissional_ser
        public string ValorVista { get; set; } // valor_vista_ser
        public string ValorPrazo { get; set; } // valor_prazo_ser
        public string ProdutosUtilizados { get; set; } // produtos_utilizados_ser
        public int IdFuncionarioFk { get; set; } // id_fun_fk
    }
}
