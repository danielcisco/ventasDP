namespace CapaPresentacion
{
    partial class frmProveedor
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnImprimir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.chkEliminar = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbDocumento = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbRazonSocial = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rbNit = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPasaporte = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCi = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtIdproveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNum_Documento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRazon_Social = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbSector_Comercial = new System.Windows.Forms.ComboBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.rbOtro = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 67;
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
            this.dataListado.Location = new System.Drawing.Point(3, 333);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(670, 219);
            this.dataListado.TabIndex = 7;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // cbBuscar
            // 
            this.cbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Documento",
            "Razon Social"});
            this.cbBuscar.Location = new System.Drawing.Point(68, 33);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(216, 26);
            this.cbBuscar.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Depth = 0;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 114);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 586);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnImprimir);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.chkEliminar);
            this.tabPage3.Controls.Add(this.txtBuscar);
            this.tabPage3.Controls.Add(this.rbDocumento);
            this.tabPage3.Controls.Add(this.rbRazonSocial);
            this.tabPage3.Controls.Add(this.dataListado);
            this.tabPage3.Controls.Add(this.cbBuscar);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(676, 555);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Listado";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(68, 216);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = true;
            this.btnImprimir.Size = new System.Drawing.Size(540, 35);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(68, 170);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(540, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(68, 124);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(540, 35);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(301, 285);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 24);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "lblTotal";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Depth = 0;
            this.chkEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkEliminar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEliminar.Location = new System.Drawing.Point(3, 303);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Ripple = true;
            this.chkEliminar.Size = new System.Drawing.Size(670, 30);
            this.chkEliminar.TabIndex = 11;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(305, 32);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(303, 28);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.Text = "Proveedor a Buscar";
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // rbDocumento
            // 
            this.rbDocumento.AutoSize = true;
            this.rbDocumento.Depth = 0;
            this.rbDocumento.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDocumento.Location = new System.Drawing.Point(215, 70);
            this.rbDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.rbDocumento.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDocumento.Name = "rbDocumento";
            this.rbDocumento.Ripple = true;
            this.rbDocumento.Size = new System.Drawing.Size(119, 30);
            this.rbDocumento.TabIndex = 9;
            this.rbDocumento.TabStop = true;
            this.rbDocumento.Text = "Documento";
            this.rbDocumento.UseVisualStyleBackColor = true;
            // 
            // rbRazonSocial
            // 
            this.rbRazonSocial.AutoSize = true;
            this.rbRazonSocial.Depth = 0;
            this.rbRazonSocial.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbRazonSocial.Location = new System.Drawing.Point(68, 70);
            this.rbRazonSocial.Margin = new System.Windows.Forms.Padding(0);
            this.rbRazonSocial.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRazonSocial.Name = "rbRazonSocial";
            this.rbRazonSocial.Ripple = true;
            this.rbRazonSocial.Size = new System.Drawing.Size(129, 30);
            this.rbRazonSocial.TabIndex = 8;
            this.rbRazonSocial.TabStop = true;
            this.rbRazonSocial.Text = "Razon Social";
            this.rbRazonSocial.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.rbOtro);
            this.tabPage4.Controls.Add(this.materialRaisedButton1);
            this.tabPage4.Controls.Add(this.rbNit);
            this.tabPage4.Controls.Add(this.rbPasaporte);
            this.tabPage4.Controls.Add(this.rbCi);
            this.tabPage4.Controls.Add(this.txtIdproveedor);
            this.tabPage4.Controls.Add(this.txtUrl);
            this.tabPage4.Controls.Add(this.txtEmail);
            this.tabPage4.Controls.Add(this.txtTelefono);
            this.tabPage4.Controls.Add(this.txtDireccion);
            this.tabPage4.Controls.Add(this.txtNum_Documento);
            this.tabPage4.Controls.Add(this.txtRazon_Social);
            this.tabPage4.Controls.Add(this.btnCancelar);
            this.tabPage4.Controls.Add(this.btnEditar);
            this.tabPage4.Controls.Add(this.btnGuardar);
            this.tabPage4.Controls.Add(this.btnNuevo);
            this.tabPage4.Controls.Add(this.cbSector_Comercial);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(676, 555);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mantenimiento";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(52, 497);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(574, 39);
            this.materialRaisedButton1.TabIndex = 55;
            this.materialRaisedButton1.Text = "back";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // rbNit
            // 
            this.rbNit.AutoSize = true;
            this.rbNit.Depth = 0;
            this.rbNit.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbNit.Location = new System.Drawing.Point(393, 76);
            this.rbNit.Margin = new System.Windows.Forms.Padding(0);
            this.rbNit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbNit.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbNit.Name = "rbNit";
            this.rbNit.Ripple = true;
            this.rbNit.Size = new System.Drawing.Size(58, 30);
            this.rbNit.TabIndex = 54;
            this.rbNit.TabStop = true;
            this.rbNit.Text = "NIT";
            this.rbNit.UseVisualStyleBackColor = true;
            this.rbNit.CheckedChanged += new System.EventHandler(this.rbNit_CheckedChanged);
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Depth = 0;
            this.rbPasaporte.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbPasaporte.Location = new System.Drawing.Point(210, 76);
            this.rbPasaporte.Margin = new System.Windows.Forms.Padding(0);
            this.rbPasaporte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPasaporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Ripple = true;
            this.rbPasaporte.Size = new System.Drawing.Size(109, 30);
            this.rbPasaporte.TabIndex = 53;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            this.rbPasaporte.CheckedChanged += new System.EventHandler(this.rbPasaporte_CheckedChanged);
            // 
            // rbCi
            // 
            this.rbCi.AutoSize = true;
            this.rbCi.Depth = 0;
            this.rbCi.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCi.Location = new System.Drawing.Point(80, 76);
            this.rbCi.Margin = new System.Windows.Forms.Padding(0);
            this.rbCi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCi.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCi.Name = "rbCi";
            this.rbCi.Ripple = true;
            this.rbCi.Size = new System.Drawing.Size(56, 30);
            this.rbCi.TabIndex = 52;
            this.rbCi.TabStop = true;
            this.rbCi.Text = "C.I.";
            this.rbCi.UseVisualStyleBackColor = true;
            this.rbCi.CheckedChanged += new System.EventHandler(this.rbCi_CheckedChanged);
            // 
            // txtIdproveedor
            // 
            this.txtIdproveedor.Depth = 0;
            this.txtIdproveedor.Hint = "";
            this.txtIdproveedor.Location = new System.Drawing.Point(427, 15);
            this.txtIdproveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdproveedor.Name = "txtIdproveedor";
            this.txtIdproveedor.PasswordChar = '\0';
            this.txtIdproveedor.SelectedText = "";
            this.txtIdproveedor.SelectionLength = 0;
            this.txtIdproveedor.SelectionStart = 0;
            this.txtIdproveedor.Size = new System.Drawing.Size(161, 28);
            this.txtIdproveedor.TabIndex = 51;
            this.txtIdproveedor.Text = "txtIdproveedor";
            this.txtIdproveedor.UseSystemPasswordChar = false;
            this.txtIdproveedor.Visible = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Depth = 0;
            this.txtUrl.Hint = "";
            this.txtUrl.Location = new System.Drawing.Point(80, 357);
            this.txtUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.Size = new System.Drawing.Size(508, 28);
            this.txtUrl.TabIndex = 50;
            this.txtUrl.Text = "txtUrl";
            this.txtUrl.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(80, 310);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(508, 28);
            this.txtEmail.TabIndex = 49;
            this.txtEmail.Text = "txtEmail";
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(80, 263);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(508, 28);
            this.txtTelefono.TabIndex = 48;
            this.txtTelefono.Text = "txtTelefono";
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(80, 216);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(508, 28);
            this.txtDireccion.TabIndex = 47;
            this.txtDireccion.Text = "txtDireccion";
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtNum_Documento
            // 
            this.txtNum_Documento.Depth = 0;
            this.txtNum_Documento.Hint = "";
            this.txtNum_Documento.Location = new System.Drawing.Point(80, 124);
            this.txtNum_Documento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNum_Documento.Name = "txtNum_Documento";
            this.txtNum_Documento.PasswordChar = '\0';
            this.txtNum_Documento.SelectedText = "";
            this.txtNum_Documento.SelectionLength = 0;
            this.txtNum_Documento.SelectionStart = 0;
            this.txtNum_Documento.Size = new System.Drawing.Size(508, 28);
            this.txtNum_Documento.TabIndex = 46;
            this.txtNum_Documento.Text = "txtNum_Documento";
            this.txtNum_Documento.UseSystemPasswordChar = false;
            // 
            // txtRazon_Social
            // 
            this.txtRazon_Social.Depth = 0;
            this.txtRazon_Social.Hint = "";
            this.txtRazon_Social.Location = new System.Drawing.Point(80, 29);
            this.txtRazon_Social.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRazon_Social.Name = "txtRazon_Social";
            this.txtRazon_Social.PasswordChar = '\0';
            this.txtRazon_Social.SelectedText = "";
            this.txtRazon_Social.SelectionLength = 0;
            this.txtRazon_Social.SelectionStart = 0;
            this.txtRazon_Social.Size = new System.Drawing.Size(508, 28);
            this.txtRazon_Social.TabIndex = 45;
            this.txtRazon_Social.Text = "txtRazon_Social";
            this.txtRazon_Social.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(347, 452);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(279, 39);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(347, 407);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(279, 39);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(52, 452);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(279, 39);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(52, 407);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(279, 39);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // cbSector_Comercial
            // 
            this.cbSector_Comercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.cbSector_Comercial.FormattingEnabled = true;
            this.cbSector_Comercial.Items.AddRange(new object[] {
            "Lbel",
            "Cy-Zone",
            "Esika",
            "Avon",
            "L\'Oreal",
            "VICTORIA’S SECRET",
            "Loreal",
            "Otro"});
            this.cbSector_Comercial.Location = new System.Drawing.Point(80, 171);
            this.cbSector_Comercial.Name = "cbSector_Comercial";
            this.cbSector_Comercial.Size = new System.Drawing.Size(508, 26);
            this.cbSector_Comercial.TabIndex = 24;
            this.cbSector_Comercial.Text = "Sector";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(684, 50);
            this.materialTabSelector1.TabIndex = 6;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Depth = 0;
            this.rbOtro.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbOtro.Location = new System.Drawing.Point(525, 76);
            this.rbOtro.Margin = new System.Windows.Forms.Padding(0);
            this.rbOtro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbOtro.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Ripple = true;
            this.rbOtro.Size = new System.Drawing.Size(63, 30);
            this.rbOtro.TabIndex = 56;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 700);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProveedor";
            this.Text = "Proveedores";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ComboBox cbBuscar;
        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cbSector_Comercial;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton btnImprimir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialCheckBox chkEliminar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRadioButton rbDocumento;
        private MaterialSkin.Controls.MaterialRadioButton rbRazonSocial;
        private MaterialSkin.Controls.MaterialRadioButton rbNit;
        private MaterialSkin.Controls.MaterialRadioButton rbPasaporte;
        private MaterialSkin.Controls.MaterialRadioButton rbCi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdproveedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUrl;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNum_Documento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRazon_Social;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRadioButton rbOtro;
    }
}