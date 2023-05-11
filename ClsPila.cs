using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class ClsPila
    {

        public ClsNodo Primero;


        public void Agregar (ClsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }


        public void Eliminar ()
        {
            if(Primero != null)
            {       
                Primero = Primero.Siguiente;

            }
        }

        public void Recorrer (DataGridView Grilla )
        {
            ClsNodo Aux = Primero;
            Grilla.Rows.Clear();

            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            ClsNodo Aux = Primero;
            Lista.Items.Clear();

            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + "" + Aux.Nombre + "" + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            ClsNodo Aux = Primero;
            Combo.Items.Clear();

            while (Aux != null)
            {
                Combo.Items.Add( Aux.Nombre);
                Aux = Aux.Siguiente;
            }
        }
    }
}
