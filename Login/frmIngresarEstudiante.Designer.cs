﻿namespace Login
{
    partial class frmIngresarEstudiante
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarEmpl = new System.Windows.Forms.Button();
            this.btnActualizarEmpl = new System.Windows.Forms.Button();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            this.btnAgregarEmpl = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMunicipios = new System.Windows.Forms.ComboBox();
            this.cmbEstCivil = new System.Windows.Forms.ComboBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(48, 295);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(1194, 233);
            this.dgvEmpleados.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEliminarEmpl);
            this.groupBox2.Controls.Add(this.btnActualizarEmpl);
            this.groupBox2.Controls.Add(this.btnActualizarGrid);
            this.groupBox2.Controls.Add(this.btnAgregarEmpl);
            this.groupBox2.Controls.Add(this.BtnConectar);
            this.groupBox2.Location = new System.Drawing.Point(829, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 198);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del empleado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(36, 139);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 47);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEmpl
            // 
            this.btnEliminarEmpl.Location = new System.Drawing.Point(212, 85);
            this.btnEliminarEmpl.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarEmpl.Name = "btnEliminarEmpl";
            this.btnEliminarEmpl.Size = new System.Drawing.Size(148, 47);
            this.btnEliminarEmpl.TabIndex = 14;
            this.btnEliminarEmpl.Text = "Eliminar estudiante.";
            this.btnEliminarEmpl.UseVisualStyleBackColor = true;
            // 
            // btnActualizarEmpl
            // 
            this.btnActualizarEmpl.Location = new System.Drawing.Point(36, 85);
            this.btnActualizarEmpl.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarEmpl.Name = "btnActualizarEmpl";
            this.btnActualizarEmpl.Size = new System.Drawing.Size(148, 47);
            this.btnActualizarEmpl.TabIndex = 11;
            this.btnActualizarEmpl.Text = "Actualizar estudiante.";
            this.btnActualizarEmpl.UseVisualStyleBackColor = true;
            // 
            // btnActualizarGrid
            // 
            this.btnActualizarGrid.Location = new System.Drawing.Point(212, 31);
            this.btnActualizarGrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(148, 47);
            this.btnActualizarGrid.TabIndex = 13;
            this.btnActualizarGrid.Text = "Actualizar grid de datos";
            this.btnActualizarGrid.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEmpl
            // 
            this.btnAgregarEmpl.Location = new System.Drawing.Point(36, 31);
            this.btnAgregarEmpl.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEmpl.Name = "btnAgregarEmpl";
            this.btnAgregarEmpl.Size = new System.Drawing.Size(148, 47);
            this.btnAgregarEmpl.TabIndex = 10;
            this.btnAgregarEmpl.Text = "Agregar estudiante.";
            this.btnAgregarEmpl.UseVisualStyleBackColor = true;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(212, 139);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(148, 47);
            this.BtnConectar.TabIndex = 15;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dtpNacimiento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbMunicipios);
            this.groupBox1.Controls.Add(this.cmbEstCivil);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Location = new System.Drawing.Point(48, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(751, 198);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del empleado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "ID estudiante/ Carnet:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(293, 110);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(245, 22);
            this.txtID.TabIndex = 10;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimiento.Location = new System.Drawing.Point(293, 164);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(245, 22);
            this.dtpNacimiento.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // cmbMunicipios
            // 
            this.cmbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipios.FormattingEnabled = true;
            this.cmbMunicipios.Location = new System.Drawing.Point(559, 158);
            this.cmbMunicipios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMunicipios.Name = "cmbMunicipios";
            this.cmbMunicipios.Size = new System.Drawing.Size(165, 24);
            this.cmbMunicipios.TabIndex = 8;
            // 
            // cmbEstCivil
            // 
            this.cmbEstCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstCivil.FormattingEnabled = true;
            this.cmbEstCivil.Location = new System.Drawing.Point(559, 106);
            this.cmbEstCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstCivil.Name = "cmbEstCivil";
            this.cmbEstCivil.Size = new System.Drawing.Size(165, 24);
            this.cmbEstCivil.TabIndex = 7;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(559, 57);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(165, 24);
            this.cmbTipoDocumento.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Genero.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Año.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Especialidad.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos del apellido.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres del estudiante.";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(39, 106);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(245, 82);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(293, 58);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(245, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(39, 58);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(245, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // frmIngresarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 570);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmIngresarEstudiante";
            this.Text = "frmIngresarEstudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarEmpl;
        private System.Windows.Forms.Button btnActualizarEmpl;
        private System.Windows.Forms.Button btnActualizarGrid;
        private System.Windows.Forms.Button btnAgregarEmpl;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMunicipios;
        private System.Windows.Forms.ComboBox cmbEstCivil;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
    }
}