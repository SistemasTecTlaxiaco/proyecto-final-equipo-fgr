
namespace REMI_V2._0 {
    partial class frmInicio {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxAgregar = new System.Windows.Forms.PictureBox();
            this.boxConfiguracion = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.TabIndex = 0;
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
            this.boxAgregar.Click += new System.EventHandler(this.boxAgregar_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(123, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "¡Hola, mi nombre es Remi!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Añade una nueva suscripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "tocando el icono + en la parte superior.";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REMI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox boxAgregar;
        private System.Windows.Forms.PictureBox boxConfiguracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}