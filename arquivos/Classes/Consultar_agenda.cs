using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPDS_SoftBella.arquivos.Classes
{
    public class Consultar_agenda
    {
        public int Id { get; set; } // id_conAgen
        public string Cpf { get; set; } // cpf_conAgen
        public string Nome { get; set; } // nom_conAgene
        public string Email { get; set; } // email_conAgen
        public string Celular { get; set; } // celular_conAgen
        public int IdPopupFk { get; set; } // id_pop_
    }
}
