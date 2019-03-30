namespace CapaPresentacion
{
    partial class frmTrabajador
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
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.dtFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbApellidos = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDocumento = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.chkEliminar = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnImprimir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblFecha_Nac = new MaterialSkin.Controls.MaterialLabel();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbVenta = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAlmacen = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAdministrador = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNum_Documento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtIdtrabajador = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnback = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
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
            this.dataListado.Location = new System.Drawing.Point(3, 266);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(871, 180);
            this.dataListado.TabIndex = 7;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // dtFecha_Nacimiento
            // 
            this.dtFecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Nacimiento.Location = new System.Drawing.Point(618, 98);
            this.dtFecha_Nacimiento.Name = "dtFecha_Nacimiento";
            this.dtFecha_Nacimiento.Size = new System.Drawing.Size(219, 25);
            this.dtFecha_Nacimiento.TabIndex = 4;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
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
            this.tabControl1.Size = new System.Drawing.Size(885, 480);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.txtBuscar);
            this.tabPage3.Controls.Add(this.rbApellidos);
            this.tabPage3.Controls.Add(this.rbDocumento);
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.chkEliminar);
            this.tabPage3.Controls.Add(this.btnImprimir);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.dataListado);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(877, 449);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Nómina";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(176, 45);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(506, 28);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.Text = "Operador a Buscar";
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Depth = 0;
            this.rbApellidos.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbApellidos.Location = new System.Drawing.Point(346, 85);
            this.rbApellidos.Margin = new System.Windows.Forms.Padding(0);
            this.rbApellidos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Ripple = true;
            this.rbApellidos.Size = new System.Drawing.Size(133, 30);
            this.rbApellidos.TabIndex = 14;
            this.rbApellidos.TabStop = true;
            this.rbApellidos.Text = "Por Apellidos";
            this.rbApellidos.UseVisualStyleBackColor = true;
            // 
            // rbDocumento
            // 
            this.rbDocumento.AutoSize = true;
            this.rbDocumento.Depth = 0;
            this.rbDocumento.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDocumento.Location = new System.Drawing.Point(176, 85);
            this.rbDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.rbDocumento.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDocumento.Name = "rbDocumento";
            this.rbDocumento.Ripple = true;
            this.rbDocumento.Size = new System.Drawing.Size(150, 30);
            this.rbDocumento.TabIndex = 13;
            this.rbDocumento.TabStop = true;
            this.rbDocumento.Text = "Por Documento";
            this.rbDocumento.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(515, 88);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(167, 24);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "lblTotal Refgistros";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Depth = 0;
            this.chkEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkEliminar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEliminar.Location = new System.Drawing.Point(3, 236);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Ripple = true;
            this.chkEliminar.Size = new System.Drawing.Size(871, 30);
            this.chkEliminar.TabIndex = 11;
            this.chkEliminar.Text = "Eliminar Operador?";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(532, 152);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = true;
            this.btnImprimir.Size = new System.Drawing.Size(150, 30);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(354, 152);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(150, 30);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(176, 152);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(150, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.lblFecha_Nac);
            this.tabPage4.Controls.Add(this.gbLogin);
            this.tabPage4.Controls.Add(this.txtDireccion);
            this.tabPage4.Controls.Add(this.txtEmail);
            this.tabPage4.Controls.Add(this.txtTelefono);
            this.tabPage4.Controls.Add(this.txtNum_Documento);
            this.tabPage4.Controls.Add(this.txtApellidos);
            this.tabPage4.Controls.Add(this.txtNombre);
            this.tabPage4.Controls.Add(this.gbGenero);
            this.tabPage4.Controls.Add(this.txtIdtrabajador);
            this.tabPage4.Controls.Add(this.btnback);
            this.tabPage4.Controls.Add(this.btnCancelar);
            this.tabPage4.Controls.Add(this.btnEditar);
            this.tabPage4.Controls.Add(this.btnGuardar);
            this.tabPage4.Controls.Add(this.btnNuevo);
            this.tabPage4.Controls.Add(this.dtFecha_Nacimiento);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(877, 449);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mantenimiento";
            // 
            // lblFecha_Nac
            // 
            this.lblFecha_Nac.AutoSize = true;
            this.lblFecha_Nac.Depth = 0;
            this.lblFecha_Nac.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFecha_Nac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFecha_Nac.Location = new System.Drawing.Point(438, 98);
            this.lblFecha_Nac.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFecha_Nac.Name = "lblFecha_Nac";
            this.lblFecha_Nac.Size = new System.Drawing.Size(174, 24);
            this.lblFecha_Nac.TabIndex = 59;
            this.lblFecha_Nac.Text = "Fecha Nacimiento :";
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.materialSingleLineTextField1);
            this.gbLogin.Controls.Add(this.rbVenta);
            this.gbLogin.Controls.Add(this.rbAlmacen);
            this.gbLogin.Controls.Add(this.rbAdministrador);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.txtPassword);
            this.gbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbLogin.Location = new System.Drawing.Point(33, 226);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(399, 202);
            this.gbLogin.TabIndex = 58;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "LOGIN";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(65, 154);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(261, 28);
            this.materialSingleLineTextField1.TabIndex = 61;
            this.materialSingleLineTextField1.Text = "Password";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // rbVenta
            // 
            this.rbVenta.AutoSize = true;
            this.rbVenta.Depth = 0;
            this.rbVenta.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbVenta.Location = new System.Drawing.Point(291, 34);
            this.rbVenta.Margin = new System.Windows.Forms.Padding(0);
            this.rbVenta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbVenta.Name = "rbVenta";
            this.rbVenta.Ripple = true;
            this.rbVenta.Size = new System.Drawing.Size(84, 30);
            this.rbVenta.TabIndex = 60;
            this.rbVenta.TabStop = true;
            this.rbVenta.Text = "Ventas";
            this.rbVenta.UseVisualStyleBackColor = true;
            this.rbVenta.CheckedChanged += new System.EventHandler(this.rbVenta_CheckedChanged);
            // 
            // rbAlmacen
            // 
            this.rbAlmacen.AutoSize = true;
            this.rbAlmacen.Depth = 0;
            this.rbAlmacen.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbAlmacen.Location = new System.Drawing.Point(171, 34);
            this.rbAlmacen.Margin = new System.Windows.Forms.Padding(0);
            this.rbAlmacen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAlmacen.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAlmacen.Name = "rbAlmacen";
            this.rbAlmacen.Ripple = true;
            this.rbAlmacen.Size = new System.Drawing.Size(98, 30);
            this.rbAlmacen.TabIndex = 59;
            this.rbAlmacen.TabStop = true;
            this.rbAlmacen.Text = "Almacen";
            this.rbAlmacen.UseVisualStyleBackColor = true;
            this.rbAlmacen.CheckedChanged += new System.EventHandler(this.rbAlmacen_CheckedChanged);
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Depth = 0;
            this.rbAdministrador.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbAdministrador.Location = new System.Drawing.Point(7, 34);
            this.rbAdministrador.Margin = new System.Windows.Forms.Padding(0);
            this.rbAdministrador.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAdministrador.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Ripple = true;
            this.rbAdministrador.Size = new System.Drawing.Size(140, 30);
            this.rbAdministrador.TabIndex = 58;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            this.rbAdministrador.CheckedChanged += new System.EventHandler(this.rbAdministrador_CheckedChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(65, 78);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(261, 28);
            this.txtUsuario.TabIndex = 56;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(65, 116);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(261, 28);
            this.txtPassword.TabIndex = 57;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(33, 154);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(399, 28);
            this.txtDireccion.TabIndex = 55;
            this.txtDireccion.Text = "Dirección";
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(442, 192);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(395, 28);
            this.txtEmail.TabIndex = 54;
            this.txtEmail.Text = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(33, 192);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(399, 28);
            this.txtTelefono.TabIndex = 53;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtNum_Documento
            // 
            this.txtNum_Documento.Depth = 0;
            this.txtNum_Documento.Hint = "";
            this.txtNum_Documento.Location = new System.Drawing.Point(442, 154);
            this.txtNum_Documento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNum_Documento.Name = "txtNum_Documento";
            this.txtNum_Documento.PasswordChar = '\0';
            this.txtNum_Documento.SelectedText = "";
            this.txtNum_Documento.SelectionLength = 0;
            this.txtNum_Documento.SelectionStart = 0;
            this.txtNum_Documento.Size = new System.Drawing.Size(395, 28);
            this.txtNum_Documento.TabIndex = 52;
            this.txtNum_Documento.Text = "Número Documento";
            this.txtNum_Documento.UseSystemPasswordChar = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Hint = "";
            this.txtApellidos.Location = new System.Drawing.Point(438, 36);
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Size = new System.Drawing.Size(399, 28);
            this.txtApellidos.TabIndex = 51;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(33, 36);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(399, 28);
            this.txtNombre.TabIndex = 50;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbGenero.Location = new System.Drawing.Point(33, 76);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(399, 67);
            this.gbGenero.TabIndex = 49;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Depth = 0;
            this.rbMasculino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbMasculino.Location = new System.Drawing.Point(232, 22);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Ripple = true;
            this.rbMasculino.Size = new System.Drawing.Size(110, 30);
            this.rbMasculino.TabIndex = 48;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Depth = 0;
            this.rbFemenino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFemenino.Location = new System.Drawing.Point(72, 22);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Ripple = true;
            this.rbFemenino.Size = new System.Drawing.Size(106, 30);
            this.rbFemenino.TabIndex = 47;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // txtIdtrabajador
            // 
            this.txtIdtrabajador.Depth = 0;
            this.txtIdtrabajador.Hint = "";
            this.txtIdtrabajador.Location = new System.Drawing.Point(24, 6);
            this.txtIdtrabajador.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdtrabajador.Name = "txtIdtrabajador";
            this.txtIdtrabajador.PasswordChar = '\0';
            this.txtIdtrabajador.SelectedText = "";
            this.txtIdtrabajador.SelectionLength = 0;
            this.txtIdtrabajador.SelectionStart = 0;
            this.txtIdtrabajador.Size = new System.Drawing.Size(68, 28);
            this.txtIdtrabajador.TabIndex = 46;
            this.txtIdtrabajador.Text = "ID";
            this.txtIdtrabajador.UseSystemPasswordChar = false;
            // 
            // btnback
            // 
            this.btnback.Depth = 0;
            this.btnback.Location = new System.Drawing.Point(442, 398);
            this.btnback.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnback.Name = "btnback";
            this.btnback.Primary = true;
            this.btnback.Size = new System.Drawing.Size(400, 30);
            this.btnback.TabIndex = 45;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(646, 326);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(196, 30);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(442, 362);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(196, 30);
            this.btnEditar.TabIndex = 43;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(646, 362);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(196, 30);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(442, 326);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(196, 30);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(885, 50);
            this.materialTabSelector1.TabIndex = 9;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // frmTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(885, 594);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmTrabajador";
            this.Text = "OPERADORES";
            this.Load += new System.EventHandler(this.FrmTrabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DateTimePicker dtFecha_Nacimiento;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRadioButton rbApellidos;
        private MaterialSkin.Controls.MaterialRadioButton rbDocumento;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialCheckBox chkEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnImprimir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialLabel lblFecha_Nac;
        private System.Windows.Forms.GroupBox gbLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRadioButton rbVenta;
        private MaterialSkin.Controls.MaterialRadioButton rbAlmacen;
        private MaterialSkin.Controls.MaterialRadioButton rbAdministrador;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNum_Documento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private System.Windows.Forms.GroupBox gbGenero;
        private MaterialSkin.Controls.MaterialRadioButton rbMasculino;
        private MaterialSkin.Controls.MaterialRadioButton rbFemenino;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdtrabajador;
        private MaterialSkin.Controls.MaterialRaisedButton btnback;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
    }
}