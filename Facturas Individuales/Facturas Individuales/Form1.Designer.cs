
namespace Facturas_Individuales
{
    partial class ingresoFactura
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosFactura = new System.Windows.Forms.GroupBox();
            this.boxFactura = new System.Windows.Forms.TextBox();
            this.dateVencer = new System.Windows.Forms.DateTimePicker();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.txtVencimiento = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboProducto = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.boxCantidad = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.Label();
            this.resetFactura = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxRut = new System.Windows.Forms.TextBox();
            this.boxDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxDV = new System.Windows.Forms.TextBox();
            this.datosCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.datosFactura.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.datosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-211, -80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.tablaProductos.Location = new System.Drawing.Point(515, 41);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersVisible = false;
            this.tablaProductos.RowHeadersWidth = 51;
            this.tablaProductos.RowTemplate.Height = 29;
            this.tablaProductos.Size = new System.Drawing.Size(752, 331);
            this.tablaProductos.TabIndex = 2;
            this.tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Producto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio Producto";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IVA";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total + IVA";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // datosFactura
            // 
            this.datosFactura.Controls.Add(this.boxFactura);
            this.datosFactura.Controls.Add(this.dateVencer);
            this.datosFactura.Controls.Add(this.dateFecha);
            this.datosFactura.Controls.Add(this.txtVencimiento);
            this.datosFactura.Controls.Add(this.txtFecha);
            this.datosFactura.Controls.Add(this.txtFactura);
            this.datosFactura.Location = new System.Drawing.Point(11, 223);
            this.datosFactura.Name = "datosFactura";
            this.datosFactura.Size = new System.Drawing.Size(474, 221);
            this.datosFactura.TabIndex = 3;
            this.datosFactura.TabStop = false;
            this.datosFactura.Text = "Datos Factura";
            // 
            // boxFactura
            // 
            this.boxFactura.Location = new System.Drawing.Point(93, 35);
            this.boxFactura.Name = "boxFactura";
            this.boxFactura.Size = new System.Drawing.Size(292, 27);
            this.boxFactura.TabIndex = 5;
            // 
            // dateVencer
            // 
            this.dateVencer.Location = new System.Drawing.Point(149, 163);
            this.dateVencer.Name = "dateVencer";
            this.dateVencer.Size = new System.Drawing.Size(290, 27);
            this.dateVencer.TabIndex = 4;
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(135, 93);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(294, 27);
            this.dateFecha.TabIndex = 3;
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.AutoSize = true;
            this.txtVencimiento.Location = new System.Drawing.Point(7, 168);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(136, 20);
            this.txtVencimiento.TabIndex = 2;
            this.txtVencimiento.Text = "Fecha Vencimiento:";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Location = new System.Drawing.Point(7, 99);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(122, 20);
            this.txtFecha.TabIndex = 1;
            this.txtFecha.Text = "Fecha de Factura:";
            // 
            // txtFactura
            // 
            this.txtFactura.AutoSize = true;
            this.txtFactura.Location = new System.Drawing.Point(7, 37);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(80, 20);
            this.txtFactura.TabIndex = 0;
            this.txtFactura.Text = "Nº Factura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboProducto);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.boxCantidad);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(11, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 296);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Producto";
            // 
            // comboProducto
            // 
            this.comboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboProducto.FormattingEnabled = true;
            this.comboProducto.Items.AddRange(new object[] {
            "iPhone 12",
            "Camiseta PSG",
            "Camiseta Real Madrid",
            "Control PS4",
            "Notebook HP",
            "Máquina de Afeitar SIEGEN",
            "Parlante MASTER-G",
            "SAMGUNG GALAXY NOTE 20",
            "Gorra ADIDAS",
            "Polo NIKE",
            "Zapatillas NIKE AIR JORDAN"});
            this.comboProducto.Location = new System.Drawing.Point(87, 43);
            this.comboProducto.Name = "comboProducto";
            this.comboProducto.Size = new System.Drawing.Size(293, 28);
            this.comboProducto.TabIndex = 13;
            this.comboProducto.SelectedIndexChanged += new System.EventHandler(this.comboProducto_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(66, 175);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(15, 20);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "-";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(107, 107);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 20);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "-";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(310, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 76);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // boxCantidad
            // 
            this.boxCantidad.Location = new System.Drawing.Point(85, 241);
            this.boxCantidad.Name = "boxCantidad";
            this.boxCantidad.Size = new System.Drawing.Size(190, 27);
            this.boxCantidad.TabIndex = 7;
            this.boxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCantidad_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Location = new System.Drawing.Point(6, 241);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(7, 175);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(53, 20);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.Text = "Precio:";
            // 
            // txtProducto
            // 
            this.txtProducto.AutoSize = true;
            this.txtProducto.Location = new System.Drawing.Point(9, 45);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(72, 20);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.Text = "Producto:";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(7, 107);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(91, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID Producto:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(537, 567);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(309, 137);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar Factura";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(885, 469);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "Total Factura:";
            this.txtTotal.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.Location = new System.Drawing.Point(987, 469);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(15, 20);
            this.txtValor.TabIndex = 7;
            this.txtValor.Text = "-";
            // 
            // resetFactura
            // 
            this.resetFactura.Location = new System.Drawing.Point(920, 567);
            this.resetFactura.Name = "resetFactura";
            this.resetFactura.Size = new System.Drawing.Size(309, 137);
            this.resetFactura.TabIndex = 8;
            this.resetFactura.Text = "Limpiar Factura";
            this.resetFactura.UseVisualStyleBackColor = true;
            this.resetFactura.Click += new System.EventHandler(this.resetFactura_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(6, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre Cliente:";
            this.txtNombre.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtDirección
            // 
            this.txtDirección.AutoSize = true;
            this.txtDirección.Location = new System.Drawing.Point(6, 139);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(75, 20);
            this.txtDirección.TabIndex = 1;
            this.txtDirección.Text = "Dirección:";
            this.txtDirección.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRut
            // 
            this.txtRut.AutoSize = true;
            this.txtRut.Location = new System.Drawing.Point(11, 25);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(89, 20);
            this.txtRut.TabIndex = 2;
            this.txtRut.Text = "RUT Cliente:";
            this.txtRut.Click += new System.EventHandler(this.label4_Click);
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(135, 75);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.ReadOnly = true;
            this.boxNombre.Size = new System.Drawing.Size(332, 27);
            this.boxNombre.TabIndex = 3;
            // 
            // boxRut
            // 
            this.boxRut.Location = new System.Drawing.Point(135, 25);
            this.boxRut.MaxLength = 9;
            this.boxRut.Name = "boxRut";
            this.boxRut.Size = new System.Drawing.Size(140, 27);
            this.boxRut.TabIndex = 4;
            this.boxRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxRut_KeyPress);
            // 
            // boxDireccion
            // 
            this.boxDireccion.Location = new System.Drawing.Point(129, 139);
            this.boxDireccion.Name = "boxDireccion";
            this.boxDireccion.ReadOnly = true;
            this.boxDireccion.Size = new System.Drawing.Size(338, 27);
            this.boxDireccion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // boxDV
            // 
            this.boxDV.Location = new System.Drawing.Point(294, 27);
            this.boxDV.MaxLength = 1;
            this.boxDV.Name = "boxDV";
            this.boxDV.Size = new System.Drawing.Size(36, 27);
            this.boxDV.TabIndex = 7;
            this.boxDV.TextChanged += new System.EventHandler(this.boxDV_TextChanged);
            this.boxDV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxDV_KeyPress);
            // 
            // datosCliente
            // 
            this.datosCliente.Controls.Add(this.btnBuscarCliente);
            this.datosCliente.Controls.Add(this.boxDV);
            this.datosCliente.Controls.Add(this.label2);
            this.datosCliente.Controls.Add(this.boxDireccion);
            this.datosCliente.Controls.Add(this.boxRut);
            this.datosCliente.Controls.Add(this.boxNombre);
            this.datosCliente.Controls.Add(this.txtRut);
            this.datosCliente.Controls.Add(this.txtDirección);
            this.datosCliente.Controls.Add(this.txtNombre);
            this.datosCliente.Location = new System.Drawing.Point(11, 12);
            this.datosCliente.Name = "datosCliente";
            this.datosCliente.Size = new System.Drawing.Size(474, 187);
            this.datosCliente.TabIndex = 1;
            this.datosCliente.TabStop = false;
            this.datosCliente.Text = "Datos Cliente";
            this.datosCliente.Enter += new System.EventHandler(this.datosCliente_Enter);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(339, 24);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(128, 32);
            this.btnBuscarCliente.TabIndex = 14;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            this.btnBuscarCliente.MouseLeave += new System.EventHandler(this.btnBuscarCliente_MouseLeave);
            this.btnBuscarCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuscarCliente_MouseMove);
            // 
            // ingresoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 757);
            this.Controls.Add(this.resetFactura);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datosFactura);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.datosCliente);
            this.Controls.Add(this.label1);
            this.Name = "ingresoFactura";
            this.Text = "Amazon Retail - Ingreso Individual de Facturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.datosFactura.ResumeLayout(false);
            this.datosFactura.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.datosCliente.ResumeLayout(false);
            this.datosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.GroupBox datosFactura;
        private System.Windows.Forms.TextBox boxFactura;
        private System.Windows.Forms.DateTimePicker dateVencer;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label txtVencimiento;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label txtFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox boxCantidad;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtProducto;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtValor;
        private System.Windows.Forms.ComboBox comboProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button resetFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtDirección;
        private System.Windows.Forms.Label txtRut;
        private System.Windows.Forms.TextBox boxNombre;
        private System.Windows.Forms.TextBox boxRut;
        private System.Windows.Forms.TextBox boxDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxDV;
        private System.Windows.Forms.GroupBox datosCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}

