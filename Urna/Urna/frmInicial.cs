﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna.DB.Urna;
using Urna.DB.Voto;
using Urna.Telas;

namespace Urna
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
            lblId.Text = $"Urna {UrnaControl.Id}";
        }

        private void bntConfirmar_Click(object sender, EventArgs e)
        {
            UrnaBusiness business = new UrnaBusiness();
            frmDeputadoEstadual frm = new frmDeputadoEstadual();
            VotoDatabase db = new VotoDatabase();

            bool ativa = business.VerificarUrna();

            if (ativa == false)
                lblBlock.Visible = true;
            else
            {
                db.ResetUrna();
                Hide();
                frm.ShowDialog();
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
