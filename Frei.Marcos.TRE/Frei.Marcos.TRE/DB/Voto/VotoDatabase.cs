using Frei.Marcos.TRE.Db.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.TRE.Db.Voto
{
    class VotoDatabase
    {
        public CandidatoDTO ConsultarCandidato(int idCandidato)
        {
            string script = @"SELECT * FROM tb_candidato WHERE id_candidato = @id_candidato";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_candidato", idCandidato));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            CandidatoDTO candidato = new CandidatoDTO();
            if (reader.Read())
            {
                candidato.id_candidato = reader.GetInt32("id_candidato");
                candidato.nm_candidato = reader.GetString("nm_candidato");
                candidato.nr_candidato = reader.GetInt32("nr_candidato");
                candidato.ft_candidato = reader.GetString("ft_candidato");
                candidato.ds_cargo = reader.GetString("ds_cargo");
                candidato.tb_partido_id_partido = reader.GetInt32("tb_partido_id_partido");
                //candidato.num_idade = reader.GetInt32("num_idade");
            }

            reader.Close();
            return candidato;
        }

        public List<VotoDTO> ConsultarPresidente()
        {
            string script = @"SELECT fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(nr_candidato)
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Presidente'
  GROUP BY fk_voto_candidato
  ORDER BY (SELECT MAX(nr_candidato))
       AND num_idade;";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                //voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("count(nr_candidato)");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }
    }
}
