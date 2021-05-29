using Compilador.Clases.AL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compilador.Clases.AS
{
   public class Sentencias
    {
        
        Reglas reg = new Reglas();
        int total_lineas = 0;
        List<MD_TSimbolos> tabla;
        public string[] uniendo_lineas(string lenguaje)
        {
            total_lineas = AnalizadorLexico.numero_de_lineas;
            tabla = Reglas.Tabla_simbolos;
            string sentencia = null;
            string[] sentencias = new string[total_lineas+1];
            int bandera = 0, c = 0;
            string tipov = "", x="", y="";

            switch (lenguaje)
            {
                #region C++
                case "C++":
                    
                    for (int i = 1; i < total_lineas + 1; i++) //une los token de cada linea
                    {
                        
                        foreach (var token in tabla)
                        {
                            if ((token.NumLinea == i || c == 1) && token != null)
                            {
                                if (bandera == 0 && Regex.IsMatch(token.valor, @"(public)|(private)|(class)|(else)
                                |(null)|(cin)|(cout)|(int)|(double)|(const)|(return)|(namespace)|(main)|(#include)
                                |(break)|(void)|(enum)|(continue)|(new)|(this)|(for)|(do)|(while)
                                |(if)|(switch)", RegexOptions.IgnoreCase))
                                {
                                    tipov = token.valor;
                                    
                                }
                                if (bandera != 0)
                                {
                                    sentencia = sentencia + " " + token.valor.ToString();
                                    //token.tipo = tipov;
                                }
                                else
                                {
                                    sentencia = sentencia + token.valor.ToString();
                                    bandera = 1;
                                }
                            }
                        }
                        sentencias[i] = sentencia;
                        sentencia = null;
                        bandera = 0;
                        tipov = "";
                        c = 0;
                    }
                    break;
                #endregion
            }

            return sentencias;
        }

    }
}
