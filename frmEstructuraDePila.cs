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
    public partial class frmEstructuraDePila : Form
    {
        public frmEstructuraDePila()
        {
            InitializeComponent();
        }
        ClsPila ObjPila = new ClsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            ObjPila.Agregar(objNodo);
            ObjPila.Recorrer(dgvGrilla);
            ObjPila.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ObjPila.Primero != null)
            {
                txtCodigoEliminado.Text = ObjPila.Primero.Codigo.ToString();
                txtNombreEliminado.Text = ObjPila.Primero.Nombre;
                txtTramiteEliminado.Text = ObjPila.Primero.Tramite;
                ObjPila.Eliminar();
                ObjPila.Recorrer(dgvGrilla);
                ObjPila.Recorrer(lstCola);

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
