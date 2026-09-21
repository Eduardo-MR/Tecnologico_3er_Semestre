namespace ComercializadoraDeportiva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMayorista = new System.Windows.Forms.CheckBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.picLogotipo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGrande = new System.Windows.Forms.RadioButton();
            this.radMediana = new System.Windows.Forms.RadioButton();
            this.radPequena = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFundacion = new System.Windows.Forms.DateTimePicker();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.txtNumSucursales = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblFechaFundacion = new System.Windows.Forms.Label();
            this.lblVentasAnuales = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGenerarAleatorios = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMayorista);
            this.groupBox1.Controls.Add(this.btnCargarFoto);
            this.groupBox1.Controls.Add(this.picLogotipo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaFundacion);
            this.groupBox1.Controls.Add(this.txtVentas);
            this.groupBox1.Controls.Add(this.txtNumSucursales);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblFechaFundacion);
            this.groupBox1.Controls.Add(this.lblVentasAnuales);
            this.groupBox1.Controls.Add(this.lblSucursal);
            this.groupBox1.Controls.Add(this.lblRazonSocial);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de comercializadora";
            // 
            // chkMayorista
            // 
            this.chkMayorista.AutoSize = true;
            this.chkMayorista.Location = new System.Drawing.Point(453, 35);
            this.chkMayorista.Name = "chkMayorista";
            this.chkMayorista.Size = new System.Drawing.Size(35, 17);
            this.chkMayorista.TabIndex = 14;
            this.chkMayorista.Text = "Si";
            this.chkMayorista.UseVisualStyleBackColor = true;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(579, 179);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(77, 34);
            this.btnCargarFoto.TabIndex = 13;
            this.btnCargarFoto.Text = "Cargar foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // picLogotipo
            // 
            this.picLogotipo.Location = new System.Drawing.Point(528, 33);
            this.picLogotipo.Name = "picLogotipo";
            this.picLogotipo.Size = new System.Drawing.Size(182, 127);
            this.picLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogotipo.TabIndex = 12;
            this.picLogotipo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radGrande);
            this.groupBox2.Controls.Add(this.radMediana);
            this.groupBox2.Controls.Add(this.radPequena);
            this.groupBox2.Location = new System.Drawing.Point(371, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria Tamaño";
            // 
            // radGrande
            // 
            this.radGrande.AutoSize = true;
            this.radGrande.Location = new System.Drawing.Point(6, 70);
            this.radGrande.Name = "radGrande";
            this.radGrande.Size = new System.Drawing.Size(33, 17);
            this.radGrande.TabIndex = 2;
            this.radGrande.TabStop = true;
            this.radGrande.Text = "G";
            this.radGrande.UseVisualStyleBackColor = true;
            // 
            // radMediana
            // 
            this.radMediana.AutoSize = true;
            this.radMediana.Location = new System.Drawing.Point(6, 47);
            this.radMediana.Name = "radMediana";
            this.radMediana.Size = new System.Drawing.Size(34, 17);
            this.radMediana.TabIndex = 1;
            this.radMediana.TabStop = true;
            this.radMediana.Text = "M";
            this.radMediana.UseVisualStyleBackColor = true;
            // 
            // radPequena
            // 
            this.radPequena.AutoSize = true;
            this.radPequena.Location = new System.Drawing.Point(6, 24);
            this.radPequena.Name = "radPequena";
            this.radPequena.Size = new System.Drawing.Size(32, 17);
            this.radPequena.TabIndex = 0;
            this.radPequena.TabStop = true;
            this.radPequena.Text = "P";
            this.radPequena.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "¿Es Mayorista?";
            // 
            // dtpFechaFundacion
            // 
            this.dtpFechaFundacion.Location = new System.Drawing.Point(131, 194);
            this.dtpFechaFundacion.Name = "dtpFechaFundacion";
            this.dtpFechaFundacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFundacion.TabIndex = 9;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(107, 154);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(126, 20);
            this.txtVentas.TabIndex = 8;
            // 
            // txtNumSucursales
            // 
            this.txtNumSucursales.Location = new System.Drawing.Point(129, 111);
            this.txtNumSucursales.Name = "txtNumSucursales";
            this.txtNumSucursales.Size = new System.Drawing.Size(104, 20);
            this.txtNumSucursales.TabIndex = 7;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(105, 70);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(128, 20);
            this.txtRazonSocial.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(70, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // lblFechaFundacion
            // 
            this.lblFechaFundacion.AutoSize = true;
            this.lblFechaFundacion.Location = new System.Drawing.Point(20, 200);
            this.lblFechaFundacion.Name = "lblFechaFundacion";
            this.lblFechaFundacion.Size = new System.Drawing.Size(105, 13);
            this.lblFechaFundacion.TabIndex = 4;
            this.lblFechaFundacion.Text = "Fecha de Fundación";
            // 
            // lblVentasAnuales
            // 
            this.lblVentasAnuales.AutoSize = true;
            this.lblVentasAnuales.Location = new System.Drawing.Point(20, 157);
            this.lblVentasAnuales.Name = "lblVentasAnuales";
            this.lblVentasAnuales.Size = new System.Drawing.Size(81, 13);
            this.lblVentasAnuales.TabIndex = 3;
            this.lblVentasAnuales.Text = "Ventas Anuales";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(20, 114);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(103, 13);
            this.lblSucursal.TabIndex = 2;
            this.lblSucursal.Text = "Numero de Sucursal";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(20, 73);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(20, 36);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(797, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGenerarAleatorios
            // 
            this.btnGenerarAleatorios.Location = new System.Drawing.Point(797, 61);
            this.btnGenerarAleatorios.Name = "btnGenerarAleatorios";
            this.btnGenerarAleatorios.Size = new System.Drawing.Size(109, 51);
            this.btnGenerarAleatorios.TabIndex = 2;
            this.btnGenerarAleatorios.Text = "Generar Aleatorios";
            this.btnGenerarAleatorios.UseVisualStyleBackColor = true;
            this.btnGenerarAleatorios.Click += new System.EventHandler(this.btnGenerarAleatorios_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(797, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(797, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(797, 207);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(109, 23);
            this.btnVaciar.TabIndex = 5;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(797, 250);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(109, 23);
            this.btnLimpiarDatos.TabIndex = 6;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 279);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(894, 220);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 525);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerarAleatorios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFechaFundacion;
        private System.Windows.Forms.Label lblVentasAnuales;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.PictureBox picLogotipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radGrande;
        private System.Windows.Forms.RadioButton radMediana;
        private System.Windows.Forms.RadioButton radPequena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFundacion;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.TextBox txtNumSucursales;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGenerarAleatorios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.CheckBox chkMayorista;
    }
}

