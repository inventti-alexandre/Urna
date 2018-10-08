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
        public CandidatoDTO ConsultarCandidato(int idCandidato, string ds_cargo)
        {
            string script = @"SELECT * FROM tb_candidato WHERE nr_candidato = @nr_candidato AND ds_cargo = @ds_cargo";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nr_candidato", idCandidato));
            parms.Add(new MySqlParameter("ds_cargo", ds_cargo));

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
                candidato.num_idade = reader.GetInt32("num_idade");
            }

            reader.Close();
            return candidato;
        }

        public bool VerificarVoto()
        {
            string script = @"SELECT ds_cargo FROM tb_voto JOIN tb_candidato ON fk_voto_candidato = id_candidato WHERE ds_cargo = 'Presidente' GROUP BY ds_cargo LIMIT 1";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            bool votos = false;
            if (reader.Read())
                votos = true;

            reader.Close();
            return votos;
        }

        public List<VotoDTO> ConsultarPresidente()
        {
            string script = @" SELECT nr_candidato, fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(1) qtd_votos
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Presidente'
  GROUP BY fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade
  ORDER BY COUNT(1) DESC, num_idade DESC
     LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.nr_candidato = reader.GetInt32("nr_candidato");
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("qtd_votos");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }

        public List<VotoDTO> ConsultarBrancos()
        {
            string script = @" SELECT nr_candidato, fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(1) qtd_votos
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Branco'
  GROUP BY fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade
  ORDER BY COUNT(1) DESC, num_idade DESC
     LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.nr_candidato = reader.GetInt32("nr_candidato");
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("qtd_votos");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }

        public List<VotoDTO> ConsultarNulos()
        {
            string script = @" SELECT nr_candidato, fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(1) qtd_votos
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Nulo'
  GROUP BY fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade
  ORDER BY COUNT(1) DESC, num_idade DESC
     LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.nr_candidato = reader.GetInt32("nr_candidato");
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("qtd_votos");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }

        public List<VotoDTO> ConsultarGovernador()
        {
            string script = @" SELECT nr_candidato, fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(1) qtd_votos
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Governador'
  GROUP BY fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade
  ORDER BY COUNT(1) DESC, num_idade DESC
     LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.nr_candidato = reader.GetInt32("nr_candidato");
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("qtd_votos");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }

        public List<VotoDTO> ConsultarSenador()
        {
            string script = @" SELECT nr_candidato, fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(1) qtd_votos
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Senador'
  GROUP BY fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade
  ORDER BY COUNT(1) DESC, num_idade DESC
     LIMIT 2";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.nr_candidato = reader.GetInt32("nr_candidato");
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("qtd_votos");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }

        public List<VotoDTO> ConsultarDeputadoFederal()
        {
            string script = @" SELECT nr_candidato, fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(1) qtd_votos
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Deputado Federal'
  GROUP BY fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade
  ORDER BY COUNT(1) DESC, num_idade DESC
     LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.nr_candidato = reader.GetInt32("nr_candidato");
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("qtd_votos");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }

        public List<VotoDTO> ConsultarDeputadoEstadual()
        {
            string script = @" SELECT nr_candidato, fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade, count(1) qtd_votos
      FROM tb_voto 
      JOIN tb_candidato 
		ON fk_voto_candidato = id_candidato 
	 WHERE ds_cargo = 'Deputado Estadual'
  GROUP BY fk_voto_candidato, tb_candidato.nm_candidato, tb_candidato.ds_cargo, tb_candidato.num_idade
  ORDER BY COUNT(1) DESC, num_idade DESC
     LIMIT 1";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<VotoDTO> votos = new List<VotoDTO>();
            while (reader.Read())
            {
                VotoDTO voto = new VotoDTO();
                voto.nr_candidato = reader.GetInt32("nr_candidato");
                voto.fk_voto_candidato = reader.GetInt32("fk_voto_candidato");
                voto.nm_candidato = reader.GetString("nm_candidato");
                voto.ds_cargo = reader.GetString("ds_cargo");
                voto.num_idade = reader.GetInt32("num_idade");
                voto.numeroDeVotos = reader.GetInt32("qtd_votos");

                votos.Add(voto);
            }

            reader.Close();
            return votos;
        }
    }
}
