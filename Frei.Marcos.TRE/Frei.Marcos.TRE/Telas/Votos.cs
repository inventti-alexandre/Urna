using Frei.Marcos.TRE.Db.Voto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Urna.Plugin;

namespace Frei.Marcos.TRE.Telas
{
    public partial class Votos : Form
    {
        public Votos()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CadastrarEleitor frm = new CadastrarEleitor();
            Hide();
            frm.Show();
        }

        private void btnAtualizar()
        {
            try
            {
                VotoDatabase dbase = new VotoDatabase();
                bool votado = dbase.VerificarVoto();

                if (votado == true)
                {
                    lblErro.Visible = false;

                    VotoDTO primeiroPresidente = ConsultarPresidente();
                    VotoDTO primeiroGovernador = ConsultarGovernador();
                    List<VotoDTO> senadores = ConsultarSenador();
                    VotoDTO primeiroSenador = new VotoDTO();
                    VotoDTO segundoSenador = new VotoDTO();
                    if (senadores.Count > 1)
                    {
                        primeiroSenador = senadores[0];
                        segundoSenador = senadores[1];
                    }
                    VotoDTO primeiroDepFederal = ConsultarDeputadoFederal();
                    VotoDTO primeiroDepEstadual = ConsultarDeputadoEstadual();
                    VotoDTO brancos = ConsultarBranco();
                    VotoDTO nulo = ConsultarNulo();

                    VotoDatabase db = new VotoDatabase();
                    CandidatoDTO presidente = db.ConsultarCandidato(primeiroPresidente.nr_candidato, "Presidente");
                    CandidatoDTO vicepresidente = db.ConsultarCandidato(primeiroPresidente.nr_candidato, "Vice-Presidente");
                    CandidatoDTO governador = db.ConsultarCandidato(primeiroGovernador.nr_candidato, "Governador");
                    CandidatoDTO vicegovernador = db.ConsultarCandidato(primeiroGovernador.nr_candidato, "Vice-Governador");
                    CandidatoDTO senador1 = db.ConsultarCandidato(primeiroSenador.nr_candidato, "Senador");
                    CandidatoDTO suplente1_1 = db.ConsultarCandidato(primeiroSenador.nr_candidato, "Suplente 1");
                    CandidatoDTO suplente1_2 = db.ConsultarCandidato(primeiroSenador.nr_candidato, "Suplente 2");
                    CandidatoDTO senador2 = db.ConsultarCandidato(segundoSenador.nr_candidato, "Senador");
                    CandidatoDTO suplente2_1 = db.ConsultarCandidato(segundoSenador.nr_candidato, "Suplente 1");
                    CandidatoDTO suplente2_2 = db.ConsultarCandidato(segundoSenador.nr_candidato, "Suplente 2");
                    CandidatoDTO deputadoFederal = db.ConsultarCandidato(primeiroDepFederal.nr_candidato, "Deputado Federal");
                    CandidatoDTO deputadoEstadual = db.ConsultarCandidato(primeiroDepEstadual.nr_candidato, "Deputado Estadual");

                    if (presidente.nm_candidato != null)
                    {
                        ftPresidente.Image = ImagemPlugin.ConverterParaImagem(presidente.ft_candidato);
                        lblPresidente.Text = presidente.nm_candidato;
                        lblNVPresidente.Text = primeiroPresidente.numeroDeVotos.ToString();
                    }
                    if (vicepresidente.nm_candidato != null)
                    {
                        ftVicePresidente.Image = ImagemPlugin.ConverterParaImagem(vicepresidente.ft_candidato);
                        lblVicePresidente.Text = vicepresidente.nm_candidato;
                    }
                    if (governador.nm_candidato != null)
                    {
                        ftGovernador.Image = ImagemPlugin.ConverterParaImagem(governador.ft_candidato);
                        lblGovernador.Text = governador.nm_candidato;
                        lblNVGovernador.Text = primeiroGovernador.numeroDeVotos.ToString();
                    }
                    if (vicegovernador.nm_candidato != null)
                    {
                        ftViceGovernador.Image = ImagemPlugin.ConverterParaImagem(vicegovernador.ft_candidato);
                        lblViceGovernador.Text = vicegovernador.nm_candidato;
                    }
                    if (senador1.nm_candidato != null)
                    {
                        ft1Senador.Image = ImagemPlugin.ConverterParaImagem(senador1.ft_candidato);
                        lbl1Senador.Text = senador1.nm_candidato;
                        lblNVSenador.Text = primeiroSenador.numeroDeVotos.ToString();
                    }
                    if (suplente1_1.nm_candidato != null)
                    {
                        ft1Senador1Suplente.Image = ImagemPlugin.ConverterParaImagem(suplente1_1.ft_candidato);
                        lbl1Senador1Suplent.Text = suplente1_1.nm_candidato;
                    }
                    if (suplente1_2.nm_candidato != null)
                    {
                        ft1Senador2Suplente.Image = ImagemPlugin.ConverterParaImagem(suplente1_2.ft_candidato);
                        lbl1Senador2Suplent.Text = suplente1_2.nm_candidato;
                    }
                    if (senador2.nm_candidato != null)
                    {
                        ft2Senador.Image = ImagemPlugin.ConverterParaImagem(senador2.ft_candidato);
                        lbl2Senador.Text = senador2.nm_candidato;
                        lblNV2Senador.Text = segundoSenador.numeroDeVotos.ToString();
                    }
                    if (suplente2_1.nm_candidato != null)
                    {
                        ft2Senador1Suplente.Image = ImagemPlugin.ConverterParaImagem(suplente2_1.ft_candidato);
                        lbl2Senador1Suplent.Text = suplente2_1.nm_candidato;
                    }
                    if (suplente2_2.nm_candidato != null)
                    {
                        ft2Senador2Suplente.Image = ImagemPlugin.ConverterParaImagem(suplente2_2.ft_candidato);
                        lbl2Senador2Suplent.Text = suplente2_2.nm_candidato;
                    }
                    if (deputadoFederal.nm_candidato != null)
                    {
                        ftDeputadoFederal.Image = ImagemPlugin.ConverterParaImagem(deputadoFederal.ft_candidato);
                        lblDeputadoFederal.Text = deputadoFederal.nm_candidato;
                        lblNVDepFederal.Text = primeiroDepFederal.numeroDeVotos.ToString();
                    }
                    if (deputadoEstadual.nm_candidato != null)
                    {
                        ftDeputadoEstadual.Image = ImagemPlugin.ConverterParaImagem(deputadoEstadual.ft_candidato);
                        lblDeputadoEstadual.Text = deputadoEstadual.nm_candidato;
                        lblNVDepEstadual.Text = primeiroDepEstadual.numeroDeVotos.ToString();
                    }

                    lblNVBrancos.Text = brancos.numeroDeVotos.ToString();
                    lblNVNulos.Text = nulo.numeroDeVotos.ToString();
                }
                else
                    lblErro.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inexperado: {ex.Message}", "Urna", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private VotoDTO ConsultarBranco()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votos = db.ConsultarBrancos();
            VotoDTO primeiroColocado = new VotoDTO();
            if (votos.Count != 0)
                primeiroColocado = votos.ElementAt(0);
            return primeiroColocado;
        }

        private VotoDTO ConsultarNulo()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votos = new List<VotoDTO>();
            votos = db.ConsultarNulos();
            VotoDTO primeiroColocado = new VotoDTO();
            if (votos.Count != 0)
                primeiroColocado = votos.ElementAt(0);
            return primeiroColocado;
        }

        private VotoDTO ConsultarPresidente()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votos = db.ConsultarPresidente();
            VotoDTO primeiroColocado = new VotoDTO();
            if (votos.Count != 0)
                primeiroColocado = votos.ElementAt(0);
            return primeiroColocado;
        }

        private VotoDTO ConsultarGovernador()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votos = db.ConsultarGovernador();
            VotoDTO primeiroColocado = new VotoDTO();
            if (votos.Count != 0)
                primeiroColocado = votos.ElementAt(0);
            return primeiroColocado;
        }

        private List<VotoDTO> ConsultarSenador()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votos = db.ConsultarSenador();

            return votos;
        }

        private VotoDTO ConsultarDeputadoFederal()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votos = db.ConsultarDeputadoFederal();
            VotoDTO primeiroColocado = new VotoDTO();
            if (votos.Count != 0)
                primeiroColocado = votos.ElementAt(0);
            return primeiroColocado;
        }

        private VotoDTO ConsultarDeputadoEstadual()
        {
            VotoDatabase db = new VotoDatabase();
            List<VotoDTO> votos = db.ConsultarDeputadoEstadual();
            VotoDTO primeiroColocado = new VotoDTO();
            if (votos.Count != 0)
                primeiroColocado = votos.ElementAt(0);
            return primeiroColocado;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnAtualizar();
        }
    }
}
