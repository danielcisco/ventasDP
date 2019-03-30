namespace CapaPresentacion
{
    partial class frmArticulo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.cbIdpresentacion = new System.Windows.Forms.ComboBox();
            this.txtIdcategoria = new System.Windows.Forms.TextBox();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.chkEliminar = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnImprimir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAtras = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBuscarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCargar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdarticulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIdpresentacion
            // 
            this.cbIdpresentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.cbIdpresentacion.FormattingEnabled = true;
            this.cbIdpresentacion.Location = new System.Drawing.Point(257, 377);
            this.cbIdpresentacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIdpresentacion.Name = "cbIdpresentacion";
            this.cbIdpresentacion.Size = new System.Drawing.Size(453, 26);
            this.cbIdpresentacion.TabIndex = 7;
            this.cbIdpresentacion.Text = "Presentacion";
            // 
            // txtIdcategoria
            // 
            this.txtIdcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtIdcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdcategoria.Location = new System.Drawing.Point(104, 251);
            this.txtIdcategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdcategoria.Name = "txtIdcategoria";
            this.txtIdcategoria.Size = new System.Drawing.Size(61, 25);
            this.txtIdcategoria.TabIndex = 17;
            this.txtIdcategoria.Text = "Idarticulo";
            // 
            // pxImagen
            // 
            this.pxImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxImagen.Location = new System.Drawing.Point(257, 418);
            this.pxImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(156, 132);
            this.pxImagen.TabIndex = 12;
            this.pxImagen.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(257, 144);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(453, 132);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Text = "Descripcion";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataListado.Location = new System.Drawing.Point(3, 214);
            this.dataListado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(764, 348);
            this.dataListado.TabIndex = 7;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 67;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = this.tabControl1;
            this.tabSelector.Depth = 0;
            this.errorIcono.SetIconAlignment(this.tabSelector, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tabSelector.Location = new System.Drawing.Point(0, 64);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(778, 50);
            this.tabSelector.TabIndex = 8;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Depth = 0;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 107);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 596);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.chkEliminar);
            this.tabPage3.Controls.Add(this.btnImprimir);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.txtBuscar);
            this.tabPage3.Controls.Add(this.dataListado);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(770, 565);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Listado";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(454, 23);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(136, 24);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "materialLabel1";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Depth = 0;
            this.chkEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkEliminar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEliminar.Location = new System.Drawing.Point(3, 184);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Ripple = true;
            this.chkEliminar.Size = new System.Drawing.Size(764, 30);
            this.chkEliminar.TabIndex = 12;
            this.chkEliminar.Text = "materialCheckBox1";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(435, 96);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = false;
            this.btnImprimir.Size = new System.Drawing.Size(90, 36);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(300, 96);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(91, 36);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(177, 96);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = false;
            this.btnBuscar.Size = new System.Drawing.Size(79, 36);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(168, 21);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(251, 28);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.Text = "Articulo a Buscar";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.btnAtras);
            this.tabPage4.Controls.Add(this.btnBuscarCategoria);
            this.tabPage4.Controls.Add(this.btnLimpiar);
            this.tabPage4.Controls.Add(this.btnCargar);
            this.tabPage4.Controls.Add(this.txtCategoria);
            this.tabPage4.Controls.Add(this.txtNombre);
            this.tabPage4.Controls.Add(this.txtCodigo);
            this.tabPage4.Controls.Add(this.txtIdarticulo);
            this.tabPage4.Controls.Add(this.btnCancelar);
            this.tabPage4.Controls.Add(this.btnEditar);
            this.tabPage4.Controls.Add(this.btnGuardar);
            this.tabPage4.Controls.Add(this.btnNuevo);
            this.tabPage4.Controls.Add(this.cbIdpresentacion);
            this.tabPage4.Controls.Add(this.txtIdcategoria);
            this.tabPage4.Controls.Add(this.txtDescripcion);
            this.tabPage4.Controls.Add(this.pxImagen);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(770, 565);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mantenimiento";
            // 
            // btnAtras
            // 
            this.btnAtras.AutoSize = true;
            this.btnAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtras.Depth = 0;
            this.btnAtras.Location = new System.Drawing.Point(34, 497);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Primary = false;
            this.btnAtras.Size = new System.Drawing.Size(57, 36);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "back";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCategoria.Depth = 0;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(257, 334);
            this.btnBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Primary = true;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(453, 36);
            this.btnBuscarCategoria.TabIndex = 31;
            this.btnBuscarCategoria.Text = "buscar Categoria";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(420, 514);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(290, 36);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "[  quitar imagen  ]                ";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargar.Depth = 0;
            this.btnCargar.Location = new System.Drawing.Point(420, 459);
            this.btnCargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Primary = true;
            this.btnCargar.Size = new System.Drawing.Size(288, 36);
            this.btnCargar.TabIndex = 29;
            this.btnCargar.Text = "[ Cargar Imagen ]";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Hint = "";
            this.txtCategoria.Location = new System.Drawing.Point(257, 291);
            this.txtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.Size = new System.Drawing.Size(453, 28);
            this.txtCategoria.TabIndex = 28;
            this.txtCategoria.TabStop = false;
            this.txtCategoria.Text = "Categoria de Producto";
            this.txtCategoria.UseSystemPasswordChar = false;
            this.txtCategoria.Enter += new System.EventHandler(this.txtCategoria_Enter);
            this.txtCategoria.Leave += new System.EventHandler(this.txtCategoria_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(257, 101);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(453, 28);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.TabStop = false;
            this.txtNombre.Text = "Nombre Producto";
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(257, 58);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(453, 28);
            this.txtCodigo.TabIndex = 25;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Text = "Codigo de Barras";
            this.txtCodigo.UseSystemPasswordChar = false;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtIdarticulo
            // 
            this.txtIdarticulo.Depth = 0;
            this.txtIdarticulo.Hint = "";
            this.txtIdarticulo.Location = new System.Drawing.Point(257, 15);
            this.txtIdarticulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdarticulo.Name = "txtIdarticulo";
            this.txtIdarticulo.PasswordChar = '\0';
            this.txtIdarticulo.SelectedText = "";
            this.txtIdarticulo.SelectionLength = 0;
            this.txtIdarticulo.SelectionStart = 0;
            this.txtIdarticulo.Size = new System.Drawing.Size(453, 28);
            this.txtIdarticulo.TabIndex = 24;
            this.txtIdarticulo.TabStop = false;
            this.txtIdarticulo.Text = "Codigo Producto";
            this.txtIdarticulo.UseSystemPasswordChar = false;
            this.txtIdarticulo.Enter += new System.EventHandler(this.txtIdarticulo_Enter);
            this.txtIdarticulo.Leave += new System.EventHandler(this.txtIdarticulo_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(66, 181);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(81, 130);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = false;
            this.btnEditar.Size = new System.Drawing.Size(71, 36);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(71, 79);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(91, 36);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(82, 28);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = false;
            this.btnNuevo.Size = new System.Drawing.Size(69, 36);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(778, 703);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabSelector);
            this.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmArticulo";
            this.Text = "PRODUCTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArticulo_FormClosing);
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.ComboBox cbIdpresentacion;
        private System.Windows.Forms.TextBox txtIdcategoria;
        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnEditar;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdarticulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCargar;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialCheckBox chkEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnImprimir;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialFlatButton btnAtras;
    }
}