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
    public partial class frmEstructuraRamificada_ArbolBinario : Form
    {
        public frmEstructuraRamificada_ArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbol = new clsArbolBinario();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsNodo objNodo = new ClsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            objArbol.Agregar(objNodo);
            //objArbol.re(dgvGrilla);
            //objArbol.Recorrer(lstEnlazada);
            //objArbol.Recorrer(cbCodigoEE);


            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 eliminar = Convert.ToInt32(cbCodigoEE.Text);
            objArbol.Eliminar(eliminar);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
            
            if (objArbol.Raiz != null)
            {
                if (rbInOrdenDesc.Checked)
                {
                    objArbol.RecorrerInOrdenDes(cbCodigoEE);
                    objArbol.RecorrerInOrdenDes(lstEnlazada);
                    objArbol.RecorrerInOrdenDes(dgvGrilla);
                    objArbol.RecorrerPreOrden(tvArbol);
                }
            }
            else
            {
                rbInOrdenDesc.Checked = false;

            }
        }

        private void rbInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            
            if (objArbol.Raiz != null)
            {
                if (rbInOrdenAsc.Checked)
                {
                    objArbol.RecorrerInOrdenAsc(cbCodigoEE);
                    objArbol.RecorrerInOrdenAsc(lstEnlazada);
                    objArbol.RecorrerInOrdenAsc(dgvGrilla);
                    objArbol.RecorrerPreOrden(tvArbol);
                }
            }
            else
            {
                    rbInOrdenAsc.Checked = false;
            }
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            
            if (objArbol.Raiz != null)
            {
                if (rbPreOrden.Checked)
                {
                    objArbol.RecorrerPreOrden(cbCodigoEE);
                    objArbol.RecorrerPreOrden(lstEnlazada);
                    objArbol.RecorrerPreOrden(dgvGrilla);
                    objArbol.RecorrerPreOrden(tvArbol);
                }
            }
            else
            {
                rbPreOrden.Checked = false;

            }
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            
            if (objArbol.Raiz != null)
            {
                if (rbPostOrden.Checked)
                {
                    objArbol.RecorrerPostOrden(cbCodigoEE);
                    objArbol.RecorrerPostOrden(lstEnlazada);
                    objArbol.RecorrerPostOrden(dgvGrilla);
                    objArbol.RecorrerPreOrden(tvArbol);
                }
            }
            else
            {
                rbPostOrden.Checked = false;
            }
        }

        private void frmEstructuraRamificada_ArbolBinario_Load(object sender, EventArgs e)
        {
            rbPreOrden.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBusacrElemento_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOrdenarArbol_Click(object sender, EventArgs e)
        {
            if (objArbol.Raiz != null)
            {
                objArbol.Equilibrar();
                objArbol.RecorrerPreOrden(tvArbol);

            }
            else
            {
                MessageBox.Show("ingrese elementos!!!!!");
            }
        }
    }
}
