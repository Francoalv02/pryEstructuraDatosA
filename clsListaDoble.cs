using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        //declaro los dos campos
        private ClsNodo pri;
        private ClsNodo ult;

        //declaro las dos propiedades
        public ClsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public ClsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(ClsNodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;

            }
            else
            {
                if (Nvo.Codigo <= Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    if (Nvo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else 
                    {
                        ClsNodo Aux = Primero;
                        ClsNodo Ant = Primero;
                        while (Aux.Codigo < Nvo.Codigo)
                        {
                            Ant= Aux;
                            Aux = Ant.Siguiente;
                        }
                        Ant.Siguiente = Nvo;
                        Nvo.Siguiente = Aux;
                        Ant.Anterior = Nvo;
                        Nvo.Siguiente = Aux;                        
                    }
                }
            }

        }

        public void Eliminar(Int32 Codigo) 
        {
            //si el dato que borro es el unico de la lista
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;

            }
            else
            {
                //si quiero borrar el primero ,tengo que poner el primero.siguiente como primero y el primero anterior lo pongo en nulo
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    //si quiero borrar el ultimo, tengo q poner como ultimo a ultimo.anterior y ultimo.siguiente le pongo null para cortar la cadena

                    if (Ultimo.Codigo == Codigo)
                    {                        
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        //para borrar un dato del medio de la cadena
                        ClsNodo aux = Primero;
                        ClsNodo ant = Primero;

                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;

                        }
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;

                        //------------si distancio primero------------------

                        //ant = aux.siguiente
                        //ant.Siguiente = Aux
                        //aux.anterior = ant

                        //--------------otra forma-------------------------------

                        //ant.Siguiente = aux.Siguiente;
                        //aux = aux.Siguiente;
                        //aux.Anterior = ant;

                    }
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

        //public void RecorrerDes(DataGridView Grilla)
        //{
        //    ClsNodo Aux = Ultimo;
        //    Grilla.Rows.Clear();

        //    while (Aux != null)
        //    {
        //        Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
        //        Aux = Aux.Anterior;
        //    }
        //}
        //public void RecorrerDes(ListBox Lista)
        //{
        //    ClsNodo Aux = Ultimo;
        //    Lista.Items.Clear();

        //    while (Aux != null)
        //    {
        //        Lista.Items.Add(Aux.Codigo + "" + Aux.Nombre + "" + Aux.Tramite);
        //        Aux = Aux.Anterior;
        //    }
        //}

        //public void RecorrerDes(ComboBox Combo)
        //{
        //    ClsNodo Aux = Ultimo;
        //    Combo.Items.Clear();

        //    while (Aux != null)
        //    {
        //        Combo.Items.Add(Aux.Nombre);
        //        Aux = Aux.Anterior;
        //    }
        //}
    }
}
