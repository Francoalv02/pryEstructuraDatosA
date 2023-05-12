using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Librerias ext
using System.IO;

namespace pryEstructuraDatos
{
    class clsArbolBinario
    {
        private ClsNodo Inicio;
        private string nombre;
        private string tramite;
        

        public ClsNodo Raiz 
            {
                get { return Inicio; }
                set { Inicio = value; }
            }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Tramite
        {
            get { return tramite; }
            set { tramite = value; }
        }

        public void Agregar(ClsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                ClsNodo NodoPadre = Raiz;//ant
                ClsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                //afuera del while
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;

                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        public void Eliminar(Int32 codigo)
        {
            ClsNodo Buscar = Raiz;
            ClsNodo Aux = null;

            while (Buscar.Codigo != codigo)
            {
                if (codigo < Buscar.Codigo)
                {
                    Aux = Buscar;
                    Buscar = Buscar.Izquierdo;
                }
                else
                {
                    Aux = Buscar;
                    Buscar = Buscar.Derecho;
                }
            }
            if (Buscar.Codigo == codigo)
            {
                if (Buscar.Izquierdo == null && Buscar.Derecho == null)
                {
                    if (Aux == null)
                    {
                        Raiz = null;
                        return;
                    }
                    if (Aux.Izquierdo == Buscar)
                    {
                        Aux.Izquierdo = null;
                        return;
                    }
                    else
                    {
                        Aux.Derecho = null;
                    }
                }
                if (Buscar.Izquierdo == null)
                {
                    if (Aux == null)
                    {
                        Raiz = Buscar.Derecho;
                    }
                    if (Aux.Izquierdo == Buscar)
                    {
                        Aux.Izquierdo = Buscar.Derecho;
                    }
                    else
                    {
                        Aux.Derecho = Buscar.Derecho;
                    }
                }
                if (Buscar.Derecho == null)
                {
                    if (Aux == null)
                    {
                        Raiz = Buscar.Izquierdo;
                    }
                    if (Aux.Izquierdo == Buscar)
                    {
                        Aux.Izquierdo = Buscar.Izquierdo;
                    }
                    else
                    {
                        Aux.Derecho = Buscar.Izquierdo;
                    }
                }
                if (Buscar.Izquierdo != null && Buscar.Derecho != null)
                {
                    ClsNodo Reemplazo = Buscar.Derecho;
                    ClsNodo AuxReemplazo = Buscar;
                    while (Reemplazo.Izquierdo != null)
                    {
                        AuxReemplazo = Reemplazo;
                        Reemplazo = Reemplazo.Izquierdo;
                    }

                    Buscar.Codigo = Reemplazo.Codigo;
                    Buscar.Nombre = Reemplazo.Nombre;
                    Buscar.Tramite = Reemplazo.Tramite;
                    if (AuxReemplazo == Buscar)
                    {
                        AuxReemplazo.Derecho = Reemplazo.Derecho;
                    }
                    else
                    {
                        AuxReemplazo.Izquierdo = Reemplazo.Derecho;
                    }
                }
            }
        }
        


        private ClsNodo[] Vec = new ClsNodo[100];
        private Int32 i = 0;

        public void Equilibrar()
        {
            i = 0;
            CargarVector(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void CargarVector(ClsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVector(NodoPadre.Izquierdo);
            }
            Vec[i] = NodoPadre;
            i ++;
            if (NodoPadre.Derecho != null)
            {
                CargarVector(NodoPadre.Derecho);
            }
        }

        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vec[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void RecorrerPreOrden(TreeView Arbol)
        {
            Arbol.Nodes.Clear();
            PreOrden(Arbol.Nodes, Raiz);
        }
        public void PreOrden(TreeNodeCollection NodoPadre, ClsNodo R)
        {
            TreeNode NuevoNodo = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null)
            {
                PreOrden(NuevoNodo.Nodes, R.Izquierdo);

            }
            if (R.Derecho != null)
            {
                PreOrden(NuevoNodo.Nodes, R.Derecho);
            }
        }


        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox Lst,ClsNodo Raiz) //1
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(Lst, Raiz.Izquierdo);//Izquierdo
            Lst.Items.Add(Raiz.Codigo);//Raiz
            if (Raiz.Derecho != null) InOrdenAsc(Lst, Raiz.Derecho);//Derecho
        }

        public void InOrdenDec(ListBox Lst, ClsNodo Raiz)//2
        {
            if (Raiz.Derecho != null) InOrdenAsc(Lst, Raiz.Derecho);//Derecho
            
            Lst.Items.Add(Raiz.Codigo);//Raiz

            if (Raiz.Izquierdo != null) InOrdenAsc(Lst, Raiz.Izquierdo);//Izquierdo
        }

        //EJEMPLO//public void InOrdenAsc(ListBox Lst, ClsNodo Raiz)
        //{
        //    if (Raiz.Izquierdo != null) InOrdenAsc(Lst, Raiz.Izquierdo);
        //    if (Raiz.Tramite == "Pagar") Lst.Items.Add(Raiz.Codigo);
        //      --------aca se pregunta por una accion en especifica y se ejecuta solamento esa---------
        //    if (Raiz.Derecho != null) InOrdenAsc(Lst, Raiz.Derecho);
        //}

        public void PreOrdenAsc(ListBox Lst, ClsNodo Raiz)//3
        {
            Lst.Items.Add(Raiz.Codigo);//Raiz

            if (Raiz.Izquierdo != null) InOrdenAsc(Lst, Raiz.Izquierdo);//Izquierdo
            
            if (Raiz.Derecho != null) InOrdenAsc(Lst, Raiz.Derecho);//Derecho
        }

        public void PostOrdenAsc(ListBox Lst, ClsNodo Raiz)//4
        {
            if (Raiz.Izquierdo != null) InOrdenAsc(Lst, Raiz.Izquierdo);//Izquierdo
            
            if (Raiz.Derecho != null) InOrdenAsc(Lst, Raiz.Derecho);//Derecho

            Lst.Items.Add(Raiz.Codigo);//Raiz
        }

        public void RecorrerInOrdenAsc(ListBox Lista) //Recorrer la lista en ascendente
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void RecorrerInOrdenAsc(ComboBox Combo) //Recorrer el combo en Ascendente
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void RecorrerInOrdenAsc(DataGridView Grilla) //Recorrer la grilla en Ascendente
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        public void RecorrerInOrdenDes(ListBox Lista)//Recorrer la lista en Descendente
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }

        public void RecorrerInOrdenDes(ComboBox Combo) //Recorrer el combo en Descendente
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }

        public void RecorrerInOrdenDes(DataGridView Grilla) //Recorrer la grilla en Ascendente
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);
        }

        public void RecorrerPreOrden(ListBox Lst) //Recorrer el combo en PreOrden
        {
            Lst.Items.Clear();
            PreOrden(Lst, Raiz);
        }
        public void RecorrerPreOrden(ComboBox Combo) //Recorrer el combo en PreOrden
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }

        public void RecorrerPreOrden(DataGridView Grilla) //Recorrer la grilla en Ascendente
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void RecorrerPostOrden(ComboBox Combo)//Recorrer el combo en PosOrden
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }
        public void RecorrerPostOrden(ListBox Lst) //Recorrer la lisbox en PostOrden
        {
            Lst.Items.Clear();
            PostOrden(Lst, Raiz);
        }

        public void RecorrerPostOrden(DataGridView Grilla) //Recorrer la grilla en Ascendente
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }



        //----------------------------Metodos--------------------



        //Metodo recorrer la grilla ( Ascendente )
        public void InOrdenAsc(DataGridView Grilla, ClsNodo R) 
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Grilla, R.Izquierdo);
            }
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null)
            {
                InOrdenAsc(Grilla, R.Derecho);
            }
        }



        //Metodo recorrer el combo ( Ascendente )
        public void InOrdenAsc(ComboBox Combo, ClsNodo R) 
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Combo, R.Izquierdo);
            }
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Combo, R.Derecho);
            }
        }



        //Metodo recorrer la lista ( Descendente )
        public void InOrdenDes(ListBox Lst, ClsNodo R) 
        {
            if (R.Derecho != null)
            {
                InOrdenDes(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);          
            if (R.Izquierdo != null)
            {
                InOrdenDes(Lst, R.Izquierdo);
            }
        }



        //Metodo recorrer el combo ( Descendente )
        public void InOrdenDes(ComboBox Combo, ClsNodo R) 
        {
            if (R.Derecho != null)
            {
                InOrdenDes(Combo, R.Derecho);
            }
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDes(Combo, R.Izquierdo);
            }
        }


        //Metodo recorrer la grilla ( Ascendente )
        public void InOrdenDes(DataGridView Grilla, ClsNodo R) 
        {
            if (R.Derecho != null)
            {
                InOrdenDes(Grilla, R.Derecho);
            }
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                InOrdenDes(Grilla, R.Izquierdo);
            }
        }



        //Metodo recorrer la lista ( PreOrden )
        public void PreOrden(ListBox Lst, ClsNodo R) 
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Lst, R.Derecho);
            }
        }



        //Metodo recorrer el combo ( PreOrden )
        public void PreOrden(ComboBox Combo, ClsNodo R) 
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                PreOrden(Combo, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Combo, R.Derecho);
            }
        }
        
        
        //Metodo recorrer la grilla ( Ascendente )
        public void PreOrden(DataGridView Grilla, ClsNodo R) 
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                PreOrden(Grilla, R.Izquierdo);
            }           
            if (R.Derecho != null)
            {
                PreOrden(Grilla, R.Derecho);
            }
        }



        //Metodo recorrer la lista (PostOrden)
        public void PostOrden(ListBox Lst, ClsNodo R) 
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
        }
        
        
        
        //Metodo recorrer el combo (PostOrden)
        public void PostOrden(ComboBox Combo, ClsNodo R) 
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Combo, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Combo, R.Derecho);
            }
            Combo.Items.Add(R.Codigo);
        }
        
        
        
        //Metodo recorrer la grilla(Ascendente)
        public void PostOrden(DataGridView Grilla, ClsNodo R) 
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Grilla, R.Izquierdo);
            }      
            if (R.Derecho != null)
            {
                PostOrden(Grilla, R.Derecho);
            }
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }



        
    }

}
