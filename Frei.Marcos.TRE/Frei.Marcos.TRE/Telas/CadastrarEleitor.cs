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
                dto.nm_nome = txtNome.Text != string.Empty ? Criptografia(txtNome.Text).Trim() : throw new ArgumentException("Nome não pode ser nulo.");
                dto.nm_uf = txtUF.Text != string.Empty ? Criptografia(txtUF.Text) : throw new ArgumentException("UF não pode ser nulo.");
                dto.nr_inscricao = txtNinc.Text != string.Empty ? Criptografia(txtNinc.Text) : throw new ArgumentException("Número de Inscrição não pode ser nulo.");
                dto.nr_rg = txtRG.Text != string.Empty ? Criptografia(txtRG.Text) : throw new ArgumentException("RG não pode ser nulo.");
                dto.nr_zona = txtZona.Text != string.Empty ? Convert.ToInt32(txtZona.Text) : throw new ArgumentException("Zona não pode ser nulo.");
                dto.nm_municipio = txtMun.Text != string.Empty ? txtMun.Text.Trim() : throw new ArgumentException("Municipio não pode ser nulo.");

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

        private void txtZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtMun_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtNinc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
