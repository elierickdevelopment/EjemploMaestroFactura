namespace EjemploMaestroFactura
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
            this.components = new System.ComponentModel.Container();
            this.textBox_NoFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bD_PruebaDataSet = new EjemploMaestroFactura.BD_PruebaDataSet();
            this.bDPruebaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_PruebaDataSet1 = new EjemploMaestroFactura.BD_PruebaDataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new EjemploMaestroFactura.BD_PruebaDataSet1TableAdapters.ClientesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_PRODUCTO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CANTIDAD = new System.Windows.Forms.TextBox();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.bD_PruebaDataSet2 = new EjemploMaestroFactura.BD_PruebaDataSet2();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new EjemploMaestroFactura.BD_PruebaDataSet2TableAdapters.ProductoTableAdapter();
            this.bD_PruebaDataSet4 = new EjemploMaestroFactura.BD_PruebaDataSet4();
            this.viewdetallefacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_detalle_facturaTableAdapter = new EjemploMaestroFactura.BD_PruebaDataSet4TableAdapters.View_detalle_facturaTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.bD_PruebaDataSet5 = new EjemploMaestroFactura.BD_PruebaDataSet5();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new EjemploMaestroFactura.BD_PruebaDataSet5TableAdapters.ClientesTableAdapter();
            this.bD_PruebaDataSet6 = new EjemploMaestroFactura.BD_PruebaDataSet6();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter1 = new EjemploMaestroFactura.BD_PruebaDataSet6TableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdetallefacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_NoFactura
            // 
            this.textBox_NoFactura.Location = new System.Drawing.Point(90, 48);
            this.textBox_NoFactura.Name = "textBox_NoFactura";
            this.textBox_NoFactura.Size = new System.Drawing.Size(163, 20);
            this.textBox_NoFactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No factura";
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.DataSource = this.clientesBindingSource1;
            this.comboBox_cliente.DisplayMember = "Nombre";
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(326, 48);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(163, 21);
            this.comboBox_cliente.TabIndex = 2;
            this.comboBox_cliente.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // bD_PruebaDataSet
            // 
            this.bD_PruebaDataSet.DataSetName = "BD_PruebaDataSet";
            this.bD_PruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDPruebaDataSetBindingSource
            // 
            this.bDPruebaDataSetBindingSource.DataSource = this.bD_PruebaDataSet;
            this.bDPruebaDataSetBindingSource.Position = 0;
            // 
            // bD_PruebaDataSet1
            // 
            this.bD_PruebaDataSet1.DataSetName = "BD_PruebaDataSet1";
            this.bD_PruebaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bD_PruebaDataSet1;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_PRODUCTO
            // 
            this.comboBox_PRODUCTO.DataSource = this.productoBindingSource1;
            this.comboBox_PRODUCTO.DisplayMember = "Nombre";
            this.comboBox_PRODUCTO.FormattingEnabled = true;
            this.comboBox_PRODUCTO.Location = new System.Drawing.Point(90, 113);
            this.comboBox_PRODUCTO.Name = "comboBox_PRODUCTO";
            this.comboBox_PRODUCTO.Size = new System.Drawing.Size(265, 21);
            this.comboBox_PRODUCTO.TabIndex = 7;
            this.comboBox_PRODUCTO.ValueMember = "Id";
            this.comboBox_PRODUCTO.SelectedIndexChanged += new System.EventHandler(this.comboBox_PRODUCTO_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // textBox_CANTIDAD
            // 
            this.textBox_CANTIDAD.Location = new System.Drawing.Point(444, 114);
            this.textBox_CANTIDAD.Name = "textBox_CANTIDAD";
            this.textBox_CANTIDAD.Size = new System.Drawing.Size(77, 20);
            this.textBox_CANTIDAD.TabIndex = 5;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(539, 114);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 9;
            this.button_agregar.Text = "AGREGAR";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(519, 46);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 10;
            this.button_guardar.Text = "GUARDAR";
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // bD_PruebaDataSet2
            // 
            this.bD_PruebaDataSet2.DataSetName = "BD_PruebaDataSet2";
            this.bD_PruebaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.bD_PruebaDataSet2;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // bD_PruebaDataSet4
            // 
            this.bD_PruebaDataSet4.DataSetName = "BD_PruebaDataSet4";
            this.bD_PruebaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewdetallefacturaBindingSource
            // 
            this.viewdetallefacturaBindingSource.DataMember = "View_detalle_factura";
            this.viewdetallefacturaBindingSource.DataSource = this.bD_PruebaDataSet4;
            // 
            // view_detalle_facturaTableAdapter
            // 
            this.view_detalle_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // bD_PruebaDataSet5
            // 
            this.bD_PruebaDataSet5.DataSetName = "BD_PruebaDataSet5";
            this.bD_PruebaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.bD_PruebaDataSet5;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // bD_PruebaDataSet6
            // 
            this.bD_PruebaDataSet6.DataSetName = "BD_PruebaDataSet6";
            this.bD_PruebaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.bD_PruebaDataSet6;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 327);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_PRODUCTO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_CANTIDAD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NoFactura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdetallefacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_PruebaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bDPruebaDataSetBindingSource;
        private BD_PruebaDataSet bD_PruebaDataSet;
        private BD_PruebaDataSet1 bD_PruebaDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BD_PruebaDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_PRODUCTO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CANTIDAD;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_guardar;
        private BD_PruebaDataSet2 bD_PruebaDataSet2;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private BD_PruebaDataSet2TableAdapters.ProductoTableAdapter productoTableAdapter;
        private BD_PruebaDataSet4 bD_PruebaDataSet4;
        private System.Windows.Forms.BindingSource viewdetallefacturaBindingSource;
        private BD_PruebaDataSet4TableAdapters.View_detalle_facturaTableAdapter view_detalle_facturaTableAdapter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private BD_PruebaDataSet5 bD_PruebaDataSet5;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private BD_PruebaDataSet5TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private BD_PruebaDataSet6 bD_PruebaDataSet6;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private BD_PruebaDataSet6TableAdapters.ProductoTableAdapter productoTableAdapter1;
    }
}

