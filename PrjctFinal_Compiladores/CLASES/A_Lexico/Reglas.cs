using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Compilador.Clases.AL
{
    public class Reglas
    {
        public static List<MD_TSimbolos> reglas = new List<MD_TSimbolos>();
        public static List<MD_TSimbolos> Tabla_simbolos = new List<MD_TSimbolos>();
        public  int contador_Cplus=0;
        public List<MD_TSimbolos> TSimbolos2
        {
            get { return reglas; }
            set { reglas = value; }
        }

        public List<MD_TSimbolos> llamatabla()
        {
            return Tabla_simbolos;
        }
        public int tamaimbolos()
        {
            return Tabla_simbolos.Count;
            
        }
        public void limpiar()
        {
            Tabla_simbolos = new List<MD_TSimbolos>();
            reglas = new List<MD_TSimbolos>();
        }
        public bool comparar(string palabra, int num_linea, int contador)
        {
          
            bool r = false;
            #region Palabras Reservadas
            if (Regex.IsMatch(palabra, @"public"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("public", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"private"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("private", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"class"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("class", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"else", RegexOptions.IgnoreCase))
            {
                MD_TSimbolos tab = new MD_TSimbolos("else", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"null", RegexOptions.IgnoreCase))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"^(cin)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("cin", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(cout)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("cout", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(int)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(double)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(const)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(return)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(namespace)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(main)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("main", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(#include)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(break)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("break", num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(void)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(enum)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(continue)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(new)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Palabra Reservada");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            #endregion

            #region Expresiones logicas
            else if (Regex.IsMatch(palabra, @"^(=)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(;)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(";", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\()"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("(", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\))"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(")", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\{)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("{", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\})"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("}", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\[)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("[", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\.)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(".", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\,)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(",", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(\])"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("]", num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(<)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(>)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(<=)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(>=)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(!=)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Operador Relacional");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(&&)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresion logica");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(\|\|)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresion logica");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(<<)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("<<", num_linea, contador, "Expresion logica");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            if (Regex.IsMatch(palabra, @"(>>)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(">>", num_linea, contador, "Expresion logica");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(\^)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresiones matematicas");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            #endregion

            #region Expresiones matematicas

            else if (Regex.IsMatch(palabra, @"^(\+)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresiones matematicas");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(\-)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresiones matematicas");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(\*)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresiones matematicas");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(\/)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresiones matematicas");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(\+\+)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresiones matematicas");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(\-\-)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Expresiones matematicas");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            #endregion

            #region ciclos
            else if (Regex.IsMatch(palabra, @"^(FOR)$", RegexOptions.IgnoreCase))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Ciclos");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(do)$"))
            {
                MD_TSimbolos tab = new MD_TSimbolos(palabra, num_linea, contador, "Ciclos");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;

                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(while)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("while", num_linea, contador, "Ciclos");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            #endregion

            #region Condicionales
            else if (Regex.IsMatch(palabra, @"^(if)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("if", num_linea, contador, "Condicionales");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            else if (Regex.IsMatch(palabra, @"^(switch)"))
            {
                MD_TSimbolos tab = new MD_TSimbolos("switch", num_linea, contador, "Condicionales");
                Tabla_simbolos.Add(tab);
                contador_Cplus += 1;
                r = true;
            }
            #endregion

            return r;
        }
        public void añadir_objeto(MD_TSimbolos Ts)
        {
            Tabla_simbolos.Add(Ts);
        }

    }
}
