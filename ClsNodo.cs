using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    class ClsNodo
    {
        
       
        private Int32 cod;
        private string nom;
        private string tra;
        private ClsNodo sig;
        private ClsNodo ant;



        public Int32 Codigo
        {
            get { return cod; }//get retorna el dato
            set { cod = value; }//set envia el dato
        }

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public ClsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }

        }

        public ClsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }

        }

        public ClsNodo Izquierdo
        {
            get { return ant; }
            set { ant = value; }
        }

        public ClsNodo Derecho 
        {
            get { return sig; }
            set { sig = value; }
        }


    }
}
