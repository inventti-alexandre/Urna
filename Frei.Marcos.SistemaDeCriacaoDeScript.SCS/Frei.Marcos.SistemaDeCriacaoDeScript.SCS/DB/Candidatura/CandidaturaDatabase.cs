using MySql.Data.MySqlClient;
using Nsf._2018.Modulo3.Logica.Telas.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.SistemaDeCriacaoDeScript.SCS.DB.Candidatura
{
    class CandidaturaDatabase
    {
        public void Registrar(CandidaturaDTO dto)
        {
            string script = @"INSERT tb_candidato(id_candidato, nm_candidato, nr_candidato, ft_candidato, ds_cargo, tb_partido_id_partido)
                                           VALUES(@id_candidato, @nm_candidato, @nr_candidato, @ft_candidato, @ds_cargo, @tb_partido_id_partido)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_candidato", dto.id_candidato));
            parms.Add(new MySqlParameter("nm_candidato", dto.nm_candidato));
            parms.Add(new MySqlParameter("nr_candidato", dto.nr_candidato));
            parms.Add(new MySqlParameter("ft_candidato", dto.ft_candidato));
            parms.Add(new MySqlParameter("ds_cargo", dto.ds_cargo));
            parms.Add(new MySqlParameter("tb_partido_id_partido", dto.tb_partido_id_partido));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
