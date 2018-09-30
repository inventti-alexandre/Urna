using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.DB.Voto
{
    class VotoDTO
    {
        public int id_voto { get; set; }
        public int fk_voto_urna { get; set; }
        public int fk_voto_candidato { get; set; }
        public int fk_voto_eleitor { get; set; }
    }
}
