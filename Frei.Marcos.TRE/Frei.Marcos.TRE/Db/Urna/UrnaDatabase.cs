using Frei.Marcos.TRE.Db.Base;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.Marcos.TRE.Db.Urna
{
    class UrnaDatabase
    {
        public void LiberarUrna(UrnaDTO dto)
        {
            string script = @"UPDATE tb_urna SET id_eleitor = @id_eleitor, ds_situacao = @ds_situacao WHERE id_urna = @id_urna";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_eleitor", dto.id_eleitor));
            parms.Add(new MySqlParameter("ds_situacao", true));
            parms.Add(new MySqlParameter("id_urna", dto.id_urna));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void AtualizarEleitor(int idEleitor)
        {
            string script = @"UPDATE tb_eleitor SET ds_situacao = @ds_situacao WHERE id_eleitor = @id_eleitor";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_situacao", true));
            parms.Add(new MySqlParameter("id_eleitor", idEleitor));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public bool VerificarUrna(int idUrna)
        {
            string script = @"SELECT * FROM tb_urna WHERE id_urna = @id_urna";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_urna", idUrna));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if (reader.Read())
            {
                bool situacao = reader.GetBoolean("ds_situacao");

                if (situacao == true)
                {
                    reader.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    return true;
                }
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public bool VerificarEleitor(int idEleitor)
        {
            string script = @"SELECT ds_situacao FROM tb_eleitor WHERE id_eleitor = @id_eleitor LIMIT 1;";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_eleitor", idEleitor));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if (reader.Read())
            {
                bool situacao = reader.GetBoolean("ds_situacao");

                if (situacao == true)
                {
                    reader.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    return true;
                }
            }
            else
            {
                reader.Close();
                return false;
            }
        }
    }
}
