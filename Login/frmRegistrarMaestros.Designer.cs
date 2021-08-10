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
            this.btnAddUser = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 161);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Docente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Id Docente";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(29, 98);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(185, 20);
            this.txtID.TabIndex = 10;
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(220, 96);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(125, 21);
            this.cmbMateria.TabIndex = 6;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            this.cmbMateria.Click += new System.EventHandler(this.cmbMateria_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos del Docente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres del Docente";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(220, 47);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(185, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(29, 47);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(185, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(12, 187);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.Size = new System.Drawing.Size(888, 208);
            this.dgvDocentes.TabIndex = 19;
            this.dgvDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocentes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.btnEliminarEmpl);
            this.groupBox2.Controls.Add(this.btnActualizarEmpl);
            this.groupBox2.Controls.Add(this.btnActualizarGrid);
            this.groupBox2.Controls.Add(this.btnAgregarDoc);
            this.groupBox2.Controls.Add(this.BtnConectar);
            this.groupBox2.Location = new System.Drawing.Point(590, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 161);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del empleado";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(155)))), ((int)(((byte)(74)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(27, 113);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(111, 38);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Agregar un Usuario";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEliminarEmpl
            // 
            this.btnEliminarEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnEliminarEmpl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnEliminarEmpl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(155)))), ((int)(((byte)(74)))));
            this.btnEliminarEmpl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.btnEliminarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpl.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpl.Location = new System.Drawing.Point(159, 69);
            this.btnEliminarEmpl.Name = "btnEliminarEmpl";
            this.btnEliminarEmpl.Size = new System.Drawing.Size(111, 38);
            this.btnEliminarEmpl.TabIndex = 14;
            this.btnEliminarEmpl.Text = "Eliminar Docente";
            this.btnEliminarEmpl.UseVisualStyleBackColor = false;
            this.btnEliminarEmpl.Click += new System.EventHandler(this.btnEliminarEmpl_Click);
            // 
            // btnActualizarEmpl
            // 
            this.btnActualizarEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnActualizarEmpl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnActualizarEmpl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(155)))), ((int)(((byte)(74)))));
            this.btnActualizarEmpl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.btnActualizarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmpl.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEmpl.Location = new System.Drawing.Point(27, 69);
            this.btnActualizarEmpl.Name = "btnActualizarEmpl";
            this.btnActualizarEmpl.Size = new System.Drawing.Size(111, 38);
            this.btnActualizarEmpl.TabIndex = 11;
            this.btnActualizarEmpl.Text = "Actualizar Docente";
            this.btnActualizarEmpl.UseVisualStyleBackColor = false;
            this.btnActualizarEmpl.Click += new System.EventHandler(this.btnActualizarEmpl_Click);
            // 
            // btnActualizarGrid
            // 
            this.btnActualizarGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnActualizarGrid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnActualizarGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(155)))), ((int)(((byte)(74)))));
            this.btnActualizarGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.btnActualizarGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarGrid.ForeColor = System.Drawing.Color.White;
            this.btnActualizarGrid.Location = new System.Drawing.Point(159, 25);
            this.btnActualizarGrid.Name = "btnActualizarGrid";
            this.btnActualizarGrid.Size = new System.Drawing.Size(111, 38);
            this.btnActualizarGrid.TabIndex = 13;
            this.btnActualizarGrid.Text = "Actualizar grid de datos";
            this.btnActualizarGrid.UseVisualStyleBackColor = false;
            // 
            // btnAgregarDoc
            // 
            this.btnAgregarDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnAgregarDoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.btnAgregarDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(155)))), ((int)(((byte)(74)))));
            this.btnAgregarDoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.btnAgregarDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoc.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDoc.Location = new System.Drawing.Point(27, 25);
            this.btnAgregarDoc.Name = "btnAgregarDoc";
            this.btnAgregarDoc.Size = new System.Drawing.Size(111, 38);
            this.btnAgregarDoc.TabIndex = 10;
            this.btnAgregarDoc.Text = "Agregar Docente";
            this.btnAgregarDoc.UseVisualStyleBackColor = false;
            this.btnAgregarDoc.Click += new System.EventHandler(this.btnAgregarEmpl_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.BtnConectar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.BtnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(155)))), ((int)(((byte)(74)))));
            this.BtnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectar.ForeColor = System.Drawing.Color.White;
            this.BtnConectar.Location = new System.Drawing.Point(159, 113);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(111, 38);
            this.BtnConectar.TabIndex = 15;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(914, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDocentes);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEliminarEmpl;
        private System.Windows.Forms.Button btnActualizarEmpl;
        private System.Windows.Forms.Button btnActualizarGrid;
        private System.Windows.Forms.Button btnAgregarDoc;
        private System.Windows.Forms.Button BtnConectar;
    }
}