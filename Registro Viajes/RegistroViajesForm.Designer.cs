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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.GridTodosLosViajes = new System.Windows.Forms.DataGridView();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.btnEliminarAuto = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(532, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 39);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // GridTodosLosViajes
            // 
            this.GridTodosLosViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTodosLosViajes.Location = new System.Drawing.Point(34, 38);
            this.GridTodosLosViajes.Name = "GridTodosLosViajes";
            this.GridTodosLosViajes.RowTemplate.ReadOnly = true;
            this.GridTodosLosViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTodosLosViajes.Size = new System.Drawing.Size(482, 169);
            this.GridTodosLosViajes.TabIndex = 2;
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Location = new System.Drawing.Point(532, 95);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(83, 38);
            this.btnRegistrarViaje.TabIndex = 5;
            this.btnRegistrarViaje.Text = "Registrar Viaje";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // btnEliminarAuto
            // 
            this.btnEliminarAuto.Location = new System.Drawing.Point(532, 186);
            this.btnEliminarAuto.Name = "btnEliminarAuto";
            this.btnEliminarAuto.Size = new System.Drawing.Size(83, 38);
            this.btnEliminarAuto.TabIndex = 6;
            this.btnEliminarAuto.Text = "Eliminar";
            this.btnEliminarAuto.UseVisualStyleBackColor = true;
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(532, 139);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(83, 41);
            this.btnModificarAuto.TabIndex = 7;
            this.btnModificarAuto.Text = "modificarAuto";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            // 
            // RegistroViajesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 315);
            this.Controls.Add(this.btnModificarAuto);
            this.Controls.Add(this.btnEliminarAuto);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.GridTodosLosViajes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button1);
            this.Name = "RegistroViajesForm";
            this.Text = "Registrar Viaje";
            this.Load += new System.EventHandler(this.RegistroViajesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView GridTodosLosViajes;
        private System.Windows.Forms.Button btnRegistrarViaje;
        private System.Windows.Forms.Button btnEliminarAuto;
        private System.Windows.Forms.Button btnModificarAuto;
    }
}