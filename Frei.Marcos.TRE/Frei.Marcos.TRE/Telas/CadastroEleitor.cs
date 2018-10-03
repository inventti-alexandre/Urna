using Frei.Marcos.TRE.Db;
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
    public partial class CadastroEleitor : Form
    {
        public CadastroEleitor()
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
            
            string texto = Criptografia(txtnumerodeincricao.Text);
            MessageBox.Show("" + texto);


        }
        private string Criptografia(string numeroeleito)
        {

            string chave = "planalto";
            DESCripto crip = new DESCripto();
            string t = crip.Criptografar(chave, numeroeleito);
            return t;



        }
    }
}
