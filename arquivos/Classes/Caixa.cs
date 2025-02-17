using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Caixa
    {
        public int IdCaixa { get; set; }
        public DateTime DataTransacao { get; set; }
        public string TipoTransacao { get; set; }
        public double ValorTransacao { get; set; }
        public string DescricaoTransacao { get; set; }
        public int IdFunFk { get; set; }
    }
}
