using Frei.Marcos.TRE.Db;
using Frei.Marcos.TRE.Db.Eleitor;
using Frei.Marcos.TRE.Db.Urna;
using Frei.Marcos.TRE.Telas;
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
            try
            {
                EleitorBusiness business = new EleitorBusiness();
                DESCripto cripto = new DESCripto();
                string numeroInscricao = cripto.Criptografar("planalto", txtNinc.Text);

                eleitor = business.Consultar(numeroInscricao);

                txtNome.Text = cripto.Descriptografar("planalto", eleitor.nm_nome);
                dtpNasc.Value = eleitor.dt_nascimento;
                txtRG.Text = cripto.Descriptografar("planalto", eleitor.nr_rg);
                txtMun.Text = eleitor.nm_municipio;
                txtUF.Text = cripto.Descriptografar("planalto", eleitor.nm_uf);
                txtZona.Text = eleitor.nr_zona.ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Urna - Informática A", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inexperado: {ex.Message}", "Urna - Informática A", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            CadastrarEleitor frm = new CadastrarEleitor();
            Hide();
            frm.Show();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                UrnaDatabase db = new UrnaDatabase();
                if (txtUrna.Text == string.Empty)
                    throw new ArgumentException("Digite o ID da urna.");

                if (db.VerificarUrna(Convert.ToInt32(txtUrna.Text)) == true)
                {
                    if (db.VerificarEleitor(eleitor.id_eleitor) == false)
                        throw new ArgumentException("Esse eleitor já votou.");

                    UrnaDTO dto = new UrnaDTO();
                    dto.id_urna = Convert.ToInt32(txtUrna.Text);
                    dto.id_eleitor = eleitor.id_eleitor;

                    int idEleitor = eleitor.id_eleitor;

                    db.LiberarUrna(dto);
                    db.AtualizarEleitor(idEleitor);
                    MessageBox.Show("Urna liberada!", "Urna - Informática A", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    throw new ArgumentException("Esta urna está em uso.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Urna - Informática A", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inexperado: {ex.Message}", "Urna - Informática A", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Votos frm = new Votos();
            Hide();
            frm.Show();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
