namespace Login
{
    partial class frmIngresoNotas
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
            this.btnIngresarNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbtrimestre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbperfil = new System.Windows.Forms.ComboBox();
            this.cmbgrado = new System.Windows.Forms.ComboBox();
            this.cmbseccion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnCambiarNota = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbalumno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarNota
            // 
            this.btnIngresarNota.Location = new System.Drawing.Point(18, 40);
            this.btnIngresarNota.Name = "btnIngresarNota";
            this.btnIngresarNota.Size = new System.Drawing.Size(107, 47);
            this.btnIngresarNota.TabIndex = 0;
            this.btnIngresarNota.Text = "Ingresar nota";
            this.btnIngresarNota.UseVisualStyleBackColor = true;
            this.btnIngresarNota.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grado ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seccion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trimestre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnotas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbalumno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbtrimestre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbperfil);
            this.groupBox1.Controls.Add(this.cmbgrado);
            this.groupBox1.Controls.Add(this.cmbseccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 190);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Notas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbtrimestre
            // 
            this.cmbtrimestre.FormattingEnabled = true;
            this.cmbtrimestre.Location = new System.Drawing.Point(238, 54);
            this.cmbtrimestre.Name = "cmbtrimestre";
            this.cmbtrimestre.Size = new System.Drawing.Size(167, 21);
            this.cmbtrimestre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Perfil";
            // 
            // cmbperfil
            // 
            this.cmbperfil.FormattingEnabled = true;
            this.cmbperfil.Location = new System.Drawing.Point(238, 101);
            this.cmbperfil.Name = "cmbperfil";
            this.cmbperfil.Size = new System.Drawing.Size(167, 21);
            this.cmbperfil.TabIndex = 14;
            // 
            // cmbgrado
            // 
            this.cmbgrado.FormattingEnabled = true;
            this.cmbgrado.Location = new System.Drawing.Point(21, 54);
            this.cmbgrado.Name = "cmbgrado";
            this.cmbgrado.Size = new System.Drawing.Size(167, 21);
            this.cmbgrado.TabIndex = 13;
            this.cmbgrado.SelectedIndexChanged += new System.EventHandler(this.txtgrado_SelectedIndexChanged);
            // 
            // cmbseccion
            // 
            this.cmbseccion.FormattingEnabled = true;
            this.cmbseccion.Location = new System.Drawing.Point(21, 104);
            this.cmbseccion.Name = "cmbseccion";
            this.cmbseccion.Size = new System.Drawing.Size(167, 21);
            this.cmbseccion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarNota);
            this.groupBox2.Controls.Add(this.btnLimpiarCampos);
            this.groupBox2.Controls.Add(this.btnCambiarNota);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnIngresarNota);
            this.groupBox2.Location = new System.Drawing.Point(481, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 190);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de Notas";
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.Location = new System.Drawing.Point(18, 122);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(107, 47);
            this.btnEliminarNota.TabIndex = 14;
            this.btnEliminarNota.Text = "Eliminar nota";
            this.btnEliminarNota.UseVisualStyleBackColor = true;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(156, 122);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(107, 47);
            this.btnLimpiarCampos.TabIndex = 12;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnCambiarNota
            // 
            this.btnCambiarNota.Location = new System.Drawing.Point(156, 40);
            this.btnCambiarNota.Name = "btnCambiarNota";
            this.btnCambiarNota.Size = new System.Drawing.Size(107, 47);
            this.btnCambiarNota.TabIndex = 11;
            this.btnCambiarNota.Text = "Cambiar nota";
            this.btnCambiarNota.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 219);
            this.dataGridView1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alumno";
            // 
            // cmbalumno
            // 
            this.cmbalumno.FormattingEnabled = true;
            this.cmbalumno.Location = new System.Drawing.Point(21, 158);
            this.cmbalumno.Name = "cmbalumno";
            this.cmbalumno.Size = new System.Drawing.Size(167, 21);
            this.cmbalumno.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ingrese nota";
            // 
            // txtnotas
            // 
            this.txtnotas.Location = new System.Drawing.Point(238, 158);
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(167, 20);
            this.txtnotas.TabIndex = 20;
            // 
            // frmIngresoNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIngresoNotas";
            this.Text = "frmIngresoNotas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbperfil;
        private System.Windows.Forms.ComboBox cmbgrado;
        private System.Windows.Forms.ComboBox cmbseccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminarNota;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnCambiarNota;
        private System.Windows.Forms.ComboBox cmbtrimestre;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ComboBox cmbalumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.Label label7;
    }
}