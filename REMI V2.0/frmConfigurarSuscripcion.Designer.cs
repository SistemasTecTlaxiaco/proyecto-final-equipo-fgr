
namespace REMI_V2._0 {
    partial class frmConfigurarSuscripcion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurarSuscripcion));
            this.boxVolverInicio = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxImagen = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarSuscripcion = new System.Windows.Forms.Button();
            this.txtNombreApp = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.txtDescripcion = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.txtFecha = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.txtMoneda = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.numMes = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numDia = new System.Windows.Forms.NumericUpDown();
            this.ofdSeleccionar = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.boxVolverInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).BeginInit();
            this.SuspendLayout();
            // 
            // boxVolverInicio
            // 
            this.boxVolverInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxVolverInicio.Image = ((System.Drawing.Image)(resources.GetObject("boxVolverInicio.Image")));
            this.boxVolverInicio.Location = new System.Drawing.Point(20, 23);
            this.boxVolverInicio.Name = "boxVolverInicio";
            this.boxVolverInicio.Size = new System.Drawing.Size(25, 25);
            this.boxVolverInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boxVolverInicio.TabIndex = 13;
            this.boxVolverInicio.TabStop = false;
            this.boxVolverInicio.Click += new System.EventHandler(this.boxVolverInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(75, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Añadir Suscripción";
            // 
            // boxImagen
            // 
            this.boxImagen.Image = ((System.Drawing.Image)(resources.GetObject("boxImagen.Image")));
            this.boxImagen.Location = new System.Drawing.Point(148, 70);
            this.boxImagen.Name = "boxImagen";
            this.boxImagen.Size = new System.Drawing.Size(64, 64);
            this.boxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boxImagen.TabIndex = 14;
            this.boxImagen.TabStop = false;
            this.boxImagen.Click += new System.EventHandler(this.boxImagen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreApp);
            this.groupBox1.Location = new System.Drawing.Point(170, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 45);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(170, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 45);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(35, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Primer Factura.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFecha);
            this.groupBox3.Location = new System.Drawing.Point(170, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 45);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(35, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ciclo.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numMes);
            this.groupBox4.Location = new System.Drawing.Point(170, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 45);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(35, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Recuerdame.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.numDia);
            this.groupBox5.Location = new System.Drawing.Point(170, 480);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 45);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(35, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Moneda.";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMoneda);
            this.groupBox6.Location = new System.Drawing.Point(170, 550);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(175, 45);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.numPrecio);
            this.groupBox7.Location = new System.Drawing.Point(125, 140);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(115, 40);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            // 
            // numPrecio
            // 
            this.numPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrecio.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.numPrecio.Location = new System.Drawing.Point(29, 11);
            this.numPrecio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numPrecio.Size = new System.Drawing.Size(60, 23);
            this.numPrecio.TabIndex = 0;
            this.numPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPrecio.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "$";
            // 
            // btnGuardarSuscripcion
            // 
            this.btnGuardarSuscripcion.BackColor = System.Drawing.Color.Black;
            this.btnGuardarSuscripcion.FlatAppearance.BorderSize = 0;
            this.btnGuardarSuscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSuscripcion.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSuscripcion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarSuscripcion.Location = new System.Drawing.Point(265, 619);
            this.btnGuardarSuscripcion.Name = "btnGuardarSuscripcion";
            this.btnGuardarSuscripcion.Size = new System.Drawing.Size(80, 30);
            this.btnGuardarSuscripcion.TabIndex = 28;
            this.btnGuardarSuscripcion.Text = "Añadir";
            this.btnGuardarSuscripcion.UseVisualStyleBackColor = false;
            this.btnGuardarSuscripcion.Click += new System.EventHandler(this.btnGuardarSuscripcion_Click);
            // 
            // txtNombreApp
            // 
            this.txtNombreApp.BackColor = System.Drawing.Color.White;
            this.txtNombreApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreApp.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNombreApp.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreApp.Location = new System.Drawing.Point(18, 15);
            this.txtNombreApp.Name = "txtNombreApp";
            this.txtNombreApp.Size = new System.Drawing.Size(141, 20);
            this.txtNombreApp.TabIndex = 0;
            this.txtNombreApp.Text = "Netflix";
            this.txtNombreApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreApp.TextoVacio = "Nombre de la app";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtDescripcion.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(18, 15);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(141, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Entretenimiento";
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescripcion.TextoVacio = "Descripción breve";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtFecha.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(6, 15);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(163, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.TextoVacio = "Fecha en aaaa-mm-dd";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.White;
            this.txtMoneda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoneda.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtMoneda.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.Location = new System.Drawing.Point(17, 15);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(141, 20);
            this.txtMoneda.TabIndex = 1;
            this.txtMoneda.Text = "MXN";
            this.txtMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoneda.TextoVacio = "Tipo de cambio";
            // 
            // numMes
            // 
            this.numMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMes.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.numMes.Location = new System.Drawing.Point(59, 15);
            this.numMes.Name = "numMes";
            this.numMes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numMes.Size = new System.Drawing.Size(42, 23);
            this.numMes.TabIndex = 2;
            this.numMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMes.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.label9.Location = new System.Drawing.Point(13, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Cada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.label10.Location = new System.Drawing.Point(107, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Mes(es)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.label11.Location = new System.Drawing.Point(82, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "Dia(s) Antes";
            // 
            // numDia
            // 
            this.numDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDia.Font = new System.Drawing.Font("SF Pro Display", 12F);
            this.numDia.Location = new System.Drawing.Point(34, 15);
            this.numDia.Name = "numDia";
            this.numDia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numDia.Size = new System.Drawing.Size(42, 23);
            this.numDia.TabIndex = 31;
            this.numDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDia.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ofdSeleccionar
            // 
            this.ofdSeleccionar.FileName = "openFileDialog1";
            // 
            // frmConfigurarSuscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 661);
            this.Controls.Add(this.btnGuardarSuscripcion);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxImagen);
            this.Controls.Add(this.boxVolverInicio);
            this.Controls.Add(this.label3);
            this.Name = "frmConfigurarSuscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REMI";
            ((System.ComponentModel.ISupportInitialize)(this.boxVolverInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxVolverInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox boxImagen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btnGuardarSuscripcion;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtNombreApp;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtDescripcion;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMes;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtMoneda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numDia;
        private System.Windows.Forms.OpenFileDialog ofdSeleccionar;
    }
}