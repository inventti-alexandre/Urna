using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.TRE.Db.Urna
{
    class UrnaBusiness
    {
        public void LiberarUrna(UrnaDTO dto)
        {
            UrnaDatabase db = new UrnaDatabase();
            db.LiberarUrna(dto);
        }
    }
}
