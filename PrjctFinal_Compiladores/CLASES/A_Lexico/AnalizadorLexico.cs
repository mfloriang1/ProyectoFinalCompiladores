using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Compilador.Clases.AS;

namespace Compilador.Clases.AL
{
    public class AnalizadorLexico
    {
        Reglas reg = new Reglas();
        private principal frm;
        Tabla_Errores te = new Tabla_Errores();
        public static int numero_de_lineas = 0;
        Sentencias sen = new Sentencias();
        #region expresiones regulares
        Regex numeros = new Regex(@"^[0-9]+([.|,][0-9]+)?$");                        
        #endregion
        public void puerta(principal form)
        {
            this.frm = form;
        }
        public void aplicar_AL(string archivo)
        {
            
            int contador = 0;
            string pal = "";
            int nm2 = 0, nm = 0;
            reg.limpiar();
            numero_de_lineas = 0;
            try
            {
                StreamReader reader = new StreamReader(archivo);
                List<string> Palabras_Separadas = new List<string>();
                string read, rd2 ="";
                string resul, html = "", html1 = "", html2 = "", txt="";


                frm.txtcodigo.Select(0, frm.txtcodigo.SelectionStart);

                while (reader != null && reader.EndOfStream != true)
                {
                    numero_de_lineas += 1;

                    read = reader.ReadLine().Trim();
                    if (!string.IsNullOrWhiteSpace(read))
                    {


                        #region Separador << o >> 
                        if (Regex.IsMatch(read, @"(<<)")) { resul = Regex.Replace(read, @"(\<\<)", " << "); read = resul; }
                        if (Regex.IsMatch(read, @"(>>)")) { resul = Regex.Replace(read, @"(\>\>)", " >> "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador punto
                        if (Regex.IsMatch(read, @"(\.)")) { resul = Regex.Replace(read, @"(\.)", " . "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador coma
                        if (Regex.IsMatch(read, @"(\,)")) { resul = Regex.Replace(read, @"(\,)", " , "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador ( o ) 
                        if (Regex.IsMatch(read, @"(\(\))")) { resul = Regex.Replace(read, @"(\(\))", " () "); read = resul; }
                        if (Regex.IsMatch(read, @"(\()")) { resul = Regex.Replace(read, @"(\()", " ( "); read = resul; }
                        if (Regex.IsMatch(read, @"(\))")) { resul = Regex.Replace(read, @"(\))", " ) "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador asignacion :=
                        if (Regex.IsMatch(read, @"(\:\=)")) { resul = Regex.Replace(read, @"(\:\=)", " := "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador :
                        if (Regex.IsMatch(read, @"(\:)")) { resul = Regex.Replace(read, @"(\:)", " : "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador =

                        if (Regex.IsMatch(read, @"(\=)")) { resul = Regex.Replace(read, @"(\=)", " = "); read = resul; }
                        if (Regex.IsMatch(read, @"\s+\=\s+\=\s+")) { resul = Regex.Replace(read, @"\s+\=\s+\=\s+", " == "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador ;
                        if (Regex.IsMatch(read, @"(\;)")) { resul = Regex.Replace(read, @"(\;)", " ; "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador [ o ] 
                        if (Regex.IsMatch(read, @"(\[\])")) { resul = Regex.Replace(read, @"(\[\])", " [] "); read = resul; }
                        if (Regex.IsMatch(read, @"(\[)")) { resul = Regex.Replace(read, @"(\[)", " [ "); read = resul; }
                        if (Regex.IsMatch(read, @"(\])")) { resul = Regex.Replace(read, @"(\])", " ] "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador { o } 
                        if (Regex.IsMatch(read, @"(\{)")) { resul = Regex.Replace(read, @"(\{)", " { "); read = resul; }
                        if (Regex.IsMatch(read, @"(\})")) { resul = Regex.Replace(read, @"(\})", " } "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador ^ 
                        if (Regex.IsMatch(read, @"(\^)")) { resul = Regex.Replace(read, @"(\^)", " ^ "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador + 
                        if (Regex.IsMatch(read, @"(\+)")) { resul = Regex.Replace(read, @"(\+)", " + "); read = resul; }
                        if (Regex.IsMatch(read, @"(\+\+)")) { resul = Regex.Replace(read, @"(\+\+)", " ++ "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador - 
                        if (Regex.IsMatch(read, @"(\-)")) { resul = Regex.Replace(read, @"(\-)", " - "); read = resul; }
                        if (Regex.IsMatch(read, @"(\-\-)")) { resul = Regex.Replace(read, @"(\-\-)", " -- "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador * 
                        if (Regex.IsMatch(read, @"(\*)")) { resul = Regex.Replace(read, @"(\*)", " * "); read = resul; }
                        else { resul = read; }
                        #endregion
                        #region Separador / 
                        if (Regex.IsMatch(read, @"(\/)"))
                        {
                            if (!Regex.IsMatch(read, @"(\<\/)|(\/\>)"))
                            {
                                resul = Regex.Replace(read, @"(\/)", " / ");
                                read = resul;
                            }
                        }
                        else { resul = read; }
                        #endregion

                        #region cadenas
                        if (Regex.IsMatch(read, @"" + "(\"" + "(.*)" + "\")|('.*')"))
                        {
                            if (Regex.IsMatch(read, @"" + "(\"" + "(.*)" + "\")"))
                            {
                                rd2 = read;
                                resul = Regex.Replace(read, @"" + "(\"" + "(.*)" + "\")", "x");
                                read = resul;
                            }
                            if (Regex.IsMatch(read, @"('.+')"))
                            {
                                rd2 = read;
                                resul = Regex.Replace(read, @"('.+')", "x");
                                read = resul;
                            }
                           
                        }
                        #region texto html
                        if (Regex.IsMatch(read, @"(\>.+\<)"))
                        {
                            txt = Regex.Match(read, @"(\>.+\<)").ToString();
                                resul = Regex.Replace(read, @"(\>.+\<)", "> y <");
                                read = resul;

                        }
                        #endregion
                        #endregion
                        #region Separador  
                        if (Regex.IsMatch(read, @"(\s\s+)")) { resul = Regex.Replace(read, @"(\s\s+)", " "); read = resul; }
                        else { resul = read; }
                        #endregion
                        Palabras_Separadas = resul.Trim().Split(' ').ToList();
                        Match n = Regex.Match(rd2, @"" + "(\"" + "(.*)" + "\")|('.*')");
                        if (n.Value.ToString() != "")
                        {
                            var x = Palabras_Separadas.FindIndex(i => Regex.IsMatch(i, @"x"));
                            string p = Palabras_Separadas[x];
                            Palabras_Separadas[x] = n.Value.ToString();
                            if (p != "x")
                            {
                                Palabras_Separadas.Add(";");
                            }
                            rd2 = "";
                        }
                        if(txt != "")
                        {
                            var x = Palabras_Separadas.FindIndex(i => Regex.IsMatch(i, @"y"));
                            Palabras_Separadas[x] = txt;
                            txt = "";
                        }

                        foreach (var palabra in Palabras_Separadas)
                        {
                            contador += 1;
                            if (Regex.IsMatch(palabra, @"(\>[a-zA-Z]+\<)|(\>[a-zA-Z]+)|([a-zA-Z]+\<)"))
                            {
                                nm = 1;
                                string p = "";

                                
                            }
                            else if (Regex.IsMatch(palabra, @"^[0-9]"))
                            {
                                Match m = Regex.Match(palabra, @"[0-9]+([.|,][0-9]+)?");
                                if (numeros.IsMatch(m.Value.ToString()))
                                {
                                    MD_TSimbolos nuevo = new MD_TSimbolos(m.Value.ToString(), numero_de_lineas, contador, "Numero");
                                    reg.añadir_objeto(nuevo);
                                    reg.comparar(palabra.ToString(), numero_de_lineas, contador);
                                }
                                else
                                {
                                    MD_TSimbolos nuevo = new MD_TSimbolos(palabra, numero_de_lineas, contador, "Numero");
                                    reg.añadir_objeto(nuevo);
                                    te.nuevoerror(6, numero_de_lineas, "Verifique el numero ingresado, en la linea " + numero_de_lineas);
                                }
                            }
                            else if (reg.comparar(palabra.ToString(), numero_de_lineas, contador))
                            {



                            }
                            else if (Regex.IsMatch(palabra, @"(" + "\"" + "(.+)" + "\")|('.+')"))
                            {
                                Match m = Regex.Match(palabra, @"(" + "\"" + "(.+)" + "\")|('.+')");
                                MD_TSimbolos nuevo = new MD_TSimbolos(m.Value.ToString(), numero_de_lineas, contador, "Cadena de texto");
                                reg.añadir_objeto(nuevo);
                            }
                            //Reglas de C++
                            else if (Regex.IsMatch(palabra, @"(^([a-zA-Z])|(\\_))((([a-zA-Z])|([0-9])|(\\_))+)?$"))
                            {
                                MD_TSimbolos nuevo = new MD_TSimbolos(palabra, numero_de_lineas, contador, "Variable");
                                reg.añadir_objeto(nuevo);
                                //reg.contador_Cplus += 1;
                            }
                            else
                            {
                                MD_TSimbolos nuevo = new MD_TSimbolos(palabra, numero_de_lineas, contador, "Desconocido");
                                reg.añadir_objeto(nuevo);
                                te.nuevoerror(3, numero_de_lineas, "Verifique la entrada cerca de  " + palabra);
                            }


                        }
                    }
                }
                    Palabras_Separadas = null;
                    nm = 0;
                    reader.Close();
                    MessageBox.Show("Analisis lexico terminado");
                    reg.contador_Cplus = 0;
            }
            catch (ArgumentNullException)
            {

                MessageBox.Show("El archivo no se abrio correctamente");

                te.nuevoerror(2);
            }
        
            catch (Exception ex)
            {
                MessageBox.Show("Error en el analizador lexico " + ex.Message);
            }
        }
    }
}
