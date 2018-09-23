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
            try
            {
                CandidaturaDTO dto = new CandidaturaDTO();
                dto.ds_cargo = cbbOcupacao.SelectedItem.ToString();
                dto.ft_candidato = ImagemPlugin.ConverterParaString(img.Image);
                dto.nm_candidato = txtCandidato.Text;
                dto.nr_candidato = Convert.ToInt32(txtNCandidato.Text);
                dto.tb_partido_id_partido = Convert.ToInt32(txtPartido.Text);

                CandidaturaBusiness business = new CandidaturaBusiness();
                business.Registrar(dto);

                MessageBox.Show("Candidato cadastrado", "SCS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal frm = new frmPrincipal();
                Hide();
                frm.ShowDialog();
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "SCS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                switch (ex.Message.ToString()) {
                    case ("Duplicate entry 'digite um nome aqui...' for key 'nm_candidato'"):
                        MessageBox.Show("Esse candidato já está registrado.", "SCS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case ("Referência de objeto não definida para uma instância de um objeto."):
                        MessageBox.Show("Adicione uma imagem.", "SCS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case ("Cannot add or update a child row: a foreign key constraint fails (`urnadb`.`tb_candidato`, CONSTRAINT `fk_tb_candidato_tb_partido1` FOREIGN KEY (`tb_partido_id_partido`) REFERENCES `tb_partido` (`id_partido`))"):
                        MessageBox.Show("Este partido não existe.", "SCS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(ex.Message, "SCS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

            }
        }

        private void txtPartido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNCandidato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;

            if (txtNCandidato.Text.Length < 3)
                txtPartido.Text = txtNCandidato.Text;
        }

        private void txtCandidato_MouseClick(object sender, MouseEventArgs e)
        {
            txtCandidato.Text = string.Empty;
        }

        private void txtNCandidato_MouseClick(object sender, MouseEventArgs e)
        {
            txtNCandidato.Text = string.Empty;
            txtPartido.Text = string.Empty;
        }
    }
}
