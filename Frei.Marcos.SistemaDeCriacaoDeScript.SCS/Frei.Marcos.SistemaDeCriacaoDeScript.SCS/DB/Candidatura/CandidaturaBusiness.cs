using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.SistemaDeCriacaoDeScript.SCS.DB.Candidatura
{
    class CandidaturaBusiness
    {
        public void Registrar(CandidaturaDTO dto)
        {
            CandidaturaDatabase db = new CandidaturaDatabase();
            db.Registrar(dto);
        }
    }
}
