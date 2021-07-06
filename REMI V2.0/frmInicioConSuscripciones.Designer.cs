
namespace REMI_V2._0 {
    partial class frmInicioConSuscripciones {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioConSuscripciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxAgregar = new System.Windows.Forms.PictureBox();
            this.boxConfiguracion = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.boxSus = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(161)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.boxAgregar);
            this.panel1.Controls.Add(this.boxConfiguracion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 75);
            this.panel1.TabIndex = 10;
            // 
            // boxAgregar
            // 
            this.boxAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxAgregar.Image = ((System.Drawing.Image)(resources.GetObject("boxAgregar.Image")));
            this.boxAgregar.Location = new System.Drawing.Point(318, 22);
            this.boxAgregar.Name = "boxAgregar";
            this.boxAgregar.Size = new System.Drawing.Size(30, 30);
            this.boxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boxAgregar.TabIndex = 7;
            this.boxAgregar.TabStop = false;
            // 
            // boxConfiguracion
            // 
            this.boxConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("boxConfiguracion.Image")));
            this.boxConfiguracion.Location = new System.Drawing.Point(27, 22);
            this.boxConfiguracion.Name = "boxConfiguracion";
            this.boxConfiguracion.Size = new System.Drawing.Size(30, 30);
            this.boxConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boxConfiguracion.TabIndex = 6;
            this.boxConfiguracion.TabStop = false;
            this.boxConfiguracion.Click += new System.EventHandler(this.boxConfiguracion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mis Suscripciones";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 55);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(82, 122);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 19);
            this.lblNombre.TabIndex = 12;
            // 
            // boxSus
            // 
            this.boxSus.Location = new System.Drawing.Point(45, 122);
            this.boxSus.Name = "boxSus";
            this.boxSus.Size = new System.Drawing.Size(17, 17);
            this.boxSus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxSus.TabIndex = 13;
            this.boxSus.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(295, 122);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 19);
            this.lblPrecio.TabIndex = 14;
            // 
            // frmInicioConSuscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 661);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.boxSus);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmInicioConSuscripciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicioConSuscripciones";
            this.Load += new System.EventHandler(this.frmInicioConSuscripciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox boxAgregar;
        private System.Windows.Forms.PictureBox boxConfiguracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox boxSus;
        private System.Windows.Forms.Label lblPrecio;
    }
}