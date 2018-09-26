using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urna.DB.Base;

namespace Urna.DB.Candidato
{
    class CandidatoDatabase
    {
        public CandidatoDTO ConsultarCandidadoPorNumero(int n)
        {
            string script = @"SELECT tb_candidato.*, tb_partido.nm_partido, tb_partido.ds_sigra 
                                FROM tb_candidato 
                          INNER JOIN tb_partido 
                                  ON tb_partido_id_partido = id_partido
                               WHERE tb_candidato.nr_candidato = @nr_candidato";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nr_candidato", n));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            CandidatoDTO dto = new CandidatoDTO();
            if (reader.Read())
            {
                dto.ds_cargo = reader.GetString("ds_cargo");
                dto.ds_sigra = reader.GetString("ds_sigra");
                dto.ft_candidato = reader.GetString("ft_candidato");
                dto.id_candidato = reader.GetInt32("id_candidato");
                dto.nm_candidato = reader.GetString("nm_candidato");
                dto.nm_partido = reader.GetString("nm_partido");
                dto.nr_candidato = reader.GetInt32("nr_candidato");
                dto.tb_partido_id_partido = reader.GetInt32("tb_partido_id_partido");
            }

            return dto;
        }
    }
}
