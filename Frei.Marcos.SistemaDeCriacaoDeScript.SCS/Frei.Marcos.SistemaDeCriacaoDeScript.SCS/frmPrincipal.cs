using Frei.Marcos.SistemaDeCriacaoDeScript.SCS.DB.Candidatura;
using Nsf._2018.Modulo3.App.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.SistemaDeCriacaoDeScript.SCS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cbbOcupacao.Text = "Presidente";
        }

        private void img_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                img.ImageLocation = dialog.FileName;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CandidaturaDTO dto = new CandidaturaDTO();
            dto.ds_cargo = cbbOcupacao.SelectedItem.ToString();
            dto.ft_candidato = ImagemPlugin.ConverterParaString(img.Image);
            dto.nm_candidato = txtCandidato.Text;
            dto.nr_candidato = Convert.ToInt32(txtNCandidato.Text);
            dto.tb_partido_id_partido = Convert.ToInt32(txtPartido.Text);

            CandidaturaBusiness business = new CandidaturaBusiness();
            business.Registrar(dto);

            MessageBox.Show("Candidato cadastrado");

            frmPrincipal frm = new frmPrincipal();
            Hide();
            frm.ShowDialog();
            Close();
        }
    }
}
