using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProgramador frm1 = new frmDatosProgramador();
            frm1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void noLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocente frm1 = new frmDocente();
            frm1.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscructuraDinamicaLineal_Cola frm1 = new frmEscructuraDinamicaLineal_Cola();
            frm1.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDePila fr1 = new frmEstructuraDePila();
            fr1.Show();
        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaSimple frmL= new frmListaEnlazadaSimple();
            frmL.Show();

        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoblementeEnlazada frLD = new frmListaDoblementeEnlazada();
            frLD.Show();
        }

        private void listaEnladasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEnlazadaSimple frmL = new frmListaEnlazadaSimple();
            frmL.Show();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoblementeEnlazada frLD = new frmListaDoblementeEnlazada();
            frLD.Show();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraRamificada_ArbolBinario arb = new frmEstructuraRamificada_ArbolBinario();
            arb.Show();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No disponible, por el momento");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones_De_Base_De_Datos ars = new Operaciones_De_Base_De_Datos();
            ars.Show();
        }

        private void consultaBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBaseDeDatos ae = new frmConsultaBaseDeDatos();
            ae.Show();
        }

        private void consultaBaseDeDatosPorOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulBaseDeDatosPorOperaciones aa = new frmConsulBaseDeDatosPorOperaciones();
            aa.Show();
        }
    }
}
