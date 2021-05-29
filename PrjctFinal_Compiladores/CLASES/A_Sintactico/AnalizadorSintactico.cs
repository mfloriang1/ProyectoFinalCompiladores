using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador.Clases.AS
{
    public class AnalizadorSintactico
    {
        private principal frm;
        Tabla_Errores te = new Tabla_Errores();
        #region analizador sintactico
        public void ASintactico(string[] sentencias, string lenguaje)
        {

            for (int i = 1; i < sentencias.Length; i++)
            {
                //MessageBox.Show(sentencias[i]);
                switch (lenguaje)
                {
                    #region C++
                    case "C++":
                        #region  Analisis Sintactico
                        if (sentencias[i] != null)
                        {
                            #region int
                            if (Regex.IsMatch(sentencias[i], @"(^int)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^int\s((main\s\(\s\))|((\w+)\s(=)\s(\w+)\s\;))$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("Una inicializacion int");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("int");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de int, en la linea " + i);
                                }
                            }
                            #endregion
                            #region cin
                            if (Regex.IsMatch(sentencias[i], @"(^cin)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^cin\s(>>)\s(\w+)\s\;$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cin");
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("Lectura correcta");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cin");
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cin");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de cin, en la linea " + i);
                                }
                            }
                            #endregion
                            #region cout
                            if (Regex.IsMatch(sentencias[i], @"(^cout)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^cout\s<<\s(("+"\"" + ".+" + "\"" + @")(\s\+\s\w+)?)\s\;$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cout");
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("Se escribio en pantalla");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cout");
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("cout");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de cout, en la linea " + i);
                                }
                            }
                            #endregion
                            #region #include
                            if (Regex.IsMatch(sentencias[i], @"(^#include)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^#include\s\<.+\>$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("include");
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("Se agrego la libreria");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("#include");
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("#include");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de #include, en la linea " + i);
                                }
                            }
                            #endregion
                            #region using
                            if (Regex.IsMatch(sentencias[i], @"(^using)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^using\snamespace\s[a-zA-Z]+\s\;$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("using namespace");
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("Se establecio el uso");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("using namespace");
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("using");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de using, en la linea " + i);
                                }
                            }
                            #endregion
                            #region double
                            if (Regex.IsMatch(sentencias[i], @"(^double)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^double\s((\w+)\s(=)\s(\w+)\s\;)$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("double");
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("Inicializacion double");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("double");
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("double");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de double, en la linea " + i);
                                }
                            }
                            #endregion
                            #region do
                            if (Regex.IsMatch(sentencias[i], @"(^do)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^do$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("Se inicializo un ciclo do while");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find(sentencias[i]);
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("do");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de do, en la linea " + i);
                                }
                            }
                            #endregion
                            #region while
                            if (Regex.IsMatch(sentencias[i], @"(^while)"))
                            {

                                if (Regex.IsMatch(sentencias[i], @"^while\s(\(\s((\w+)\s(==|<=|>=|!=|<|>)\s(\w+)\s)\)\s)\;$", RegexOptions.IgnoreCase))
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("while");
                                    frm.txtcodigo.SelectionColor = Color.Yellow;
                                    MessageBox.Show("ciclo while");
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("while");
                                    frm.txtcodigo.SelectionColor = Color.White;
                                }
                                else
                                {
                                    frm.txtcodigo.SelectionStart = frm.txtcodigo.Find("while");
                                    frm.txtcodigo.SelectionColor = Color.Red;
                                    te.nuevoerror(5, i, "Verifique la sintaxis de do, en la linea " + i);
                                }
                            }
                            #endregion
                        }
                        break;
                        #endregion
                        #endregion
                }
            }
            MessageBox.Show("Analisis sintactico terminado");
        }
        #endregion


        public void puerta(principal form)
        {
            this.frm = form;
        }
        
    }
}
