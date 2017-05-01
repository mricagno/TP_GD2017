namespace UberFrba.Registro_Viajes
{
    partial class RegistroViajesForm
    {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GridTodosLosViajes = new System.Windows.Forms.DataGridView();
            this.txtAutomovil = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.Automovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GridTodosLosViajes
            // 
            this.GridTodosLosViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTodosLosViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Automovil,
            this.Chofer});
            this.GridTodosLosViajes.Location = new System.Drawing.Point(54, 16);
            this.GridTodosLosViajes.Name = "GridTodosLosViajes";
            this.GridTodosLosViajes.Size = new System.Drawing.Size(370, 169);
            this.GridTodosLosViajes.TabIndex = 2;
            // 
            // txtAutomovil
            // 
            this.txtAutomovil.Location = new System.Drawing.Point(66, 202);
            this.txtAutomovil.Name = "txtAutomovil";
            this.txtAutomovil.Size = new System.Drawing.Size(201, 20);
            this.txtAutomovil.TabIndex = 3;
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(66, 240);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(196, 20);
            this.txtChofer.TabIndex = 4;
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Location = new System.Drawing.Point(66, 277);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(79, 38);
            this.btnRegistrarViaje.TabIndex = 5;
            this.btnRegistrarViaje.Text = "Registrar Viaje";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // Automovil
            // 
            this.Automovil.DataPropertyName = "automovil";
            this.Automovil.HeaderText = "Automovil";
            this.Automovil.Name = "Automovil";
            // 
            // Chofer
            // 
            this.Chofer.DataPropertyName = "chofer";
            this.Chofer.HeaderText = "Chofer";
            this.Chofer.Name = "Chofer";
            // 
            // RegistroViajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 358);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.txtChofer);
            this.Controls.Add(this.txtAutomovil);
            this.Controls.Add(this.GridTodosLosViajes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RegistroViajesForm";
            this.Text = "Registrar Viaje";
            this.Load += new System.EventHandler(this.RegistroViajesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView GridTodosLosViajes;
        private System.Windows.Forms.TextBox txtAutomovil;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Button btnRegistrarViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Automovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chofer;
    }
}