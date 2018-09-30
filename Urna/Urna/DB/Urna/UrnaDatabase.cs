using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urna.DB.Base;

namespace Urna.DB.Urna
{
    class UrnaDatabase
    {
        public bool VerificarUrna()
        {
            string script = @"SELECT * FROM tb_urna WHERE id_urna = @id_urna";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_urna", UrnaControl.Id));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            if (reader.Read())
            {
                UrnaDTO dto = new UrnaDTO();
                dto.id_urna = reader.GetInt32("id_urna");
                dto.id_eleitor = reader.GetInt32("id_eleitor");
                dto.ds_situacao = reader.GetBoolean("ds_situacao");

                if (dto.ds_situacao == true)
                {
                    UrnaControl.id_Eleitor = dto.id_eleitor;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
