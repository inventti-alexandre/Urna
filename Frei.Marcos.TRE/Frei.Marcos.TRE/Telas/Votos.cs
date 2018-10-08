using Frei.Marcos.TRE.Db.Voto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna.Plugin;

namespace Frei.Marcos.TRE.Telas
{
    public partial class Votos : Form
    {
        public Votos()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CadastrarEleitor frm = new CadastrarEleitor();
            Hide();
            frm.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            VotoDTO primeiroPresidente = ConsultarPresidente();

            VotoDatabase db = new VotoDatabase();
            CandidatoDTO presidente = db.ConsultarCandidato(primeiroPresidente.fk_voto_candidato);

            if(presidente != null)
            {
                ftPresidente.Image = ImagemPlugin.ConverterParaImagem(presidente.ft_candidato);
                lblPresidente.Text = presidente.nm_candidato;
            }
        }

        private VotoDTO ConsultarPresidente()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votosPresidente = db.ConsultarPresidente();

            VotoDTO primeiroColocado = votosPresidente.ElementAt(0);
            return primeiroColocado;
        }
    }
}
