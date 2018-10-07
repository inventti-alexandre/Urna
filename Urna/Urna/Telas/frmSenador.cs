using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna.DB.Candidato;
using Urna.DB.Voto;
using Urna.Plugin;

namespace Urna.Telas
{
    public partial class frmSenador : Form
    {
        public frmSenador()
        {
            InitializeComponent();
        }


        string n = string.Empty;
        VotoDTO voto = new VotoDTO();
        VotoDatabase db = new VotoDatabase();
        frmSenador2 frm = new frmSenador2();

        private void Votar()
        {
            voto.fk_voto_eleitor = UrnaControl.id_Eleitor;

            CandidatoBusiness business = new CandidatoBusiness();
            CandidatoDTO candidato = business.ConsultarCandidadoPorNumero_Cargo(Convert.ToInt32(n), "Senador");
            voto.fk_voto_candidato = candidato.id_candidato;

            db.Votar(voto);
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (n.Length == 3)
                    Votar();
                else
                    throw new ArgumentException("O número do candidato é inválido.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Urna", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inexperado: {ex.Message}", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherDados()
        {
            CandidatoBusiness business = new CandidatoBusiness();
            int numero = Convert.ToInt32(txtNum1.Text + txtNum2.Text + txtNum3.Text);
            CandidatoDTO candidato = business.ConsultarCandidadoPorNumero_Cargo(numero, "Senador");

            if (candidato.nr_candidato != 0)
            {
                ft.Image = ImagemPlugin.ConverterParaImagem(candidato.ft_candidato);
                lblNome.Text = candidato.nm_candidato;
                lblPartido.Text = $"{candidato.nm_partido} - {candidato.ds_sigra}";

                CandidatoDTO sup1 = business.ConsultarCandidadoPorNumero_Cargo(numero, "Suplente 1");
                CandidatoDTO sup2 = business.ConsultarCandidadoPorNumero_Cargo(numero, "Suplente 2");

                if (sup1.nr_candidato != 0)
                {
                    ft1.Image = ImagemPlugin.ConverterParaImagem(sup1.ft_candidato);
                    lbl1Suplente.Text = sup1.nm_candidato;
                }
                if (sup2.nr_candidato != 0)
                {
                    ft2.Image = ImagemPlugin.ConverterParaImagem(sup2.ft_candidato);
                    lbl2Suplente.Text = sup2.nm_candidato;
                }
            }
            else
                lblVotoB.Visible = true;

            pnInfo.Visible = true;
        }

        private void Digitar(string numero)
        {
            if (numero.Length < 4)
            {
                if (numero.Length > 0)
                {
                    txtNum1.Text = numero.Substring(0, 1);
                    if (numero.Length > 1)
                    {
                        txtNum2.Text = numero.Substring(1, 1);
                        if (numero.Length > 2)
                        {
                            txtNum3.Text = numero.Substring(2, 1);
                            PreencherDados();
                        }
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}1";
                Digitar(n);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}2";
                Digitar(n);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}3";
                Digitar(n);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}4";
                Digitar(n);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}5";
                Digitar(n);
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}6";
                Digitar(n);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}7";
                Digitar(n);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}8";
                Digitar(n);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}9";
                Digitar(n);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (n.Length < 3)
            {
                n = $"{n}0";
                Digitar(n);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            txtNum3.Text = "0";
            n = "000";

            PreencherDados();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmSenador frm = new frmSenador();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
