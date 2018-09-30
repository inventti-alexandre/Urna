using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urna.DB.Base;

namespace Urna.DB.Voto
{
    class VotoDatabase
    {
        public void Votar(VotoDTO dto)
        {
            string script = @"INSERT tb_voto(fk_voto_urna, fk_voto_candidato, fk_voto_eleitor)
                                      VALUES(@fk_voto_urna, @fk_voto_candidato, @fk_voto_eleitor)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("fk_voto_urna", UrnaControl.Id));
            parms.Add(new MySqlParameter("fk_voto_candidato", dto.fk_voto_candidato));
            parms.Add(new MySqlParameter("fk_voto_eleitor", dto.fk_voto_eleitor));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public void ResetUrna()
        {
            string script = @"UPDATE tb_urna SET id_eleitor = 0, ds_situacao = 0 WHERE id_urna = @id_urna";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_urna", UrnaControl.Id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
    }
}
