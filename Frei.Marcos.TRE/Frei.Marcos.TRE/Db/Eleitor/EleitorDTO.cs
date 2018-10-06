using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.TRE.Db.Eleitor
{
    class EleitorDTO
    {
        public int id_eleitor { get; set; }
        public string nm_nome { get; set; }
        public DateTime dt_nascimento { get; set; }
        public string nr_inscricao { get; set; }
        public int nr_zona { get; set; }
        public int nr_secao { get; set; }
        public string nm_municipio { get; set; }
        public string nm_uf { get; set; }
        public string nr_rg { get; set; }
    }
}
