using Frei.Marcos.TRE.Db.Eleitor;
using Frei.Marcos.TRE.Db.Urna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.TRE
{
    public partial class Mesario : Form
    {
        public Mesario()
        {
            InitializeComponent();
        }

        EleitorDTO eleitor = new EleitorDTO();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            EleitorBusiness business = new EleitorBusiness();
            eleitor = business.Consultar(Convert.ToInt32(txtNinc.Text));

            txtNome.Text = eleitor.nm_nome;
            dtpNasc.Value = eleitor.dt_nascimento;
            txtRG.Text = eleitor.nr_rg;
            txtMun.Text = eleitor.nm_municipio;
            txtUF.Text = eleitor.nm_uf;
            txtZona.Text = eleitor.nr_zona.ToString();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            UrnaDTO dto = new UrnaDTO();
            dto.id_eleitor = eleitor.id_eleitor;
            dto.id_urna = Convert.ToInt32(txtUrna.Text);

            UrnaBusiness business = new UrnaBusiness();
            business.LiberarUrna(dto);

            MessageBox.Show("Urna liberada com sucesso!");
        }

        private void Mesario_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
