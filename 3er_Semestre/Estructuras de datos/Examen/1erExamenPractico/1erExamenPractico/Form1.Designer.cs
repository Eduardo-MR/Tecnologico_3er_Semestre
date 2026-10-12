namespace _1erExamenPractico
{
    partial class Form1
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
            this.btnGenerarAleatorios = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtCantidadDeAleatorios = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCantidadNodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarAleatorios
            // 
            this.btnGenerarAleatorios.Location = new System.Drawing.Point(1402, 61);
            this.btnGenerarAleatorios.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerarAleatorios.Name = "btnGenerarAleatorios";
            this.btnGenerarAleatorios.Size = new System.Drawing.Size(218, 98);
            this.btnGenerarAleatorios.TabIndex = 9;
            this.btnGenerarAleatorios.Text = "Generar Aleatorios";
            this.btnGenerarAleatorios.UseVisualStyleBackColor = true;
            this.btnGenerarAleatorios.Click += new System.EventHandler(this.btnGenerarAleatorios_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(40, 212);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 82;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1608, 423);
            this.dgvDatos.TabIndex = 14;
            // 
            // txtCantidadDeAleatorios
            // 
            this.txtCantidadDeAleatorios.Location = new System.Drawing.Point(1016, 98);
            this.txtCantidadDeAleatorios.Margin = new System.Windows.Forms.Padding(6);
            this.txtCantidadDeAleatorios.Name = "txtCantidadDeAleatorios";
            this.txtCantidadDeAleatorios.Size = new System.Drawing.Size(138, 31);
            this.txtCantidadDeAleatorios.TabIndex = 16;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(774, 101);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(230, 25);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Cantidad de Aleatorios";
            // 
            // btnCantidadNodos
            // 
            this.btnCantidadNodos.Location = new System.Drawing.Point(1174, 60);
            this.btnCantidadNodos.Name = "btnCantidadNodos";
            this.btnCantidadNodos.Size = new System.Drawing.Size(207, 99);
            this.btnCantidadNodos.TabIndex = 17;
            this.btnCantidadNodos.Text = "Cantidad de nodos";
            this.btnCantidadNodos.UseVisualStyleBackColor = true;
            this.btnCantidadNodos.Click += new System.EventHandler(this.btnCantidadNodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1685, 679);
            this.Controls.Add(this.btnCantidadNodos);
            this.Controls.Add(this.txtCantidadDeAleatorios);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnGenerarAleatorios);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarAleatorios;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtCantidadDeAleatorios;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCantidadNodos;
    }
}

