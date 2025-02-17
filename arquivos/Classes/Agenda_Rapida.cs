using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Agenda_Rapida
    {
        public int Id { get; set; } // id_agen
        public string Nome { get; set; } // nome_agen
        public TimeSpan Hora { get; set; } // hora_agen
        public TimeSpan Tempo { get; set; } // tempo_agen
        public string Servico { get; set; } // servico_agen
        public string Profissional { get; set; } // profissional_agen
    }
}
