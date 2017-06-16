namespace UberFrba
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboPerfiles = new System.Windows.Forms.ComboBox();
            this.lbliniciarComo = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(46, 26);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 13);
            this.lblBienvenida.TabIndex = 0;
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.Location = new System.Drawing.Point(94, 212);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(96, 28);
            this.botonIniciarSesion.TabIndex = 2;
            this.botonIniciarSesion.Text = "Login";
            this.botonIniciarSesion.UseVisualStyleBackColor = true;
            this.botonIniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(94, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(128, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // comboPerfiles
            // 
            this.comboPerfiles.FormattingEnabled = true;
            this.comboPerfiles.Location = new System.Drawing.Point(94, 101);
            this.comboPerfiles.Name = "comboPerfiles";
            this.comboPerfiles.Size = new System.Drawing.Size(127, 21);
            this.comboPerfiles.TabIndex = 7;
            this.comboPerfiles.Visible = false;
            // 
            // lbliniciarComo
            // 
            this.lbliniciarComo.AutoSize = true;
            this.lbliniciarComo.Location = new System.Drawing.Point(24, 109);
            this.lbliniciarComo.Name = "lbliniciarComo";
            this.lbliniciarComo.Size = new System.Drawing.Size(65, 13);
            this.lbliniciarComo.TabIndex = 8;
            this.lbliniciarComo.Text = "Iniciar Como";
            this.lbliniciarComo.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(94, 178);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(96, 28);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Iniciar Sesion";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbliniciarComo);
            this.Controls.Add(this.comboPerfiles);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Main";
            this.Text = "Bienvenidos a Uber";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboPerfiles;
        private System.Windows.Forms.Label lbliniciarComo;
        private System.Windows.Forms.Button btnIngresar;
    }
}

