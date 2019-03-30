using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CapaPresentacion
{
    public partial class frmCliente : MaterialForm
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private string sexo;
        private string tipo_documento;
        public frmCliente()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green700, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);




            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del Cliente");
            this.ttMensaje.SetToolTip(this.txtApellidos, "Ingrese los Apellidos del Cliente");
            this.ttMensaje.SetToolTip(this.txtDireccion, "Ingrese la dirección del Cliente");
            this.ttMensaje.SetToolTip(this.txtNum_Documento, "Ingrese el número de documento del Cliente");

        }

        //Mostrar Mensaje de Confirmación
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtNombre.Text = "Nombre";
            this.txtApellidos.Text = "Apellidos";
            this.txtNum_Documento.Text = "Numero de Documento";
            this.txtDireccion.Text = "Direccion";
            this.txtTelefono.Text = "Telefono";
            this.txtEmail.Text = "Email";
            this.txtIdcliente.Text = string.Empty;
            this.rbFemenino.Checked = false;
            this.rbMasculino.Checked = false;
            this.rbCi.Checked = false;
            this.rbDni.Checked = false;
            this.rbPasaporte.Checked = false;
            this.rbOtro.Checked = false;
            

        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txtNombre.Enabled = valor;
            this.txtApellidos.Enabled = valor;
            this.txtDireccion.Enabled = valor;
            this.txtNum_Documento.Enabled = valor;
            this.txtTelefono.Enabled = valor;
            this.txtEmail.Enabled = valor;
            this.txtIdcliente.Enabled = valor;
            this.dtFechaNac.Enabled = valor;
            this.gbGenero.Enabled = valor;
            this.gbTipo_Documento.Enabled = valor;
            this.lbldtfecha_nac.Enabled = valor;
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
            this.dataListado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarApellidos
        private void BuscarApellidos()
        {
            this.dataListado.DataSource = NCliente.BuscarApellidos(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        //Método BuscarNum_Documento
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NCliente.BuscarNum_Documento(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbApellidos.Checked)
            {
                this.BuscarApellidos();
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
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NCliente.Eliminar(Convert.ToInt32(Codigo));

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
            this.txtIdcliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcliente"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtApellidos.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value);
            //this.rbHombre.Checked = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
            this.rbMasculino.Checked = this.dataListado.CurrentRow.Cells["sexo"].Equals("M");
            this.rbFemenino.Checked = !this.rbMasculino.Checked;


            if (this.dataListado.CurrentRow.Cells["sexo"].Value.Equals("F"))
                rbFemenino.Checked = true;
            else
                rbFemenino.Checked = false;

            if (this.dataListado.CurrentRow.Cells["sexo"].Value.Equals("M"))
                rbMasculino.Checked = true;
            else
                rbMasculino.Checked = false;


            this.dtFechaNac.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_nacimiento"].Value);
            //this.cbTipo_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("C.I."))
                rbCi.Checked = true;
            else
                rbCi.Checked = false;

            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("D.N.I."))
                rbDni.Checked = true;
            else
                rbDni.Checked = false;

            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("Pasaporte"))
                rbPasaporte.Checked = true;
            else
                rbPasaporte.Checked = false;

            if (this.dataListado.CurrentRow.Cells["tipo_documento"].Value.Equals("Otro"))
                rbOtro.Checked = true;
            else
                rbOtro.Checked = false;

            
            this.txtNum_Documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            
            this.tabControl1.SelectedIndex = 1;

        }

      
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == "´Nombre" || this.txtApellidos.Text == "Apellidos" ||  
                    this.txtNum_Documento.Text == "´Tipo de Documento"
                    || this.txtDireccion.Text == "´Direccion")
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un Valor");
                    errorIcono.SetError(txtApellidos, "Ingrese un Valor");
                    errorIcono.SetError(txtNum_Documento, "Ingrese un Valor");
                    errorIcono.SetError(txtDireccion, "Ingrese un Valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NCliente.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellidos.Text.Trim().ToUpper(),
                            this.sexo, dtFechaNac.Value, this.tipo_documento,
                            txtNum_Documento.Text, txtDireccion.Text, txtTelefono.Text,
                            txtEmail.Text);

                    }
                    else
                    {
                        rpta = NCliente.Editar(Convert.ToInt32(this.txtIdcliente.Text),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellidos.Text.Trim().ToUpper(),
                            this.sexo, dtFechaNac.Value, this.tipo_documento,
                            txtNum_Documento.Text, txtDireccion.Text, txtTelefono.Text,
                            txtEmail.Text);
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");
                            
;                        }
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

            if (!this.txtIdcliente.Text.Equals(""))
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
            this.Habilitar(false);
            this.Limpiar();
            this.txtIdcliente.Text = string.Empty;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteCliente frm = new Reportes.FrmReporteCliente();
            frm.Texto = txtBuscar.Text;
            frm.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabPage3;
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            this.sexo = "M";
        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            this.sexo = "F";
        }

        private void rbCi_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "C.I.";
        }

        private void rbDni_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "D.N.I.";
        }

        private void rbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "Pasaporte";
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            this.tipo_documento = "Otro";
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.LightGray;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.LightGray;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "Apellidos";
                txtApellidos.ForeColor = Color.LightGray;
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

        private void txtNum_Documento_Enter(object sender, EventArgs e)
        {
            if (txtNum_Documento.Text == "txtNum_Documento")
            {
                txtNum_Documento.Text = "";
                txtNum_Documento.ForeColor = Color.LightGray;
            }
        }

        private void txtNum_Documento_Leave(object sender, EventArgs e)
        {
            if (txtNum_Documento.Text == "")
            {
                txtNum_Documento.Text = "txtNum_Documento";
                txtNum_Documento.ForeColor = Color.LightGray;
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

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Cliente a Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.LightGray;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Cliente a Buscar";
                txtBuscar.ForeColor = Color.Gray;

            }
        }
    }
}
