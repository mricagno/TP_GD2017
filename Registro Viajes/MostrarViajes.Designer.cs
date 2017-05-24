namespace UberFrba.Registro_Viajes
{
    partial class MostrarViajes
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
            this.GridTodosLosViajes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;

            // 
            // MostrarViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GridTodosLosViajes);
            this.Controls.Add(this.button1);
            this.Name = "MostrarViajes";
            this.Text = "Registrar Viaje";
            this.Load += new System.EventHandler(this.RegistroViajesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTodosLosViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridTodosLosViajes;
        private System.Windows.Forms.Button button2;
    }
}