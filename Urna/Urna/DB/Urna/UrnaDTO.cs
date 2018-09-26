using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.DB.Urna
{
    class UrnaDTO
    {
        public int id_urna { get; set; }
        public DateTime dt_voto { get; set; }
        public int tb_eleitor_id_eleitor { get; set; }
        public int tb_candidato_id_candidato { get; set; }
    }
}
