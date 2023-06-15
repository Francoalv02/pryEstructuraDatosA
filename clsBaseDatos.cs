using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConeccion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Libreria.mdb";

        private string VarCadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = VarCadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libro"];


                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                conexion.Close();   
            }
        }

        public void Listar(DataGridView Grilla ,string varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = VarCadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];


                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
