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
    public partial class frmEstructuraDatos : Form
    {
        public frmEstructuraDatos()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosProgramador frmDatosProgramador = new frmDatosProgramador();
            frmDatosProgramador.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.ShowDialog();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.ShowDialog();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoblementeEnlazada frmListaDoblementeEnlazada = new frmListaDoblementeEnlazada();
            frmListaDoblementeEnlazada.ShowDialog();
        }
    }
}
