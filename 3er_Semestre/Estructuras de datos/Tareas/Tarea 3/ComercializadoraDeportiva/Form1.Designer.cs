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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.radHaciaAtras = new System.Windows.Forms.RadioButton();
            this.radHaciaAdelante = new System.Windows.Forms.RadioButton();
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
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerarAleatorios = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
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
            this.groupBox1.Location = new System.Drawing.Point(34, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1558, 483);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de comercializadora";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRecorrer);
            this.groupBox3.Controls.Add(this.radHaciaAtras);
            this.groupBox3.Controls.Add(this.radHaciaAdelante);
            this.groupBox3.Location = new System.Drawing.Point(741, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 186);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recorrido";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(58, 122);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(6);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(154, 43);
            this.btnRecorrer.TabIndex = 16;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // radHaciaAtras
            // 
            this.radHaciaAtras.AutoSize = true;
            this.radHaciaAtras.Location = new System.Drawing.Point(12, 81);
            this.radHaciaAtras.Margin = new System.Windows.Forms.Padding(6);
            this.radHaciaAtras.Name = "radHaciaAtras";
            this.radHaciaAtras.Size = new System.Drawing.Size(154, 29);
            this.radHaciaAtras.TabIndex = 2;
            this.radHaciaAtras.Text = "Hacia Atras";
            this.radHaciaAtras.UseVisualStyleBackColor = true;
            // 
            // radHaciaAdelante
            // 
            this.radHaciaAdelante.AutoSize = true;
            this.radHaciaAdelante.Checked = true;
            this.radHaciaAdelante.Location = new System.Drawing.Point(12, 40);
            this.radHaciaAdelante.Margin = new System.Windows.Forms.Padding(6);
            this.radHaciaAdelante.Name = "radHaciaAdelante";
            this.radHaciaAdelante.Size = new System.Drawing.Size(189, 29);
            this.radHaciaAdelante.TabIndex = 1;
            this.radHaciaAdelante.TabStop = true;
            this.radHaciaAdelante.Text = "Hacia Adelante";
            this.radHaciaAdelante.UseVisualStyleBackColor = true;
            // 
            // chkMayorista
            // 
            this.chkMayorista.AutoSize = true;
            this.chkMayorista.Location = new System.Drawing.Point(906, 37);
            this.chkMayorista.Margin = new System.Windows.Forms.Padding(6);
            this.chkMayorista.Name = "chkMayorista";
            this.chkMayorista.Size = new System.Drawing.Size(63, 29);
            this.chkMayorista.TabIndex = 14;
            this.chkMayorista.Text = "Si";
            this.chkMayorista.UseVisualStyleBackColor = true;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(1255, 317);
            this.btnCargarFoto.Margin = new System.Windows.Forms.Padding(6);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(154, 65);
            this.btnCargarFoto.TabIndex = 13;
            this.btnCargarFoto.Text = "Cargar foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // picLogotipo
            // 
            this.picLogotipo.Location = new System.Drawing.Point(1153, 40);
            this.picLogotipo.Margin = new System.Windows.Forms.Padding(6);
            this.picLogotipo.Name = "picLogotipo";
            this.picLogotipo.Size = new System.Drawing.Size(364, 244);
            this.picLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogotipo.TabIndex = 12;
            this.picLogotipo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radGrande);
            this.groupBox2.Controls.Add(this.radMediana);
            this.groupBox2.Controls.Add(this.radPequena);
            this.groupBox2.Location = new System.Drawing.Point(742, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(264, 192);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria Tamaño";
            // 
            // radGrande
            // 
            this.radGrande.AutoSize = true;
            this.radGrande.Location = new System.Drawing.Point(12, 135);
            this.radGrande.Margin = new System.Windows.Forms.Padding(6);
            this.radGrande.Name = "radGrande";
            this.radGrande.Size = new System.Drawing.Size(59, 29);
            this.radGrande.TabIndex = 2;
            this.radGrande.Text = "G";
            this.radGrande.UseVisualStyleBackColor = true;
            // 
            // radMediana
            // 
            this.radMediana.AutoSize = true;
            this.radMediana.Location = new System.Drawing.Point(12, 90);
            this.radMediana.Margin = new System.Windows.Forms.Padding(6);
            this.radMediana.Name = "radMediana";
            this.radMediana.Size = new System.Drawing.Size(61, 29);
            this.radMediana.TabIndex = 1;
            this.radMediana.Text = "M";
            this.radMediana.UseVisualStyleBackColor = true;
            // 
            // radPequena
            // 
            this.radPequena.AutoSize = true;
            this.radPequena.Checked = true;
            this.radPequena.Location = new System.Drawing.Point(12, 46);
            this.radPequena.Margin = new System.Windows.Forms.Padding(6);
            this.radPequena.Name = "radPequena";
            this.radPequena.Size = new System.Drawing.Size(57, 29);
            this.radPequena.TabIndex = 0;
            this.radPequena.TabStop = true;
            this.radPequena.Text = "P";
            this.radPequena.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "¿Es Mayorista?";
            // 
            // dtpFechaFundacion
            // 
            this.dtpFechaFundacion.Location = new System.Drawing.Point(262, 373);
            this.dtpFechaFundacion.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFechaFundacion.Name = "dtpFechaFundacion";
            this.dtpFechaFundacion.Size = new System.Drawing.Size(396, 31);
            this.dtpFechaFundacion.TabIndex = 9;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(214, 296);
            this.txtVentas.Margin = new System.Windows.Forms.Padding(6);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(248, 31);
            this.txtVentas.TabIndex = 8;
            // 
            // txtNumSucursales
            // 
            this.txtNumSucursales.Location = new System.Drawing.Point(258, 213);
            this.txtNumSucursales.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumSucursales.Name = "txtNumSucursales";
            this.txtNumSucursales.Size = new System.Drawing.Size(204, 31);
            this.txtNumSucursales.TabIndex = 7;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(210, 135);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(6);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(252, 31);
            this.txtRazonSocial.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(140, 63);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(138, 31);
            this.txtNumero.TabIndex = 5;
            // 
            // lblFechaFundacion
            // 
            this.lblFechaFundacion.AutoSize = true;
            this.lblFechaFundacion.Location = new System.Drawing.Point(40, 385);
            this.lblFechaFundacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaFundacion.Name = "lblFechaFundacion";
            this.lblFechaFundacion.Size = new System.Drawing.Size(209, 25);
            this.lblFechaFundacion.TabIndex = 4;
            this.lblFechaFundacion.Text = "Fecha de Fundación";
            // 
            // lblVentasAnuales
            // 
            this.lblVentasAnuales.AutoSize = true;
            this.lblVentasAnuales.Location = new System.Drawing.Point(40, 302);
            this.lblVentasAnuales.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVentasAnuales.Name = "lblVentasAnuales";
            this.lblVentasAnuales.Size = new System.Drawing.Size(163, 25);
            this.lblVentasAnuales.TabIndex = 3;
            this.lblVentasAnuales.Text = "Ventas Anuales";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(40, 219);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(207, 25);
            this.lblSucursal.TabIndex = 2;
            this.lblSucursal.Text = "Numero de Sucursal";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(40, 140);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(139, 25);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(40, 69);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(87, 25);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número";
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(1639, 472);
            this.btnLimpiarDatos.Margin = new System.Windows.Forms.Padding(6);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(218, 44);
            this.btnLimpiarDatos.TabIndex = 12;
            this.btnLimpiarDatos.Text = "Limpiar Datos";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(1639, 389);
            this.btnVaciar.Margin = new System.Windows.Forms.Padding(6);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(218, 44);
            this.btnVaciar.TabIndex = 11;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1639, 316);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(218, 44);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1639, 233);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(218, 44);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerarAleatorios
            // 
            this.btnGenerarAleatorios.Location = new System.Drawing.Point(1639, 108);
            this.btnGenerarAleatorios.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerarAleatorios.Name = "btnGenerarAleatorios";
            this.btnGenerarAleatorios.Size = new System.Drawing.Size(218, 98);
            this.btnGenerarAleatorios.TabIndex = 8;
            this.btnGenerarAleatorios.Text = "Generar Aleatorios";
            this.btnGenerarAleatorios.UseVisualStyleBackColor = true;
            this.btnGenerarAleatorios.Click += new System.EventHandler(this.btnGenerarAleatorios_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1639, 33);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(218, 44);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(25, 537);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 82;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1823, 423);
            this.dgvDatos.TabIndex = 13;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1872, 983);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerarAleatorios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Comercializadoras Deportivas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMayorista;
        private System.Windows.Forms.Button btnCargarFoto;
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
        private System.Windows.Forms.Label lblFechaFundacion;
        private System.Windows.Forms.Label lblVentasAnuales;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGenerarAleatorios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radHaciaAtras;
        private System.Windows.Forms.RadioButton radHaciaAdelante;
        private System.Windows.Forms.Button btnRecorrer;
    }
}

