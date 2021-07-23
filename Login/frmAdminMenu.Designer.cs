namespace Login
{
    partial class frmAdminMenu
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
            System.Windows.Forms.Button btnIngresarPerfil;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMenu));
            System.Windows.Forms.Button btnDocentes;
            System.Windows.Forms.Button btnAlumnos;
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            btnIngresarPerfil = new System.Windows.Forms.Button();
            btnDocentes = new System.Windows.Forms.Button();
            btnAlumnos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarPerfil
            // 
            btnIngresarPerfil.BackColor = System.Drawing.SystemColors.Info;
            btnIngresarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnIngresarPerfil.Font = new System.Drawing.Font("Century Gothic", 9.8F, System.Drawing.FontStyle.Bold);
            btnIngresarPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnIngresarPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnIngresarPerfil.Location = new System.Drawing.Point(537, 431);
            btnIngresarPerfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnIngresarPerfil.Name = "btnIngresarPerfil";
            btnIngresarPerfil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnIngresarPerfil.Size = new System.Drawing.Size(261, 98);
            btnIngresarPerfil.TabIndex = 43;
            btnIngresarPerfil.Text = "Crear Usuario";
            btnIngresarPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnIngresarPerfil.UseVisualStyleBackColor = false;
            btnIngresarPerfil.Click += new System.EventHandler(this.btnIngresarPerfil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(543, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 47);
            this.label5.TabIndex = 42;
            this.label5.Text = "Panel de control ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 714);
            this.panel1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(17, 641);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Juan Pablo Romero Ramos";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(21, 662);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 36);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cerrar Sesion";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(27, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bienvenido,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(547, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 40;
            // 
            // btnDocentes
            // 
            btnDocentes.BackColor = System.Drawing.SystemColors.Info;
            btnDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDocentes.Font = new System.Drawing.Font("Century Gothic", 9.8F, System.Drawing.FontStyle.Bold);
            btnDocentes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnDocentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDocentes.Location = new System.Drawing.Point(364, 261);
            btnDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnDocentes.Size = new System.Drawing.Size(261, 98);
            btnDocentes.TabIndex = 38;
            btnDocentes.Text = "Ingresar/Ver Docentes";
            btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDocentes.UseVisualStyleBackColor = false;
            btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnAlumnos
            // 
            btnAlumnos.BackColor = System.Drawing.SystemColors.Info;
            btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAlumnos.Font = new System.Drawing.Font("Century Gothic", 9.8F, System.Drawing.FontStyle.Bold);
            btnAlumnos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAlumnos.Location = new System.Drawing.Point(767, 261);
            btnAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnAlumnos.Size = new System.Drawing.Size(261, 98);
            btnAlumnos.TabIndex = 39;
            btnAlumnos.Text = "Ingresar/Ver Alumnos";
            btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAlumnos.UseVisualStyleBackColor = false;
            btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.2F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtName.Location = new System.Drawing.Point(146, 226);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 23);
            this.txtName.TabIndex = 11;
            // 
            // frmAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 719);
            this.Controls.Add(btnIngresarPerfil);
            this.Controls.Add(btnAlumnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnDocentes);
            this.Name = "frmAdminMenu";
            this.Text = "frmAdminMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtName;
    }
}