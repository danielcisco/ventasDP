namespace CapaPresentacion
{
    partial class frmCliente
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
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkEliminar = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.rbApellidos = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDocumento = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnImprimir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbTipo_Documento = new System.Windows.Forms.GroupBox();
            this.rbOtro = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCi = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDni = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPasaporte = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbldtfecha_nac = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNum_Documento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdcliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBack = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.gbGenero.SuspendLayout();
            this.gbTipo_Documento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataListado.Location = new System.Drawing.Point(3, 264);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(944, 224);
            this.dataListado.TabIndex = 3;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNac.Location = new System.Drawing.Point(205, 100);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(269, 25);
            this.dtFechaNac.TabIndex = 5;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Depth = 0;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 113);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 522);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.chkEliminar);
            this.tabPage3.Controls.Add(this.lblTotal);
            this.tabPage3.Controls.Add(this.rbApellidos);
            this.tabPage3.Controls.Add(this.rbDocumento);
            this.tabPage3.Controls.Add(this.txtBuscar);
            this.tabPage3.Controls.Add(this.btnImprimir);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnBuscar);
            this.tabPage3.Controls.Add(this.dataListado);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 491);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Lista";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Depth = 0;
            this.chkEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkEliminar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEliminar.Location = new System.Drawing.Point(3, 234);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEliminar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Ripple = true;
            this.chkEliminar.Size = new System.Drawing.Size(944, 30);
            this.chkEliminar.TabIndex = 15;
            this.chkEliminar.Text = "Eliminar Clientes?";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(393, 61);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 24);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "lblTotal";
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Depth = 0;
            this.rbApellidos.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbApellidos.Location = new System.Drawing.Point(202, 59);
            this.rbApellidos.Margin = new System.Windows.Forms.Padding(0);
            this.rbApellidos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Ripple = true;
            this.rbApellidos.Size = new System.Drawing.Size(133, 30);
            this.rbApellidos.TabIndex = 13;
            this.rbApellidos.TabStop = true;
            this.rbApellidos.Text = "Por Apellidos";
            this.rbApellidos.UseVisualStyleBackColor = true;
            // 
            // rbDocumento
            // 
            this.rbDocumento.AutoSize = true;
            this.rbDocumento.Depth = 0;
            this.rbDocumento.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDocumento.Location = new System.Drawing.Point(202, 18);
            this.rbDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.rbDocumento.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDocumento.Name = "rbDocumento";
            this.rbDocumento.Ripple = true;
            this.rbDocumento.Size = new System.Drawing.Size(150, 30);
            this.rbDocumento.TabIndex = 12;
            this.rbDocumento.TabStop = true;
            this.rbDocumento.Text = "Por Documento";
            this.rbDocumento.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(397, 20);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(303, 28);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.Text = "Cliente a Buscar";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Depth = 0;
            this.btnImprimir.Location = new System.Drawing.Point(202, 182);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Primary = true;
            this.btnImprimir.Size = new System.Drawing.Size(498, 30);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(202, 141);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(498, 30);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(202, 100);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(498, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.gbGenero);
            this.tabPage4.Controls.Add(this.gbTipo_Documento);
            this.tabPage4.Controls.Add(this.lbldtfecha_nac);
            this.tabPage4.Controls.Add(this.txtEmail);
            this.tabPage4.Controls.Add(this.txtTelefono);
            this.tabPage4.Controls.Add(this.txtApellidos);
            this.tabPage4.Controls.Add(this.txtDireccion);
            this.tabPage4.Controls.Add(this.txtNum_Documento);
            this.tabPage4.Controls.Add(this.txtNombre);
            this.tabPage4.Controls.Add(this.txtIdcliente);
            this.tabPage4.Controls.Add(this.btnBack);
            this.tabPage4.Controls.Add(this.btnCancelar);
            this.tabPage4.Controls.Add(this.btnEditar);
            this.tabPage4.Controls.Add(this.btnGuardar);
            this.tabPage4.Controls.Add(this.btnNuevo);
            this.tabPage4.Controls.Add(this.dtFechaNac);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(950, 491);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Mantenimiento";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.materialLabel1);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGenero.Location = new System.Drawing.Point(495, 265);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(417, 70);
            this.gbGenero.TabIndex = 48;
            this.gbGenero.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(34, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 24);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Genero:";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Depth = 0;
            this.rbMasculino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbMasculino.Location = new System.Drawing.Point(138, 28);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Ripple = true;
            this.rbMasculino.Size = new System.Drawing.Size(110, 30);
            this.rbMasculino.TabIndex = 38;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbFemenino.Depth = 0;
            this.rbFemenino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFemenino.Location = new System.Drawing.Point(300, 28);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.rbFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Ripple = true;
            this.rbFemenino.Size = new System.Drawing.Size(106, 30);
            this.rbFemenino.TabIndex = 39;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = false;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // gbTipo_Documento
            // 
            this.gbTipo_Documento.Controls.Add(this.rbOtro);
            this.gbTipo_Documento.Controls.Add(this.rbCi);
            this.gbTipo_Documento.Controls.Add(this.rbDni);
            this.gbTipo_Documento.Controls.Add(this.rbPasaporte);
            this.gbTipo_Documento.ForeColor = System.Drawing.Color.White;
            this.gbTipo_Documento.Location = new System.Drawing.Point(494, 100);
            this.gbTipo_Documento.Name = "gbTipo_Documento";
            this.gbTipo_Documento.Size = new System.Drawing.Size(433, 87);
            this.gbTipo_Documento.TabIndex = 47;
            this.gbTipo_Documento.TabStop = false;
            this.gbTipo_Documento.Text = "Tipo de Documento";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Depth = 0;
            this.rbOtro.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbOtro.Location = new System.Drawing.Point(358, 36);
            this.rbOtro.Margin = new System.Windows.Forms.Padding(0);
            this.rbOtro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbOtro.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Ripple = true;
            this.rbOtro.Size = new System.Drawing.Size(63, 30);
            this.rbOtro.TabIndex = 44;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbCi
            // 
            this.rbCi.AutoSize = true;
            this.rbCi.Depth = 0;
            this.rbCi.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCi.Location = new System.Drawing.Point(3, 36);
            this.rbCi.Margin = new System.Windows.Forms.Padding(0);
            this.rbCi.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCi.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCi.Name = "rbCi";
            this.rbCi.Ripple = true;
            this.rbCi.Size = new System.Drawing.Size(56, 30);
            this.rbCi.TabIndex = 42;
            this.rbCi.TabStop = true;
            this.rbCi.Text = "C.I.";
            this.rbCi.UseVisualStyleBackColor = true;
            this.rbCi.CheckedChanged += new System.EventHandler(this.rbCi_CheckedChanged);
            // 
            // rbDni
            // 
            this.rbDni.AutoSize = true;
            this.rbDni.Depth = 0;
            this.rbDni.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDni.Location = new System.Drawing.Point(103, 36);
            this.rbDni.Margin = new System.Windows.Forms.Padding(0);
            this.rbDni.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDni.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDni.Name = "rbDni";
            this.rbDni.Ripple = true;
            this.rbDni.Size = new System.Drawing.Size(73, 30);
            this.rbDni.TabIndex = 41;
            this.rbDni.TabStop = true;
            this.rbDni.Text = "D.N.I.";
            this.rbDni.UseVisualStyleBackColor = true;
            this.rbDni.CheckedChanged += new System.EventHandler(this.rbDni_CheckedChanged);
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Depth = 0;
            this.rbPasaporte.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbPasaporte.Location = new System.Drawing.Point(205, 36);
            this.rbPasaporte.Margin = new System.Windows.Forms.Padding(0);
            this.rbPasaporte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPasaporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Ripple = true;
            this.rbPasaporte.Size = new System.Drawing.Size(109, 30);
            this.rbPasaporte.TabIndex = 40;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            this.rbPasaporte.CheckedChanged += new System.EventHandler(this.rbPasaporte_CheckedChanged);
            // 
            // lbldtfecha_nac
            // 
            this.lbldtfecha_nac.AutoSize = true;
            this.lbldtfecha_nac.Depth = 0;
            this.lbldtfecha_nac.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbldtfecha_nac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldtfecha_nac.Location = new System.Drawing.Point(51, 100);
            this.lbldtfecha_nac.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbldtfecha_nac.Name = "lbldtfecha_nac";
            this.lbldtfecha_nac.Size = new System.Drawing.Size(131, 24);
            this.lbldtfecha_nac.TabIndex = 46;
            this.lbldtfecha_nac.Text = "Fecha de Nac.";
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(55, 285);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(419, 28);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.Text = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(55, 222);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(419, 28);
            this.txtTelefono.TabIndex = 36;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Depth = 0;
            this.txtApellidos.Hint = "";
            this.txtApellidos.Location = new System.Drawing.Point(494, 37);
            this.txtApellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.SelectionLength = 0;
            this.txtApellidos.SelectionStart = 0;
            this.txtApellidos.Size = new System.Drawing.Size(419, 28);
            this.txtApellidos.TabIndex = 35;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.UseSystemPasswordChar = false;
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.Leave += new System.EventHandler(this.txtApellidos_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(55, 159);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(419, 28);
            this.txtDireccion.TabIndex = 34;
            this.txtDireccion.Text = "Direccion";
            this.txtDireccion.UseSystemPasswordChar = false;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // txtNum_Documento
            // 
            this.txtNum_Documento.Depth = 0;
            this.txtNum_Documento.Hint = "";
            this.txtNum_Documento.Location = new System.Drawing.Point(495, 222);
            this.txtNum_Documento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNum_Documento.Name = "txtNum_Documento";
            this.txtNum_Documento.PasswordChar = '\0';
            this.txtNum_Documento.SelectedText = "";
            this.txtNum_Documento.SelectionLength = 0;
            this.txtNum_Documento.SelectionStart = 0;
            this.txtNum_Documento.Size = new System.Drawing.Size(419, 28);
            this.txtNum_Documento.TabIndex = 33;
            this.txtNum_Documento.Text = "Numero de Documento";
            this.txtNum_Documento.UseSystemPasswordChar = false;
            this.txtNum_Documento.Enter += new System.EventHandler(this.txtNum_Documento_Enter);
            this.txtNum_Documento.Leave += new System.EventHandler(this.txtNum_Documento_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(55, 37);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(419, 28);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtIdcliente
            // 
            this.txtIdcliente.Depth = 0;
            this.txtIdcliente.Hint = "";
            this.txtIdcliente.Location = new System.Drawing.Point(8, 3);
            this.txtIdcliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdcliente.Name = "txtIdcliente";
            this.txtIdcliente.PasswordChar = '\0';
            this.txtIdcliente.SelectedText = "";
            this.txtIdcliente.SelectionLength = 0;
            this.txtIdcliente.SelectionStart = 0;
            this.txtIdcliente.Size = new System.Drawing.Size(75, 28);
            this.txtIdcliente.TabIndex = 31;
            this.txtIdcliente.Text = "txtIdcliente";
            this.txtIdcliente.UseSystemPasswordChar = false;
            this.txtIdcliente.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(55, 433);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = true;
            this.btnBack.Size = new System.Drawing.Size(858, 30);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(495, 397);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(419, 30);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(55, 397);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(419, 30);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(494, 361);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(418, 30);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(55, 361);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(419, 30);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(958, 50);
            this.materialTabSelector1.TabIndex = 9;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(958, 635);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbTipo_Documento.ResumeLayout(false);
            this.gbTipo_Documento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton btnImprimir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialRadioButton rbOtro;
        private MaterialSkin.Controls.MaterialRadioButton rbCi;
        private MaterialSkin.Controls.MaterialRadioButton rbDni;
        private MaterialSkin.Controls.MaterialRadioButton rbPasaporte;
        private MaterialSkin.Controls.MaterialRadioButton rbFemenino;
        private MaterialSkin.Controls.MaterialRadioButton rbMasculino;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNum_Documento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdcliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnBack;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialLabel lbldtfecha_nac;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialRadioButton rbApellidos;
        private MaterialSkin.Controls.MaterialRadioButton rbDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialCheckBox chkEliminar;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.GroupBox gbTipo_Documento;
    }
}