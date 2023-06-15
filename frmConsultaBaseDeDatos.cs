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
    public partial class frmConsultaBaseDeDatos : Form
    {
        public frmConsultaBaseDeDatos()
        {
            InitializeComponent();
        }
        clsBaseDatos objConsultarBD = new clsBaseDatos();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string varSQL = txtConsultaSQL.Text;
            objConsultarBD.Listar(dgvConsulta, varSQL);
        }
    }
}
