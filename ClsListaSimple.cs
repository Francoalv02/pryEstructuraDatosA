using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pryEstructuraDatos
{
    class ClsListaSimple
    {


        public ClsNodo Primero;
        
        ClsNodo Ant;

        public void Agregar(ClsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo  <= Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    ClsNodo Aux = Primero;
                    
                    while (Nuevo.Codigo > Aux.Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                        if (Aux == null)
                        {
                            break;
                        }
                    }
                    Ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = Aux;
                }
            }
        }

        public void Recorrer(DataGridView Grilla)
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
                Combo.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }
        }

        public void Eliminar (Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                ClsNodo Ant = Primero;
                ClsNodo Aux = Primero;
                while (Aux.Codigo != Codigo)
                {
                    Ant = Aux;
                    Aux = Aux.Siguiente;

                }
                Ant.Siguiente = Aux.Siguiente;
            }
        }
    }
}
