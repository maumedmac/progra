namespace CAPA_PRESENTACION
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btnModificarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.txtDescripcionC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnImagenM = new System.Windows.Forms.Button();
            this.pbxImagenMarca = new System.Windows.Forms.PictureBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.btnModificarM = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.txtDescripcionM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPrecioC = new System.Windows.Forms.TextBox();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImagenProducto = new System.Windows.Forms.Button();
            this.pbxImagenProducto = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnModificarP = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtClasi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvProductosXcategoria = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboMarcaP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCategoriaP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosXcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(393, 187);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowTemplate.Height = 28;
            this.dgvProducto.Size = new System.Drawing.Size(75, 39);
            this.dgvProducto.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 326);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCategoria);
            this.tabPage1.Controls.Add(this.btnModificarC);
            this.tabPage1.Controls.Add(this.btnEliminarC);
            this.tabPage1.Controls.Add(this.btnAgregarC);
            this.tabPage1.Controls.Add(this.txtDescripcionC);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtIdCategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(521, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CATEGORIA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(43, 129);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowTemplate.Height = 28;
            this.dgvCategoria.Size = new System.Drawing.Size(343, 114);
            this.dgvCategoria.TabIndex = 7;
            this.dgvCategoria.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCategoria_MouseDoubleClick);
            // 
            // btnModificarC
            // 
            this.btnModificarC.Location = new System.Drawing.Point(272, 83);
            this.btnModificarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarC.Name = "btnModificarC";
            this.btnModificarC.Size = new System.Drawing.Size(81, 34);
            this.btnModificarC.TabIndex = 6;
            this.btnModificarC.Text = "MODIFICAR";
            this.btnModificarC.UseVisualStyleBackColor = true;
            this.btnModificarC.Click += new System.EventHandler(this.btnModificarC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Location = new System.Drawing.Point(159, 83);
            this.btnEliminarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(81, 34);
            this.btnEliminarC.TabIndex = 5;
            this.btnEliminarC.Text = "ELIMINAR";
            this.btnEliminarC.UseVisualStyleBackColor = true;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Location = new System.Drawing.Point(43, 83);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(81, 34);
            this.btnAgregarC.TabIndex = 4;
            this.btnAgregarC.Text = "AGREGAR";
            this.btnAgregarC.UseVisualStyleBackColor = true;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // txtDescripcionC
            // 
            this.txtDescripcionC.Location = new System.Drawing.Point(227, 42);
            this.txtDescripcionC.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionC.Name = "txtDescripcionC";
            this.txtDescripcionC.Size = new System.Drawing.Size(133, 20);
            this.txtDescripcionC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DESCRIPCION DE CATEGORIA";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(140, 12);
            this.txtIdCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(133, 20);
            this.txtIdCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID CATEGORIA";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnImagenM);
            this.tabPage2.Controls.Add(this.pbxImagenMarca);
            this.tabPage2.Controls.Add(this.dgvMarca);
            this.tabPage2.Controls.Add(this.btnModificarM);
            this.tabPage2.Controls.Add(this.btnEliminarM);
            this.tabPage2.Controls.Add(this.btnAgregarM);
            this.tabPage2.Controls.Add(this.txtDescripcionM);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtIdMarca);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(521, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MARCA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnImagenM
            // 
            this.btnImagenM.Location = new System.Drawing.Point(370, 105);
            this.btnImagenM.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagenM.Name = "btnImagenM";
            this.btnImagenM.Size = new System.Drawing.Size(139, 23);
            this.btnImagenM.TabIndex = 27;
            this.btnImagenM.Text = "IMAGEN DE MARCA";
            this.btnImagenM.UseVisualStyleBackColor = true;
            this.btnImagenM.Click += new System.EventHandler(this.btnImagenM_Click);
            // 
            // pbxImagenMarca
            // 
            this.pbxImagenMarca.Location = new System.Drawing.Point(370, 2);
            this.pbxImagenMarca.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImagenMarca.Name = "pbxImagenMarca";
            this.pbxImagenMarca.Size = new System.Drawing.Size(139, 99);
            this.pbxImagenMarca.TabIndex = 26;
            this.pbxImagenMarca.TabStop = false;
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(27, 127);
            this.dgvMarca.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.RowTemplate.Height = 28;
            this.dgvMarca.Size = new System.Drawing.Size(343, 114);
            this.dgvMarca.TabIndex = 15;
            this.dgvMarca.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMarca_MouseDoubleClick);
            // 
            // btnModificarM
            // 
            this.btnModificarM.Location = new System.Drawing.Point(255, 81);
            this.btnModificarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarM.Name = "btnModificarM";
            this.btnModificarM.Size = new System.Drawing.Size(81, 34);
            this.btnModificarM.TabIndex = 14;
            this.btnModificarM.Text = "MODIFICAR";
            this.btnModificarM.UseVisualStyleBackColor = true;
            this.btnModificarM.Click += new System.EventHandler(this.btnModificarM_Click);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Location = new System.Drawing.Point(143, 81);
            this.btnEliminarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(81, 34);
            this.btnEliminarM.TabIndex = 13;
            this.btnEliminarM.Text = "ELIMINAR";
            this.btnEliminarM.UseVisualStyleBackColor = true;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(27, 81);
            this.btnAgregarM.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(81, 34);
            this.btnAgregarM.TabIndex = 12;
            this.btnAgregarM.Text = "AGREGAR";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // txtDescripcionM
            // 
            this.txtDescripcionM.Location = new System.Drawing.Point(167, 40);
            this.txtDescripcionM.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionM.Name = "txtDescripcionM";
            this.txtDescripcionM.Size = new System.Drawing.Size(133, 20);
            this.txtDescripcionM.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DESCRIPCION DE MARCA";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(123, 10);
            this.txtIdMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(133, 20);
            this.txtIdMarca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID DE MARCA";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPrecioC);
            this.tabPage3.Controls.Add(this.txtPrecioV);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btnImagenProducto);
            this.tabPage3.Controls.Add(this.pbxImagenProducto);
            this.tabPage3.Controls.Add(this.dgvProductos);
            this.tabPage3.Controls.Add(this.btnModificarP);
            this.tabPage3.Controls.Add(this.btnEliminarP);
            this.tabPage3.Controls.Add(this.btnAgregarP);
            this.tabPage3.Controls.Add(this.txtNombreP);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtIdProducto);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(521, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PRODUCTO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.Location = new System.Drawing.Point(187, 61);
            this.txtPrecioC.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.Size = new System.Drawing.Size(133, 20);
            this.txtPrecioC.TabIndex = 30;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Location = new System.Drawing.Point(187, 90);
            this.txtPrecioV.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(133, 20);
            this.txtPrecioV.TabIndex = 29;
            this.txtPrecioV.TextChanged += new System.EventHandler(this.txtPrecioV_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "PRECIO VENTA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 68);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "PRECIO COMPRA";
            // 
            // btnImagenProducto
            // 
            this.btnImagenProducto.Location = new System.Drawing.Point(381, 105);
            this.btnImagenProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagenProducto.Name = "btnImagenProducto";
            this.btnImagenProducto.Size = new System.Drawing.Size(139, 23);
            this.btnImagenProducto.TabIndex = 25;
            this.btnImagenProducto.Text = "IMAGEN DE PRODUCTO";
            this.btnImagenProducto.UseVisualStyleBackColor = true;
            this.btnImagenProducto.Click += new System.EventHandler(this.btnImagenProducto_Click);
            // 
            // pbxImagenProducto
            // 
            this.pbxImagenProducto.Location = new System.Drawing.Point(381, 2);
            this.pbxImagenProducto.Margin = new System.Windows.Forms.Padding(2);
            this.pbxImagenProducto.Name = "pbxImagenProducto";
            this.pbxImagenProducto.Size = new System.Drawing.Size(139, 99);
            this.pbxImagenProducto.TabIndex = 24;
            this.pbxImagenProducto.TabStop = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(24, 155);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(343, 114);
            this.dgvProductos.TabIndex = 23;
            this.dgvProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductos_MouseDoubleClick);
            // 
            // btnModificarP
            // 
            this.btnModificarP.Location = new System.Drawing.Point(264, 117);
            this.btnModificarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarP.Name = "btnModificarP";
            this.btnModificarP.Size = new System.Drawing.Size(81, 34);
            this.btnModificarP.TabIndex = 22;
            this.btnModificarP.Text = "MODIFICAR";
            this.btnModificarP.UseVisualStyleBackColor = true;
            this.btnModificarP.Click += new System.EventHandler(this.txtModificarP_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(151, 117);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(81, 34);
            this.btnEliminarP.TabIndex = 21;
            this.btnEliminarP.Text = "ELIMINAR";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.txtEliminarP_Click);
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(35, 117);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(81, 34);
            this.btnAgregarP.TabIndex = 20;
            this.btnAgregarP.Text = "AGREGAR";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(187, 40);
            this.txtNombreP.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(133, 20);
            this.txtNombreP.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "NOMBRE DE PRODUCTO";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(143, 10);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(133, 20);
            this.txtIdProducto.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID DE PRODUCTO";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtClasi);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.dgvProductosXcategoria);
            this.tabPage4.Controls.Add(this.btnModificar);
            this.tabPage4.Controls.Add(this.btnEliminar);
            this.tabPage4.Controls.Add(this.btnAgregar);
            this.tabPage4.Controls.Add(this.cboMarcaP);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.cboProducto);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.cboCategoriaP);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(521, 300);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CRUD-PRODUCTO";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtClasi
            // 
            this.txtClasi.Location = new System.Drawing.Point(197, 14);
            this.txtClasi.Margin = new System.Windows.Forms.Padding(2);
            this.txtClasi.Name = "txtClasi";
            this.txtClasi.Size = new System.Drawing.Size(68, 20);
            this.txtClasi.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "id Clasificador";
            // 
            // dgvProductosXcategoria
            // 
            this.dgvProductosXcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosXcategoria.Location = new System.Drawing.Point(23, 185);
            this.dgvProductosXcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductosXcategoria.Name = "dgvProductosXcategoria";
            this.dgvProductosXcategoria.RowTemplate.Height = 28;
            this.dgvProductosXcategoria.Size = new System.Drawing.Size(442, 118);
            this.dgvProductosXcategoria.TabIndex = 26;
            this.dgvProductosXcategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosXcategoria_CellContentClick);
            this.dgvProductosXcategoria.DoubleClick += new System.EventHandler(this.dgvProductosXcategoria_DoubleClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(281, 136);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 34);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(168, 136);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 34);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(52, 136);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 34);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboMarcaP
            // 
            this.cboMarcaP.FormattingEnabled = true;
            this.cboMarcaP.Location = new System.Drawing.Point(196, 76);
            this.cboMarcaP.Margin = new System.Windows.Forms.Padding(2);
            this.cboMarcaP.Name = "cboMarcaP";
            this.cboMarcaP.Size = new System.Drawing.Size(122, 21);
            this.cboMarcaP.TabIndex = 5;
            this.cboMarcaP.SelectedIndexChanged += new System.EventHandler(this.cboMarcaP_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "ELIJA LA MARCA";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(197, 108);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(122, 21);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ELIJA UN PRODUCTO";
            // 
            // cboCategoriaP
            // 
            this.cboCategoriaP.FormattingEnabled = true;
            this.cboCategoriaP.Location = new System.Drawing.Point(196, 44);
            this.cboCategoriaP.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoriaP.Name = "cboCategoriaP";
            this.cboCategoriaP.Size = new System.Drawing.Size(122, 21);
            this.cboCategoriaP.TabIndex = 1;
            this.cboCategoriaP.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaP_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ELIJA LA CATEGORIA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 326);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvProducto);
            this.Location = new System.Drawing.Point(300, 200);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosXcategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnModificarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.TextBox txtDescripcionC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnImagenM;
        private System.Windows.Forms.PictureBox pbxImagenMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnModificarM;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.TextBox txtDescripcionM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnImagenProducto;
        private System.Windows.Forms.PictureBox pbxImagenProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnModificarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvProductosXcategoria;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboMarcaP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCategoriaP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioC;
        private System.Windows.Forms.TextBox txtClasi;
        private System.Windows.Forms.Label label12;
    }
}

