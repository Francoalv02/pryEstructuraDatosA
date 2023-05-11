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
    public partial class frmEscructuraDinamicaLineal_Cola : Form
    {
        public frmEscructuraDinamicaLineal_Cola()
        {
            InitializeComponent();
        }
        ClsCola FilaDePersonas = new ClsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvGrilla);
            FilaDePersonas.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                txtCodigoEliminado.Text = FilaDePersonas.Primero.Codigo.ToString();
                txtNombreEliminado.Text = FilaDePersonas.Primero.Nombre;
                txtTramiteEliminado.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstCola);

                txtCodigoEliminado.Text = "";
                txtNombreEliminado.Text = "";
                txtTramiteEliminado.Text = "";
            }
            else
            {
                MessageBox.Show("No existe ese dato,intente otro ");
            }
        }
    }
}
