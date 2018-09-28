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
using Urna.Plugin;

namespace Urna
{
    public partial class frmDeputadoEstadual : Form
    {
        public frmDeputadoEstadual()
        {
            InitializeComponent();
        }
        string n = string.Empty;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void PreencherDados()
        {
            CandidatoBusiness business = new CandidatoBusiness();
            CandidatoDTO candidato = business.ConsultarCandidadoPorNumero(Convert.ToInt32(txtNum1.Text + txtNum2.Text + txtNum3.Text + txtNum4.Text + txtNum5.Text));

            if (candidato.nr_candidato != 0)
            {
                ft.Image = ImagemPlugin.ConverterParaImagem(candidato.ft_candidato);
                lblNome.Text = candidato.nm_candidato;
                lblPartido.Text = $"{candidato.nm_partido} - {candidato.ds_sigra}";
            }
            else
                lblVotoB.Visible = true;

            pnInfo.Visible = true;
        }

        private void Digitar(string numero)
        {
            if (numero.Length < 6)
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
                            if (numero.Length > 3)
                            {
                                txtNum4.Text = numero.Substring(3, 1);
                                if (numero.Length > 4)
                                {
                                    txtNum5.Text = numero.Substring(4, 1);
                                    PreencherDados();
                                }
                            }
                        }
                    }
                } 
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            n = $"{n}1";
            Digitar(n);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            n = $"{n}2";
            Digitar(n);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            n = $"{n}3";
            Digitar(n);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            n = $"{n}4";
            Digitar(n);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            n = $"{n}5";
            Digitar(n);

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            n = $"{n}6";
            Digitar(n);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            n = $"{n}7";
            Digitar(n);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            n = $"{n}8";
            Digitar(n);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            n = $"{n}9";
            Digitar(n);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            n = $"{n}0";
            Digitar(n);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "0";
            txtNum2.Text = "0";
            txtNum3.Text = "0";
            txtNum4.Text = "0";
            txtNum5.Text = "0";

            PreencherDados();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmDeputadoEstadual frm = new frmDeputadoEstadual();
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
