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
    public partial class frmPila : Form
    {
        clsPila objPila = new clsPila();

        public frmPila()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objPila.Agregar(objNodo);
            objPila.Recorrer(dgvDatos);
            objPila.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.primero != null)
            {
                Nodo objNodo = new Nodo();
                lblCodEliminar.Text = objPila.primero.Codigo.ToString();
                lblNombreEliminar.Text = objPila.primero.Nombre;
                lblTraEliminar.Text = objPila.primero.Tramite;
                objPila.Eliminar();
                objPila.Recorrer(dgvDatos);
                objPila.Recorrer(lstCola);
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
