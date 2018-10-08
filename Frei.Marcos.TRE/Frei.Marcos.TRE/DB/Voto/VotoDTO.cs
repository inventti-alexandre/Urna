using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.TRE.Db.Voto
{
    class VotoDTO
    {
        public int fk_voto_candidato { get; set; }
        public string nm_candidato { get; set; }
        public string ds_cargo { get; set; }
        public int num_idade { get; set; }
        public int numeroDeVotos { get; set; }
    }
}
