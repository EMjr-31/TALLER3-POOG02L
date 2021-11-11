using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Taller3
{
    public partial class frmRegistoEmpleados : Form
    {
        //Lista de empleados
        List<Empleados> empleados = new List<Empleados>();
        int contador = 0;
        public frmRegistoEmpleados()
        {
            InitializeComponent();
            DesactivarIngreso();

        }

        //Validamos el email
        public static bool validaremail(string email)
        {
            //cadena o expresion regular que verifica a un formato de correo electrónico
            string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a - z]{ 2,4})$";
            //verifica que el email ingresado corresponda con la expresion válida
            if (Regex.IsMatch(email, expresion))
            {//verifica que la direccion corresponda y que la longitud de la cadena no esté vacía
            if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        //Validamos la fecha de nacimiento
        private int ValidarFecha()
        {
            int edad;
            int edadMayor = 18;
            int edadMenor = 50;

            //Obtenemos la fecha de nacimiento
            DateTime fechaNacimiento = Convert.ToDateTime(dtpFechanac.Text);

            //Obtenemos la fecha actual
            DateTime fechaActual = DateTime.Today;

            //Calculamos la edad
            edad = fechaActual.Year - fechaNacimiento.Year;

            //Validamos que la edad sea mayor a 18 y menor a 50
            if (edad >= edadMayor && edad <= edadMenor)
            {
                MessageBox.Show("La edad es: " + edad);
                return 1;
            }
            else
            {
                MessageBox.Show("La edad no es válida");
                return 0;
            }
        }
        ////Funcion activar ingreso de empleados
        public void DesactivarIngreso()
        {
            ///Datos personales
            Lblnombres.Enabled = false;
            txtnombres.Enabled = false;
            Lblapellidos.Enabled = false;
            txtapellidos.Enabled = false;
            Lblfechanac.Enabled = false;
            dtpFechanac.Enabled = false;
            txtDUI.Enabled = false;
            lblDUI.Enabled = false;
            lblCorreo.Enabled = false;
            txtEmail.Enabled = false;
            lblTel.Enabled = false;
            txtTel.Enabled = false;
            ///Datos laborales
            lblContrato.Enabled = false;
            dtpFechaContrato.Enabled = false;
            lblSueldo.Enabled = false;
            txtSueldoini.Enabled = false;
            txtSueldoini.Enabled = false;
            lblRenta.Enabled = false;
            lblISSS.Enabled = false;
            nudRenta.Enabled = false;
            nudISSS.Enabled = false;
            ///botones 
            btnAbrirPlanilla.Enabled = false;
            btnaceptar.Enabled = false;
            btnGenerarPlanilla.Enabled = false;
            dgvEmpleados.Enabled = false;
        }
        ////Funcion activar ingreso de empleados
        public void ActivarIngreso()
        {
            ///Datos personales
            Lblnombres.Enabled = true;
            txtnombres.Enabled = true;
            Lblapellidos.Enabled = true;
            txtapellidos.Enabled = true;
            Lblfechanac.Enabled = true;
            dtpFechanac.Enabled = true;
            txtDUI.Enabled = true;
            lblDUI.Enabled = true;
            lblCorreo.Enabled = true;
            txtEmail.Enabled = true;
            lblTel.Enabled = true;
            txtTel.Enabled = true;
            ///Datos laborales
            lblContrato.Enabled = true;
            dtpFechaContrato.Enabled = true;
            lblSueldo.Enabled = true;
            txtSueldoini.Enabled = true;
            txtSueldoini.Enabled = true;
            lblRenta.Enabled = true;
            lblISSS.Enabled = true;
            nudRenta.Enabled = true;
            nudISSS.Enabled = true;
            ///botones 
            btnaceptar.Enabled = true;
            btnnuevo.Enabled = false;
        }
        ////Funcion activar ingreso de empleados
        public void VerificacionRegistro()
        {
            if (contador == 10)
            {
                MessageBox.Show("Han sido ingresado los 10 empleados");
                DesactivarIngreso();
                btnAbrirPlanilla.Enabled = true;
            }

        }
        ///Limipiar campos
        public void LimpiaCampos()
        {
            ///Datos personales
            txtnombres.Clear();
            txtapellidos.Clear();
            txtTel.Text="";
            txtDUI.Text = "";
            txtEmail.Clear();
            dtpFechanac.Value= DateTime.Today;
            ///Datos laborales
            dtpFechaContrato.Value = DateTime.Today;
            txtSueldoini.Clear();
            txtSueldoini.Clear();
            nudRenta.Value = 0;
            nudISSS.Value =0;
            ///Enfacis 
            txtnombres.Focus();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            
            ActivarIngreso();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            /// Guardar Datos 
            try
            {
                Empleados empleado = new Empleados();
                empleado.Nombre = txtnombres.Text + " " + txtapellidos.Text;
                empleado.FechaNac = dtpFechanac.Value.Date;
                empleado.DUI = txtDUI.Text;
                empleado.Tel = txtTel.Text;
                empleado.Correo = txtEmail.Text;
                empleado.FechaCont = dtpFechaContrato.Value.Date ;
                empleado.SueldoBase = float.Parse(txtSueldoini.Text);
                empleado.Renta = (float.Parse(nudRenta.Text)/100) * float.Parse(txtSueldoini.Text);
                empleado.ISSS = (float.Parse(nudISSS.Text)/100) * float.Parse(txtSueldoini.Text);
                empleado.Descuentos = ((float.Parse(nudRenta.Text) / 100) * float.Parse(txtSueldoini.Text)) + ((float.Parse(nudISSS.Text) / 100) * float.Parse(txtSueldoini.Text));
                empleado.SueldoNeto = float.Parse(txtSueldoini.Text)- (((float.Parse(nudRenta.Text) / 100) * float.Parse(txtSueldoini.Text)) + ((float.Parse(nudISSS.Text) / 100) * float.Parse(txtSueldoini.Text)));
                empleados.Add(empleado);
                contador++;
                LimpiaCampos();
                
                VerificacionRegistro();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnAbrirPlanilla_Click(object sender, EventArgs e)
        {
            btnGenerarPlanilla.Enabled = true;
            dgvEmpleados.Enabled = true;
            btnAbrirPlanilla.Enabled = false;
        }

        private void btnGenerarPlanilla_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;
        }

        private void dtpFechanac_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpFechanac_Validated(object sender, EventArgs e)
        {
            ValidarFecha();
        }

        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

       

        private void txtnombres_Validated(object sender, EventArgs e)
        {
            if(txtnombres.Text.Trim() == "")
            {
                //con el nombre que le pusimos al error provider, lo obtenemos y accionamos junto con su mensaje
                epError.SetError(txtnombres, " Introduce Nombre ");
                txtnombres.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtapellidos_Validated(object sender, EventArgs e)
        {
            if(txtapellidos.Text.Trim() == "")
            {
                //con el nombre que le pusimos al error provider, lo obtenemos y accionamos junto con su mensaje
                epError.SetError(txtapellidos, " Introduce Apellido ");
                txtapellidos.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtDUI_Validated(object sender, EventArgs e)
        {
            if (txtDUI.Text.Trim() == "")
            {
                //con el nombre que le pusimos al error provider, lo obtenemos y accionamos junto con su mensaje
                epError.SetError(txtDUI, " Introduce DUI ");
                txtDUI.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtTel_Validated(object sender, EventArgs e)
        {
            if (txtTel.Text.Trim() == "")
            {
                //con el nombre que le pusimos al error provider, lo obtenemos y accionamos junto con su mensaje
                epError.SetError(txtTel, " Introduce Telefono ");
                txtTel.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                //con el nombre que le pusimos al error provider, lo obtenemos y accionamos junto con su mensaje
                epError.SetError(txtEmail, " Introduce Email ");
                txtEmail.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtSueldoini_Validated(object sender, EventArgs e)
        {
            if (txtSueldoini.Text.Trim() == "")
            {
                //con el nombre que le pusimos al error provider, lo obtenemos y accionamos junto con su mensaje
                epError.SetError(txtSueldoini, " Introduce Sueldo Base ");
                txtSueldoini.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

       

        private void txtSueldoini_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtSueldoini.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (validaremail(txtEmail.Text))
            {
                //si es correcto no debe hacer nada
            }
            else
            {/*sino es correcto que envíe este mensaje y se posicione para
            verificar recuerde que se activará la validación al dar click en otro textbox o
            simplemente dejar o salir de esa casilla de email*/
                MessageBox.Show("Dirección de correo no válida");
                txtEmail.SelectAll(); //selecciona todo lo de la casilla
                txtEmail.Focus(); //se posiciona ahí de nuevo
            }

        }

        private void nudRenta_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
