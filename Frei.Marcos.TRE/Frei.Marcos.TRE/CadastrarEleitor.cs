using Frei.Marcos.TRE.Db;
using Frei.Marcos.TRE.Db.Eleitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.Marcos.TRE
{
    public partial class CadastrarEleitor : Form
    {
        public CadastrarEleitor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DESCripto crip = new DESCripto();
            
            string texto = Criptografia(txtNinc.Text);
            MessageBox.Show("" + texto);


        }
        private string Criptografia(string numeroeleito)
        {

            string chave = "planalto";
            DESCripto crip = new DESCripto();
            string t = crip.Criptografar(chave, numeroeleito);
            return t;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EleitorDTO dto = new EleitorDTO();
            dto.nm_municipio = txtMun.Text;
            dto.nm_nome = txtNome.Text;
            dto.nm_uf = txtUF.Text;
            dto.nr_inscricao = txtNinc.Text;
            dto.dt_nascimento = dtpNasc.Value;
            dto.nr_rg = txtRG.Text;
            dto.nr_zona = Convert.ToInt32(txtZona.Text);

            EleitorDatabase db = new EleitorDatabase();
            db.CadastrarEleitor(dto);

            MessageBox.Show("Eleitor cadastrado com sucesso.", "TRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
