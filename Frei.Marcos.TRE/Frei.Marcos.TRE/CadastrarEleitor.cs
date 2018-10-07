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

        private string Criptografia(string mensagem)
        {
            string chave = "planalto";

            DESCripto crip = new DESCripto();
            string response = crip.Criptografar(chave, mensagem);

            return response;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                EleitorDTO dto = new EleitorDTO();
                dto.nm_municipio = Criptografia(txtMun.Text);
                dto.nm_nome = Criptografia(txtNome.Text);
                dto.nm_uf = Criptografia(txtUF.Text);
                dto.nr_inscricao = Criptografia(txtNinc.Text);
                dto.nr_rg = Criptografia(txtRG.Text);
                dto.nr_zona = Convert.ToInt32(txtZona.Text);

                TimeSpan idade = DateTime.Now - dtpNasc.Value;
                dto.dt_nascimento = (idade.Days / 365) >= 16 ? dtpNasc.Value : throw new ArgumentException("Você deve ter no mínimo 16 anos para tirar o título de eleitor.");

                EleitorDatabase db = new EleitorDatabase();
                db.CadastrarEleitor(dto);

                MessageBox.Show("Eleitor cadastrado com sucesso.", "TRE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "TRE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inexperado: {ex.Message}", "TRE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Mesario frm = new Mesario();
            Hide();
            frm.Show();
        }
    }
}
