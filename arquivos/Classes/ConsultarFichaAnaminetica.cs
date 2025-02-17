using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ConsultarFichaAnaminetica
    {
        public int Id { get; set; }
        public string TipoCabelo { get; set; }
        public string TexturaCabelo { get; set; }
        public string ComprimentoCabelo { get; set; }
        public string CaracteristicasCabelo { get; set; }
        public string DensidadeCabelo { get; set; }
        public bool Gravida { get; set; }
        public string ProcedimentoCapilar3M { get; set; }
        public bool UsaPranchaSecadorModelador { get; set; }
        public bool FrequentouPiscina30D { get; set; }
        public string Alergia { get; set; }
        public string TratamentoMedico { get; set; }
        public string OutroProblemaInfo { get; set; }
    }
}
