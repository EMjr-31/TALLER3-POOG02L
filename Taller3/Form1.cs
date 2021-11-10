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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ActivarIngreso();
        }
    }
}
