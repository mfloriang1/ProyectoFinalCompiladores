namespace Compilador
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.PanelCodigo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSimbolos = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.lblLineas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EtiquetaSimb = new System.Windows.Forms.Label();
            this.tablasimbolos = new System.Windows.Forms.DataGridView();
            this.txtcodigo = new System.Windows.Forms.RichTextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.EtiquetaError = new System.Windows.Forms.Label();
            this.dataerrores = new System.Windows.Forms.DataGridView();
            this.PanelCodigo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablasimbolos)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataerrores)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBotones
            // 
            this.PanelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBotones.Location = new System.Drawing.Point(735, 0);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(12, 749);
            this.PanelBotones.TabIndex = 0;
            // 
            // PanelCodigo
            // 
            this.PanelCodigo.Controls.Add(this.panel3);
            this.PanelCodigo.Controls.Add(this.panel2);
            this.PanelCodigo.Controls.Add(this.panel1);
            this.PanelCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCodigo.Location = new System.Drawing.Point(735, 0);
            this.PanelCodigo.Name = "PanelCodigo";
            this.PanelCodigo.Size = new System.Drawing.Size(12, 749);
            this.PanelCodigo.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 749);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 749);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 749);
            this.panel1.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 749);
            this.panel8.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.EtiquetaSimb);
            this.panel7.Controls.Add(this.tablasimbolos);
            this.panel7.Controls.Add(this.txtcodigo);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.dataerrores);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(735, 749);
            this.panel7.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAbrir);
            this.panel6.Controls.Add(this.btnRun);
            this.panel6.Controls.Add(this.btnGuardar);
            this.panel6.Controls.Add(this.lblSimbolos);
            this.panel6.Controls.Add(this.lblErrores);
            this.panel6.Controls.Add(this.lblLineas);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(38, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(677, 179);
            this.panel6.TabIndex = 3;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(260, 65);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(103, 59);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "ABRIR";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(403, 65);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(103, 59);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "EJECUTAR";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(539, 65);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 59);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblSimbolos
            // 
            this.lblSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimbolos.ForeColor = System.Drawing.Color.White;
            this.lblSimbolos.Location = new System.Drawing.Point(139, 138);
            this.lblSimbolos.Name = "lblSimbolos";
            this.lblSimbolos.Size = new System.Drawing.Size(98, 31);
            this.lblSimbolos.TabIndex = 7;
            this.lblSimbolos.Text = "0";
            this.lblSimbolos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrores
            // 
            this.lblErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.White;
            this.lblErrores.Location = new System.Drawing.Point(139, 76);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(98, 31);
            this.lblErrores.TabIndex = 6;
            this.lblErrores.Text = "0";
            this.lblErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLineas
            // 
            this.lblLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineas.ForeColor = System.Drawing.Color.White;
            this.lblLineas.Location = new System.Drawing.Point(139, 20);
            this.lblLineas.Name = "lblLineas";
            this.lblLineas.Size = new System.Drawing.Size(98, 31);
            this.lblLineas.TabIndex = 5;
            this.lblLineas.Text = "0";
            this.lblLineas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "Simbolos:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Errores:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lineas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EtiquetaSimb
            // 
            this.EtiquetaSimb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EtiquetaSimb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaSimb.ForeColor = System.Drawing.Color.White;
            this.EtiquetaSimb.Location = new System.Drawing.Point(10, 366);
            this.EtiquetaSimb.Name = "EtiquetaSimb";
            this.EtiquetaSimb.Size = new System.Drawing.Size(725, 29);
            this.EtiquetaSimb.TabIndex = 13;
            this.EtiquetaSimb.Text = "TABLA DE SIMBOLOS";
            this.EtiquetaSimb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EtiquetaSimb.Click += new System.EventHandler(this.EtiquetaSimb_Click);
            // 
            // tablasimbolos
            // 
            this.tablasimbolos.BackgroundColor = System.Drawing.Color.White;
            this.tablasimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablasimbolos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablasimbolos.Location = new System.Drawing.Point(10, 395);
            this.tablasimbolos.Name = "tablasimbolos";
            this.tablasimbolos.ReadOnly = true;
            this.tablasimbolos.Size = new System.Drawing.Size(725, 159);
            this.tablasimbolos.TabIndex = 8;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            this.txtcodigo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Location = new System.Drawing.Point(38, 188);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(677, 214);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.EtiquetaError);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(10, 554);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(725, 29);
            this.panel11.TabIndex = 12;
            // 
            // EtiquetaError
            // 
            this.EtiquetaError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EtiquetaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiquetaError.ForeColor = System.Drawing.Color.White;
            this.EtiquetaError.Location = new System.Drawing.Point(0, 0);
            this.EtiquetaError.Name = "EtiquetaError";
            this.EtiquetaError.Size = new System.Drawing.Size(725, 29);
            this.EtiquetaError.TabIndex = 0;
            this.EtiquetaError.Text = "TABLA DE ERRORES";
            this.EtiquetaError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataerrores
            // 
            this.dataerrores.BackgroundColor = System.Drawing.Color.White;
            this.dataerrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataerrores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataerrores.Location = new System.Drawing.Point(10, 583);
            this.dataerrores.Name = "dataerrores";
            this.dataerrores.RowTemplate.ReadOnly = true;
            this.dataerrores.Size = new System.Drawing.Size(725, 166);
            this.dataerrores.TabIndex = 0;
            this.dataerrores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(747, 749);
            this.Controls.Add(this.PanelCodigo);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.panel7);
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANALIZADOR C++";
            this.Load += new System.EventHandler(this.principal_Load);
            this.PanelCodigo.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablasimbolos)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataerrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Panel PanelCodigo;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label lblSimbolos;
        public System.Windows.Forms.Label lblErrores;
        public System.Windows.Forms.Label lblLineas;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label EtiquetaSimb;
        public System.Windows.Forms.DataGridView tablasimbolos;
        public System.Windows.Forms.RichTextBox txtcodigo;
        private System.Windows.Forms.Panel panel11;
        public System.Windows.Forms.Label EtiquetaError;
        public System.Windows.Forms.DataGridView dataerrores;
    }
}

