using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmProveedor : MaterialForm
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private string tipo_documento;
        public frmProveedor()
        {
            InitializeComponent();


            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green700, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

            this.ttMensaje.SetToolTip(this.txtRazon_Social, "Ingrese Razón Social del Proveedor");
            this.ttMensaje.SetToolTip(this.txtNum_Documento, "Ingrese Número de Documento del Proveedor");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la dirección del Proveedor");
        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas DP", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtRazon_Social.Text = "Razon Social";
            this.txtNum_Documento.Text = "Numero de Documento";
            cbSector_Comercial.Text = "Sector Comercial";
            this.txtDireccion.Text = "Direccion";
            this.txtTelefono.Text = "Telefono";
            this.txtUrl.Text = "Url";
            this.txtEmail.Text = "Email";
            this.txtIdproveedor.Text = string.Empty;
            this.gbtipo_documento.Enabled = false;

        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtRazon_Social.Enabled = valor;
            this.txtDireccion.Enabled = valor;
            this.cbSector_Comercial.Enabled = valor;
            this.gbtipo_documento.Enabled = valor;
            this.txtNum_Documento.Enabled = valor;
            this.txtTelefono.Enabled = valor;
            this.txtUrl.Enabled = valor;
            this.txtEmail.Enabled = valor;
            this.txtIdproveedor.Enabled = valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar) //Alt + 124
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }

        //Método para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //Método Mostrar
        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarRazon_Social
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazon_social(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNum_Documento
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        
        

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbRazonSocial.Checked)
            {
                this.BuscarRazon_Social();
            }
            else if (rbDocumento.Checked)
            {
                this.BuscarNum_Documento();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas DP", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProveedor.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtRazon_Social.Text == string.Empty || this.txtNum_Documento.Text==string.Empty
                    || this.txtDireccion.Text==string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados los campos requeridos con obligacion");
                    errorIcono.SetError(txtRazon_Social, "Ingrese un nombre o razon social");
                    errorIcono.SetError(txtNum_Documento, "Ingrese un numero de documento");
                    errorIcono.SetError(txtDireccion, "Ingrese una direccion");
                }
                else
                {
                    if (this.IsNuevo)
                    {   
                        rpta = NProveedor.Insertar(this.txtRazon_Social.Text.Trim().ToUpper(),
                            this.cbSector_Comercial.Text,tipo_documento,
                            txtNum_Documento.Text,txtDireccion.Text,txtTelefono.Text,
                            txtEmail.Text,txtUrl.Text);

                    }
                    else
                    {
                        rpta = NProveedor.Editar(Convert.ToInt32(this.txtIdproveedor.Text),
                            this.txtRazon_Social.Text.Trim().ToUpper(),
                            this.cbSector_Comercial.Text, tipo_documento,
                            txtNum_Documento.Text, txtDireccion.Text, txtTelefono.Text,
                            txtEmail.Text, txtUrl.Text);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizó de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (!this.txtIdproveedor.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdproveedor.Text = string.Empty;
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            this.txtRazon_Social.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            this.cbSector_Comercial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_comercial"].Value);
            // this.cbTipo_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("C.I."))
                rbCi.Checked = true;
            else
                rbCi.Checked = false;

            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("Pasaporte"))
                rbPasaporte.Checked = true;
            else
                rbPasaporte.Checked = false;

            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("NIT"))
                rbNit.Checked = true;
            else
                rbNit.Checked = false;

            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("Otro"))
                rbOtro.Checked = true;
            else
                rbOtro.Checked = false;

            this.txtNum_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txtUrl.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["url"].Value);


            this.tabControl1.SelectedIndex = 1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteProveedor frm = new Reportes.FrmReporteProveedor();
            frm.Texto = txtBuscar.Text;
            frm.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage3;
        }

        private void rbCi_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "C.I.";
        }

        private void rbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "Pasaporte";
        }

        private void rbNit_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "NIT";
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "Otro";
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Proveedor a Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Proveedor a Buscar";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void txtRazon_Social_Enter(object sender, EventArgs e)
        {
            if (txtRazon_Social.Text == "Razon Social")
            {
                txtRazon_Social.Text = "";
                txtRazon_Social.ForeColor = Color.LightGray;
            }
        }

        private void txtRazon_Social_Leave(object sender, EventArgs e)
        {
            if (txtRazon_Social.Text == "")
            {
                txtRazon_Social.Text = "Razon Social";
                txtRazon_Social.ForeColor = Color.LightGray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Direccion")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.LightGray;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Direccion";
                txtDireccion.ForeColor = Color.LightGray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.LightGray;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtUrl_Enter(object sender, EventArgs e)
        {
            if (txtUrl.Text == "Url")
            {
                txtUrl.Text = "";
                txtUrl.ForeColor = Color.LightGray;
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            if (txtUrl.Text == "")
            {
                txtUrl.Text = "Url";
                txtUrl.ForeColor = Color.LightGray;
            }
        }

        private void txtNum_Documento_Enter(object sender, EventArgs e)
        {
            if (txtNum_Documento.Text == "Numero de Documento")
            {
                txtNum_Documento.Text = "";
                txtNum_Documento.ForeColor = Color.LightGray;
            }
        }

        private void txtNum_Documento_Leave(object sender, EventArgs e)
        {
            if (txtNum_Documento.Text == "")
            {
                txtNum_Documento.Text = "Numero de Documento";
                txtNum_Documento.ForeColor = Color.LightGray;
            }
        }

        
    }
}
