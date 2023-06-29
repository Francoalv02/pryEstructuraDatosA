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
    public partial class frmConsulBaseDeDatosPorOperaciones : Form
    {
        clsBaseDatos objBaseDatos;
        public frmConsulBaseDeDatosPorOperaciones()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            objBaseDatos = new clsBaseDatos();
            String varSql = "SELECT * FROM LIBRO";
            switch (cmbConsulta.SelectedIndex)
            {
                //DIFERENCIA
                case 0:
                    lblConsultaSQL.Text = cmbConsulta.Text + ":       "
                        + "Idiomas que no tienen libros ";
                    varSql = "Select * from idioma where " +
                        "Ididioma not in " + "(Select IdIdioma from Libro) ";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                //INTERSECCION
                case 1:
                    lblConsultaSQL.Text = cmbConsulta.Text + ":             " +
                        "Idiomas que si tienen libros ";
                    varSql = "Select * From Idioma where " +
                        " IdIdioma in " +
                        " (Select IdIdioma from Libro) ";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                case 2:
                    lblConsultaSQL.Text = cmbConsulta.Text + ": " +
                        "Libros y Autores";
                    varSql = "Select  Titulo, Nombre " +
                        "from Libro inner join Autor " +
                        "on Libro.IdAutor = Autor.IdAutor ";

                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                case 3:
                    lblConsultaSQL.Text = cmbConsulta.Text + ": " +
                        "Todos los autores de los libros";
                    varSql = "Select Nombre From Autor";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                case 4: //PROYECCION MULTIATRIBUTOS
                    lblConsultaSQL.Text = cmbConsulta.Text + ":" +
                        "Muestra Pais, Titulo y Cantidad";
                    varSql = "Select IdPais, Titulo, Cantidad from Libro";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                case 5://SELECCION CON AND
                    lblConsultaSQL.Text = cmbConsulta.Text + ":" +
                        "Muestra todos los libros Alemanes con su precio ";
                    varSql = "Select * from Libro " +
                        "where IdPais =  5 AND Precio ";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                case 6://SELECCION MULTIATRIBUTOS CON OPERADOR
                    lblConsultaSQL.Text = cmbConsulta.Text + ":" +
                     "Muestra todos los libros que su autor sea Carlos o Virginia ";
                    varSql = "Select * from Libro " +
                        "where IdAutor = 2 OR IdAutor = 3 ";
                    objBaseDatos.Listar(dgvConsulta, varSql);

                    break;

                case 7://SELECCION MULTIATRIBUTOS POR CONVOLUCION
                    lblConsultaSQL.Text = cmbConsulta.Text + ":" +
                     "Muestra los libros de Alemania con cantidad mayor que 2 ";
                    varSql = "Select * From " +
                        "(Select  Titulo, Cantidad, IdPais, IdIdioma From Libro where Cantidad > 2) as X " +
                        "Where IdIdioma = 3 ";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                case 8://SELECCION SIMPLE
                    lblConsultaSQL.Text = cmbConsulta.Text + ":" +
                    "Muestra los libros con cantidad mayor que 5 ";
                    varSql = "Select Titulo from Libro " +
                        "where Cantidad > 5 ";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
                case 9: //UNION
                    lblConsultaSQL.Text = cmbConsulta.Text + ":" +
                        "Muestra los libros con Idoma  Hebreo y Noruego";
                    varSql = "Select * From Libro " +
                        " where IdIdioma = 18 " +
                        "union " +
                        "Select * From Libro where IdIdioma = 7";
                    objBaseDatos.Listar(dgvConsulta, varSql);
                    break;
            }
        }

    }
}
