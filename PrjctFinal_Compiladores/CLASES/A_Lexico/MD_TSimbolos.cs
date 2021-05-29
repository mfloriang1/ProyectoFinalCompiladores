using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Clases.AL
{
   public class MD_TSimbolos
    {

        public string valor;
        public int NumLinea;
        public int id;
        public string tipo;

        public MD_TSimbolos(string valor, int num_linea, int id, string tipo)
        {

            this.valor = valor;
            NumLinea = num_linea;
            this.id = id;
            this.tipo = tipo;

        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public int Numero_de_linea
        {
            get { return NumLinea; }
            set { NumLinea = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}
