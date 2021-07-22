namespace Login
{
    partial class frmRegistrarMaestros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarEmpl = new System.Windows.Forms.Button();
            this.btnActualizarEmpl = new System.Windows.Forms.Button();
            this.btnActualizarGrid = new System.Windows.Forms.Button();
            this.btnAgregarDoc = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.cmbMateria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Location = new System.Drawing.Point(16, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(751, 198);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Docente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Id Docente";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 121);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(245, 22);
            this.txtID.TabIndex = 10;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(293, 118);
            this.cmbMateria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(165, 24);
            this.cmbMateria.TabIndex = 6;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            this.cmbMateria.Click += new System.EventHandler(this.cmbMateria_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Materia";
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
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres del Docente";
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
            // dgvDocentes
            // 
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(16, 242);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.Size = new System.Drawing.Size(1184, 256);
            this.dgvDocentes.TabIndex = 19;
            this.dgvDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEliminarEmpl);
            this.groupBox2.Controls.Add(this.btnActualizarEmpl);
            this.groupBox2.Controls.Add(this.btnActualizarGrid);
            this.groupBox2.Controls.Add(this.btnAgregarDoc);
            this.groupBox2.Controls.Add(this.BtnConectar);
            this.groupBox2.Location = new System.Drawing.Point(787, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(413, 198);
            this.groupBox2.TabIndex = 18;
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
            this.btnEliminarEmpl.Text = "Eliminar Docente";
            this.btnEliminarEmpl.UseVisualStyleBackColor = true;
            this.btnEliminarEmpl.Click += new System.EventHandler(this.btnEliminarEmpl_Click);
            // 
            // btnActualizarEmpl
            // 
            this.btnActualizarEmpl.Location = new System.Drawing.Point(36, 85);
            this.btnActualizarEmpl.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarEmpl.Name = "btnActualizarEmpl";
            this.btnActualizarEmpl.Size = new System.Drawing.Size(148, 47);
            this.btnActualizarEmpl.TabIndex = 11;
            this.btnActualizarEmpl.Text = "Actualizar Docente";
            this.btnActualizarEmpl.UseVisualStyleBackColor = true;
            this.btnActualizarEmpl.Click += new System.EventHandler(this.btnActualizarEmpl_Click);
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
            // btnAgregarDoc
            // 
            this.btnAgregarDoc.Location = new System.Drawing.Point(36, 31);
            this.btnAgregarDoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDoc.Name = "btnAgregarDoc";
            this.btnAgregarDoc.Size = new System.Drawing.Size(148, 47);
            this.btnAgregarDoc.TabIndex = 10;
            this.btnAgregarDoc.Text = "Agregar Docente";
            this.btnAgregarDoc.UseVisualStyleBackColor = true;
            this.btnAgregarDoc.Click += new System.EventHandler(this.btnAgregarEmpl_Click);
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
            // frmRegistrarMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegistrarMaestros";
            this.Text = "frmRegistrarMaestros";
            this.Load += new System.EventHandler(this.frmRegistrarMaestros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarEmpl;
        private System.Windows.Forms.Button btnActualizarEmpl;
        private System.Windows.Forms.Button btnActualizarGrid;
        private System.Windows.Forms.Button btnAgregarDoc;
        private System.Windows.Forms.Button BtnConectar;
    }
}