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
    public partial class frmListaSimple : Form
    {
        clsListaSimple objListaSimple = new clsListaSimple();

        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objListaSimple.Agregar(objNodo);
            objListaSimple.Recorrer(dgvDatos);
            objListaSimple.Recorrer(lstCola);
            objListaSimple.Recorrer(cboElementoEliminado);

            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objListaSimple.Primero != null)
            {
                Int32 Eliminar = Convert.ToInt32(cboElementoEliminado.Text);
                objListaSimple.Eliminar(Eliminar);
                objListaSimple.Recorrer(dgvDatos);
                objListaSimple.Recorrer(lstCola);
                objListaSimple.Recorrer(cboElementoEliminado);
            }
            
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
        }
    }
}
