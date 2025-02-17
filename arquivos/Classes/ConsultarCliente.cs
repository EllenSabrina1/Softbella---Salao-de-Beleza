using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class ConsultarCliente
    {
        public int Id { get; set; } // id_con_cli
        public string Nome { get; set; } // nome_con_cli
        public string Rg { get; set; } // rg_con_cli
        public string Rua { get; set; } // rua_con_cli
        public int Numero { get; set; } // num_con_cli
        public string Bairro { get; set; } // bairro_con_cli
        public string Cidade { get; set; } // cidade_con_cli
        public int IdClienteFk { get; set; } // id_con_cli_fk
    }
}
