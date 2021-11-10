using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (contador == 3)
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
    }
}
