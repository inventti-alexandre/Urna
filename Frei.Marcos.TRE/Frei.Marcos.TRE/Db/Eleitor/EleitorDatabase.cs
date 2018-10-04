using Frei.Marcos.TRE.Db.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.TRE.Db.Eleitor
{
    class EleitorDatabase
    {
        public void CadastrarEleitor(EleitorDTO dto)
        {
            string script = @"INSERT tb_eleitor(nm_nome, dt_nascimento, nr_inscricao, nr_zona, nr_secao, nm_municipio, nm_uf, nr_rg)
                                         VALUES(@nm_nome, @dt_nascimento, @nr_inscricao, @nr_zona, @nr_secao, @nm_municipio, @nm_uf, @nr_rg)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_nome", dto.nm_nome));
            parms.Add(new MySqlParameter("dt_nascimento", dto.dt_nascimento));
            parms.Add(new MySqlParameter("nr_inscricao", dto.nr_inscricao));
            parms.Add(new MySqlParameter("nr_zona", dto.nr_zona));
            parms.Add(new MySqlParameter("nr_secao", dto.nr_secao));
            parms.Add(new MySqlParameter("nm_municipio", dto.nm_municipio));
            parms.Add(new MySqlParameter("nm_uf", dto.nm_uf));
            parms.Add(new MySqlParameter("nr_rg", dto.nr_rg));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public EleitorDTO Consultar(int n)
        {
            string script = @"SELECT * FROM tb_eleitor WHERE nr_inscricao = @nr_inscricao";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nr_inscricao", n));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            EleitorDTO eleitor = new EleitorDTO();
            if (reader.Read())
            {
                eleitor.id_eleitor = reader.GetInt32("id_eleitor");
                eleitor.nm_nome = reader.GetString("nm_nome");
                eleitor.dt_nascimento = reader.GetDateTime("dt_nascimento");
                eleitor.nr_inscricao = reader.GetString("nr_inscricao");
                eleitor.nr_zona = reader.GetInt32("nr_zona");
                eleitor.nr_secao = reader.GetInt32("nr_secao");
                eleitor.nm_municipio = reader.GetString("nm_municipio");
                eleitor.nm_uf = reader.GetString("nm_uf");
                eleitor.nr_rg = reader.GetString("nr_rg");
            }

            reader.Close();
            return eleitor;
        }
    }
}
