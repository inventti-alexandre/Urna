using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.DB.Urna
{
    class UrnaBusiness
    {
        public bool VerificarUrna()
        {
            UrnaDatabase db = new UrnaDatabase();
            return db.VerificarUrna();
        }
    }
}
