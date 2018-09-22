using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.SistemaDeCriacaoDeScript.SCS.DB.Candidatura
{
    class CandidaturaDTO
    {
        public int id_candidato { get; set; }
        public string nm_candidato { get; set; }
        public int nr_candidato { get; set; }
        public string ft_candidato { get; set; }
        public string ds_cargo { get; set; }
        public int tb_partido_id_partido { get; set; }
    }
}
