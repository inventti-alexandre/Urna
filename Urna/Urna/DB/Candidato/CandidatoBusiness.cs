using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.DB.Candidato
{
    class CandidatoBusiness
    {
        public CandidatoDTO ConsultarCandidadoPorNumero(int n)
        {
            CandidatoDatabase db = new CandidatoDatabase();
            return db.ConsultarCandidadoPorNumero(n);
        }

        public CandidatoDTO ConsultarCandidadoPorNumero_Cargo(int n, string cargo)
        {
            CandidatoDatabase db = new CandidatoDatabase();
            return db.ConsultarCandidadoPorNumero_Cargo(n, cargo);
        }
    }
}
