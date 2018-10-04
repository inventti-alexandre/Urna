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
    }
}
