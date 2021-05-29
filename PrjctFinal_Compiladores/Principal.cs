using Compilador.Clases;
using Compilador.Clases.AL;
using Compilador.Clases.AS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
           
        }
        public static principal _puerta = new principal();
        AnalizadorSintactico asin = new AnalizadorSintactico();
        public string archivo, ruta_archivo;
        Sentencias sent = new Sentencias();
        string[] sentencias;
        AnalizadorLexico al = new AnalizadorLexico();
        Tabla_Errores te = new Tabla_Errores();
        Reglas reg = new Reglas();
        List<MD_TErrores> tErrores = new List<MD_TErrores>();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            guardar_archivo();
            
        }
        public void guardar_archivo()
        {
            
            savefile.Filter = "Archivos cp0|*.cp0";
            if (savefile.ShowDialog() == DialogResult.OK)
            {

                if (File.Exists(savefile.FileName))
                {
                   
                    StreamWriter codigonuevo = File.CreateText(savefile.FileName);
                    codigonuevo.Write(txtcodigo.Text);
                    codigonuevo.Flush();
                    codigonuevo.Close();
                    archivo = savefile.FileName;
                    ruta_archivo = savefile.FileName;
                    leerarchivo(archivo);
                }
                else
                {
                    // el archivo no extiste

                    StreamWriter codigonuevo = File.CreateText(savefile.FileName);
                    codigonuevo.Write(txtcodigo.Text);
                    codigonuevo.Flush();
                    codigonuevo.Close();
                    archivo = savefile.FileName;
                    ruta_archivo = savefile.FileName;
                    leerarchivo(archivo);
                }


            }
        }
        public void leerarchivo(string archivo)
        {
            StreamReader reader = new StreamReader(archivo, System.Text.Encoding.Default);
           
            string texto;
            texto = reader.ReadToEnd();
            reader.Close();
            txtcodigo.Text = texto;
            txtcodigo.Focus();

        }
        public void revisar_cambios(string archivo)
        {
            try
            {
                if (archivo == null)
                {
                    guardar_archivo();

                }
                else
                {
                    StreamWriter codigonuevo = File.CreateText(archivo);
                    codigonuevo.Write(txtcodigo.Text);
                    codigonuevo.Flush();
                    codigonuevo.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("error al guardar");

            }


        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            abrirarchivo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            revisar_cambios(ruta_archivo);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            limpiar();
            revisar_cambios(ruta_archivo);
            al.puerta(this);
            asin.puerta(this);
            asin.puerta(this);
            al.aplicar_AL(archivo);
            habilitar();
            
        }
        public void limpiar()
        {
            reg.limpiar();
            te.reinicialista();
            sentencias = null;
        }
        public void habilitar()
        {
            dataerrores.Visible = true;
            tablasimbolos.Visible = true;
            EtiquetaError.Visible = true;
            EtiquetaSimb.Visible = true;
            tablasimbolos.DataSource = reg.llamatabla();
            dataerrores.DataSource = te.llamatablaE();
            lblSimbolos.Text = reg.tamaimbolos().ToString();
            lblErrores.Text = te.tamatablaE().ToString();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void abrirarchivo()
        {

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Title = "Abrir archivo.cpcode";
                ofd.ShowDialog();
                ofd.Filter = "Archivos cpcode|*.cpcode";
                if (File.Exists(ofd.FileName))
                {
                    using (Stream stream = ofd.OpenFile())
                    {
                        //MessageBox.Show("archivo encontrado:  "+ofd.FileName);
                        leerarchivo(ofd.FileName);
                        archivo = ofd.FileName;
                        ruta_archivo = ofd.FileName;
                        leerarchivo(archivo);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo no se abrio correctamente");
            }
            
        }

        private void EtiquetaSimb_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}
