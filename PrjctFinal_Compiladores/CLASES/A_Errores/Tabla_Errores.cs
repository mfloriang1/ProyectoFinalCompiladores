using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Clases
{
    class Tabla_Errores
    {
        public static List<MD_TErrores> TErrores = new List<MD_TErrores>();
        public static List<MD_TErrores> TErrores2 = new List<MD_TErrores>();


        
        public List<MD_TErrores> TablaErrores
        {
            get { return TErrores; }
            set { TErrores = value; }
        }
        public void reinicialista()
        {
            TErrores = new List<MD_TErrores>();
            TErrores2 = new List<MD_TErrores>();
        }
        public void establecer_errores()
        {

            MD_TErrores te = new MD_TErrores(0, 0, "Error lexico", "Verifique la palabra reservada", "La palabra reservada esta mal escrita o no es reconocida");
            TErrores.Add(te);

            te = new MD_TErrores(1, 0, "Hace falta <jcode>", "Agregue al inicio y al final <jcode>", "El error sucede cuando no se abre o cierra <jcode>");
            TErrores.Add(te);

            te = new MD_TErrores(2,0, "error al abrir", "revise la extencion del archivo o  la direccion del mismo", "error al abrir el archivo");
            TErrores.Add(te);

            te = new MD_TErrores(3,0, "Error lexico", "Verifique el nombre del identificador", "Se produce cuando el nombre de un identificador no cumple con las caracteristicas");
            TErrores.Add(te);

            te = new MD_TErrores(4,0, "Sintaxis desconocida", "Verifique que la sintaxis de la expresion este bien escrita", "Se produce cuando se desconoce la sintaxis de la expresion");
            TErrores.Add(te);

            te = new MD_TErrores(5,0, "Sintaxis erronea", "Verifique que la sintaxis de la expresion este bien escrita", "Se produce cuando a la sintaxis le hace falta algo o tiene un error");
            TErrores.Add(te);
            te = new MD_TErrores(6, 0, "Error lexico", "Verifique que el numero sea correcto", "Se produce cuando un numero no esta bien escrito o no cumple con las caracteristicas");
            TErrores.Add(te);
            te = new MD_TErrores(7, 0, "Error lexico", "Verifique los operadores", "Se produce cuando un numero no esta bien escrito o no cumple con las caracteristicas");
            TErrores.Add(te);


        }

        public List<MD_TErrores> llamatablaE()
        {
            return TErrores2;
        }
        public int tamatablaE()
        {
            return TErrores2.Count;
        }


        public void nuevoerror(int id, int nl, string se)
        {
            establecer_errores();
            foreach (var error in TErrores)
            {

                if (error.Id == id)
                {
                    MD_TErrores er = new MD_TErrores();
                    er.ID = error.ID;
                    er.Descripcion = error.Descripcion;
                    er.Solucion = se;
                    er.Error = error.Error;
                    er.NumerodeLinea = nl;
                    TErrores2.Add(er);
                }

            }

        }
        public void nuevoerror(int id)
        {
            establecer_errores();
            foreach (var error in TErrores)
            {

                if (error.Id == id)
                {
                    MD_TErrores er = new MD_TErrores();
                    er.Descripcion = error.Descripcion;
                    er.Solucion = error.Solucion;
                    er.Id = error.Id;
                    TErrores2.Add(er);
                }

            }

        }
    }
}

