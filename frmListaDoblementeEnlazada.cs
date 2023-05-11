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
    public partial class frmListaDoblementeEnlazada : Form
    {
        public frmListaDoblementeEnlazada()
        {
            InitializeComponent();
        }
        clsListaDoble ObjListaDoble = new clsListaDoble();
        private void picRepresentacionEnlazada_Click(object sender, EventArgs e)
        {

        }

        private void grpElementoEliminado_Enter(object sender, EventArgs e)
        {

        }

        private void groNuevoElemento_Enter(object sender, EventArgs e)
        {

        }

        private void groSecundario_Enter(object sender, EventArgs e)
        {

        }

        private void frmListaDoblementeEnlazada_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            ObjListaDoble.Agregar(objNodo);
            ObjListaDoble.Recorrer(dgvGrilla);
            ObjListaDoble.Recorrer(lstEnlazada);
            ObjListaDoble.Recorrer(cbCodigoEE);
           


            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbCodigoEE.Text != null)
            {
                Int32 Codigo = Convert.ToInt32(cbCodigoEE.Text);

                ObjListaDoble.Eliminar(Codigo);
                ObjListaDoble.Recorrer(dgvGrilla);
                ObjListaDoble.Recorrer(lstEnlazada);
                ObjListaDoble.Recorrer(cbCodigoEE);

                cbCodigoEE.Text = "";

            }
            else
            {
                MessageBox.Show("Cargue un dato");
            }
        }
    }
}
