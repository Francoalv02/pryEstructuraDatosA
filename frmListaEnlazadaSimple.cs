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
    public partial class frmListaEnlazadaSimple : Form
    {
        public frmListaEnlazadaSimple()
        {
            InitializeComponent();
        }
        ClsListaSimple ObjLista = new ClsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            ObjLista.Agregar(objNodo);
            ObjLista.Recorrer(dgvGrilla);
            ObjLista.Recorrer(lstEnlazada);
            ObjLista.Recorrer(cbCodigoEE);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void frmListaEnlazadaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ObjLista.Primero != null)
            {
                Int32 Eliminar = Convert.ToInt32(cbCodigoEE.Text);
                ObjLista.Eliminar(Eliminar);
                ObjLista.Recorrer(dgvGrilla);
                ObjLista.Recorrer(lstEnlazada);
                ObjLista.Recorrer(cbCodigoEE);

                cbCodigoEE.Text = "";

            }
            else
            {
                MessageBox.Show("La lista esta vacia");

            }
            
        }
    }
}
