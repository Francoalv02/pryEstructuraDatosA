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
    public partial class frmCola : Form
    {
        clsCola FilaDePersonas = new clsCola();
        public frmCola()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvDatos);
            FilaDePersonas.Recorrer(lstCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodEliminar.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombreEliminar.Text = FilaDePersonas.Primero.Nombre;
                lblTraEliminar.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvDatos);
                FilaDePersonas.Recorrer(lstCola);
            }
            else
            {
                lblCodEliminar.Text = "";
                lblNombreEliminar.Text = "";
                lblTraEliminar.Text = "";
            }
        }
    }
}
