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
    public partial class Operaciones_De_Base_De_Datos : Form
    {
        public Operaciones_De_Base_De_Datos()
        {
            InitializeComponent();
        }

        private void Operaciones_De_Base_De_Datos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void button1_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO FROM LIBRO";
            objBaseDatos.Listar(dataGridView1,varSQL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string varSQL = "Select Titulo, IdIdioma from Libro";
            objBaseDatos.Listar(dataGridView1, varSQL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string varSQL = "Select * " +
            //    "from LIBRO inner join AUTOR " +
            //    "on LIBRO.IDAUTOR = AUTOR.IDAUTOR ";
            //objBaseDatos.Listar(dataGridView1, varSQL);

            string varSQL = "SELECT TITULO, NOMBRE " +
                "FROM LIBRO, PAIS " +
                "WHERE LiBRO.IDPAIS = PAIS.IDPAIS";
            objBaseDatos.Listar(dataGridView1, varSQL);
            //TP LAB
        }

        private void button8_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "Select * from libro " +
                " where IdIdioma=3 and IdLibro not in " +
                " (Select IdLibro from libro where IdPais =2 )" +
                " order by 1 asc ";
            objBaseDatos.Listar(dataGridView1, varSql);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            string varSQL = "Select * " +
                "from libro " +
                "where IdIdioma= 2";
            objBaseDatos.Listar(dataGridView1, varSQL);
        }

        private void grbSeleccion_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "Select *" +
                " FROM (Select * from libro where IdIdioma > 1) as X " +
                "WHERE IdPais = 2 ";
            objBaseDatos.Listar(dataGridView1, varSql);
        }

        private void grbAlgebraicas_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnSeleccionMultiatributos_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSQL = "SELECT * FROM Libro WHERE IdLibro = 2 AND IdAutor > 1";
            objBaseDatos.Listar(dataGridView1, varSQL);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSQL = " SELECT * FROM Libro WHERE IdIdioma = 2 " +
                " union " +
                " SELECT * FROM Libro where IdIdioma = 3 ";
            objBaseDatos.Listar(dataGridView1, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "Select * from libro " +
                 " where IdIdioma=3 and IdLibro in " +
                 " (Select IdLibro from libro where IdPais =2 )" +
                 " order by 1 asc ";
            objBaseDatos.Listar(dataGridView1, varSql);
        }
    }
}
