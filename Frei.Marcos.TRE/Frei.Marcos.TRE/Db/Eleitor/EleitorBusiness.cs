using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.TRE.Db.Eleitor
{
    class EleitorBusiness
    {
        public void CadastrarEleitor(EleitorDTO dto)
        {
            EleitorDatabase db = new EleitorDatabase();
            db.CadastrarEleitor(dto);
        }

        public EleitorDTO Consultar(int n)
        {
            EleitorDatabase db = new EleitorDatabase();
            return db.Consultar(n);
        }
    }
}
