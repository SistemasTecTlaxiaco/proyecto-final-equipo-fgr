
namespace REMI_V2._0 {
    partial class frmNuevoUsuario {
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
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPalabraR = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmailR = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPasswordCR = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPasswordR = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtUsuarioR = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNombreR = new TextoBoxAutoExplicativo.txtAutoExplicativo();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(161)))), ((int)(((byte)(203)))));
            this.btnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("SF Pro Text", 12F);
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Location = new System.Drawing.Point(13, 550);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(350, 50);
            this.btnCrearCuenta.TabIndex = 8;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPalabraR);
            this.groupBox2.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Palabra de Seguridad";
            // 
            // txtPalabraR
            // 
            this.txtPalabraR.BackColor = System.Drawing.Color.White;
            this.txtPalabraR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPalabraR.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPalabraR.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabraR.Location = new System.Drawing.Point(6, 21);
            this.txtPalabraR.Name = "txtPalabraR";
            this.txtPalabraR.Size = new System.Drawing.Size(338, 27);
            this.txtPalabraR.TabIndex = 1;
            this.txtPalabraR.TextoVacio = "Palabra en caso de que olvide su contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmailR);
            this.groupBox1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email";
            // 
            // txtEmailR
            // 
            this.txtEmailR.BackColor = System.Drawing.Color.White;
            this.txtEmailR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailR.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtEmailR.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailR.Location = new System.Drawing.Point(6, 21);
            this.txtEmailR.Multiline = true;
            this.txtEmailR.Name = "txtEmailR";
            this.txtEmailR.Size = new System.Drawing.Size(338, 27);
            this.txtEmailR.TabIndex = 0;
            this.txtEmailR.TextoVacio = "Ingrese su email";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPasswordCR);
            this.groupBox3.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 55);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirme su contraseña";
            // 
            // txtPasswordCR
            // 
            this.txtPasswordCR.BackColor = System.Drawing.Color.White;
            this.txtPasswordCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordCR.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPasswordCR.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordCR.Location = new System.Drawing.Point(6, 21);
            this.txtPasswordCR.Name = "txtPasswordCR";
            this.txtPasswordCR.PasswordChar = '*';
            this.txtPasswordCR.Size = new System.Drawing.Size(338, 27);
            this.txtPasswordCR.TabIndex = 1;
            this.txtPasswordCR.TextoVacio = "Escriba de nuevo su contraseña";
            this.txtPasswordCR.UseSystemPasswordChar = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPasswordR);
            this.groupBox4.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 55);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contraseña";
            // 
            // txtPasswordR
            // 
            this.txtPasswordR.BackColor = System.Drawing.Color.White;
            this.txtPasswordR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordR.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtPasswordR.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordR.Location = new System.Drawing.Point(6, 22);
            this.txtPasswordR.Name = "txtPasswordR";
            this.txtPasswordR.PasswordChar = '*';
            this.txtPasswordR.Size = new System.Drawing.Size(338, 27);
            this.txtPasswordR.TabIndex = 2;
            this.txtPasswordR.TextoVacio = "Escriba una contraseña";
            this.txtPasswordR.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "REMI";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtUsuarioR);
            this.groupBox5.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(350, 55);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Usuario";
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.BackColor = System.Drawing.Color.White;
            this.txtUsuarioR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioR.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtUsuarioR.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioR.Location = new System.Drawing.Point(6, 21);
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.Size = new System.Drawing.Size(338, 27);
            this.txtUsuarioR.TabIndex = 1;
            this.txtUsuarioR.TextoVacio = "Escriba un Usuario";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNombreR);
            this.groupBox6.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 110);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 55);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nombre";
            // 
            // txtNombreR
            // 
            this.txtNombreR.BackColor = System.Drawing.Color.White;
            this.txtNombreR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreR.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtNombreR.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreR.Location = new System.Drawing.Point(6, 21);
            this.txtNombreR.Multiline = true;
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(338, 27);
            this.txtNombreR.TabIndex = 0;
            this.txtNombreR.TextoVacio = "Ingrese su nombre";
            // 
            // frmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 661);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REMI";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtPalabraR;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtEmailR;
        private System.Windows.Forms.GroupBox groupBox3;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtPasswordCR;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtUsuarioR;
        private System.Windows.Forms.GroupBox groupBox6;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtNombreR;
        private TextoBoxAutoExplicativo.txtAutoExplicativo txtPasswordR;
    }
}