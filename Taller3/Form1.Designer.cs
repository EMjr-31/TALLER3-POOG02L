﻿
namespace Taller3
{
    partial class frmRegistoEmpleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechanac = new System.Windows.Forms.DateTimePicker();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.Lblfechanac = new System.Windows.Forms.Label();
            this.Lblapellidos = new System.Windows.Forms.Label();
            this.Lblnombres = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudISSS = new System.Windows.Forms.NumericUpDown();
            this.lblISSS = new System.Windows.Forms.Label();
            this.nudRenta = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.txtSueldoini = new System.Windows.Forms.TextBox();
            this.lblRenta = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.btnAbrirPlanilla = new System.Windows.Forms.Button();
            this.btnGenerarPlanilla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechanac);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Controls.Add(this.Lblfechanac);
            this.groupBox1.Controls.Add(this.Lblapellidos);
            this.groupBox1.Controls.Add(this.Lblnombres);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales de empleados";
            // 
            // dtpFechanac
            // 
            this.dtpFechanac.Location = new System.Drawing.Point(171, 108);
            this.dtpFechanac.Name = "dtpFechanac";
            this.dtpFechanac.Size = new System.Drawing.Size(157, 24);
            this.dtpFechanac.TabIndex = 5;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(171, 70);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(155, 24);
            this.txtapellidos.TabIndex = 4;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(171, 31);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(155, 24);
            this.txtnombres.TabIndex = 3;
            // 
            // Lblfechanac
            // 
            this.Lblfechanac.AutoSize = true;
            this.Lblfechanac.Location = new System.Drawing.Point(16, 114);
            this.Lblfechanac.Name = "Lblfechanac";
            this.Lblfechanac.Size = new System.Drawing.Size(149, 18);
            this.Lblfechanac.TabIndex = 2;
            this.Lblfechanac.Text = "Fecha de nacimiento:";
            // 
            // Lblapellidos
            // 
            this.Lblapellidos.AutoSize = true;
            this.Lblapellidos.Location = new System.Drawing.Point(16, 73);
            this.Lblapellidos.Name = "Lblapellidos";
            this.Lblapellidos.Size = new System.Drawing.Size(63, 18);
            this.Lblapellidos.TabIndex = 1;
            this.Lblapellidos.Text = "Apellido:";
            // 
            // Lblnombres
            // 
            this.Lblnombres.AutoSize = true;
            this.Lblnombres.Location = new System.Drawing.Point(16, 31);
            this.Lblnombres.Name = "Lblnombres";
            this.Lblnombres.Size = new System.Drawing.Size(66, 18);
            this.Lblnombres.TabIndex = 0;
            this.Lblnombres.Text = "Nombre:";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(21, 181);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(122, 49);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo Empleado";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(224, 181);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(124, 49);
            this.btnaceptar.TabIndex = 2;
            this.btnaceptar.Text = "Proximo Empleado";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudISSS);
            this.groupBox2.Controls.Add(this.lblISSS);
            this.groupBox2.Controls.Add(this.nudRenta);
            this.groupBox2.Controls.Add(this.dtpFechaContrato);
            this.groupBox2.Controls.Add(this.txtSueldoini);
            this.groupBox2.Controls.Add(this.lblRenta);
            this.groupBox2.Controls.Add(this.lblSueldo);
            this.groupBox2.Controls.Add(this.lblContrato);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(359, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 142);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos laborales:";
            // 
            // nudISSS
            // 
            this.nudISSS.DecimalPlaces = 1;
            this.nudISSS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudISSS.Location = new System.Drawing.Point(254, 108);
            this.nudISSS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudISSS.Name = "nudISSS";
            this.nudISSS.Size = new System.Drawing.Size(72, 24);
            this.nudISSS.TabIndex = 12;
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Location = new System.Drawing.Point(166, 110);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(82, 18);
            this.lblISSS.TabIndex = 11;
            this.lblISSS.Text = "Tasa ISSS:";
            // 
            // nudRenta
            // 
            this.nudRenta.DecimalPlaces = 1;
            this.nudRenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRenta.Location = new System.Drawing.Point(88, 106);
            this.nudRenta.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRenta.Name = "nudRenta";
            this.nudRenta.Size = new System.Drawing.Size(72, 24);
            this.nudRenta.TabIndex = 10;
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Location = new System.Drawing.Point(169, 29);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(157, 24);
            this.dtpFechaContrato.TabIndex = 7;
            // 
            // txtSueldoini
            // 
            this.txtSueldoini.Location = new System.Drawing.Point(171, 67);
            this.txtSueldoini.Name = "txtSueldoini";
            this.txtSueldoini.Size = new System.Drawing.Size(155, 24);
            this.txtSueldoini.TabIndex = 7;
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(6, 108);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(82, 18);
            this.lblRenta.TabIndex = 9;
            this.lblRenta.Text = "Tasa renta:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(6, 70);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(96, 18);
            this.lblSueldo.TabIndex = 8;
            this.lblSueldo.Text = "Sueldo Base:";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(6, 31);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(115, 18);
            this.lblContrato.TabIndex = 7;
            this.lblContrato.Text = "Fecha Contrato:";
            // 
            // btnAbrirPlanilla
            // 
            this.btnAbrirPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPlanilla.Location = new System.Drawing.Point(381, 181);
            this.btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            this.btnAbrirPlanilla.Size = new System.Drawing.Size(110, 49);
            this.btnAbrirPlanilla.TabIndex = 5;
            this.btnAbrirPlanilla.Text = "Abrir Planilla";
            this.btnAbrirPlanilla.UseVisualStyleBackColor = true;
            // 
            // btnGenerarPlanilla
            // 
            this.btnGenerarPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPlanilla.Location = new System.Drawing.Point(584, 181);
            this.btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            this.btnGenerarPlanilla.Size = new System.Drawing.Size(110, 49);
            this.btnGenerarPlanilla.TabIndex = 6;
            this.btnGenerarPlanilla.Text = "Generar Planilla";
            this.btnGenerarPlanilla.UseVisualStyleBackColor = true;
            // 
            // frmRegistoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 470);
            this.Controls.Add(this.btnGenerarPlanilla);
            this.Controls.Add(this.btnAbrirPlanilla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistoEmpleados";
            this.Text = "Registro inicial de Empleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechanac;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label Lblfechanac;
        private System.Windows.Forms.Label Lblapellidos;
        private System.Windows.Forms.Label Lblnombres;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudISSS;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.NumericUpDown nudRenta;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.TextBox txtSueldoini;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Button btnAbrirPlanilla;
        private System.Windows.Forms.Button btnGenerarPlanilla;
    }
}
