namespace Proyecto_Final
{
    partial class InicioSesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesi));
            this.but_InicioSecion = new System.Windows.Forms.Button();
            this.But_CancelInSe = new System.Windows.Forms.Button();
            this.Tex_Pass = new System.Windows.Forms.TextBox();
            this.texb_Usuario = new System.Windows.Forms.TextBox();
            this.Lab_Usuari = new System.Windows.Forms.Label();
            this.Labe_Contra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.But_LimUsCon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_InicioSecion
            // 
            this.but_InicioSecion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.but_InicioSecion.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_InicioSecion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.but_InicioSecion.Location = new System.Drawing.Point(32, 325);
            this.but_InicioSecion.Name = "but_InicioSecion";
            this.but_InicioSecion.Size = new System.Drawing.Size(122, 35);
            this.but_InicioSecion.TabIndex = 0;
            this.but_InicioSecion.Text = "INICIAR SESION";
            this.but_InicioSecion.UseVisualStyleBackColor = false;
            this.but_InicioSecion.Click += new System.EventHandler(this.but_InicioSecion_Click);
            // 
            // But_CancelInSe
            // 
            this.But_CancelInSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.But_CancelInSe.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_CancelInSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.But_CancelInSe.Location = new System.Drawing.Point(283, 325);
            this.But_CancelInSe.Name = "But_CancelInSe";
            this.But_CancelInSe.Size = new System.Drawing.Size(111, 35);
            this.But_CancelInSe.TabIndex = 1;
            this.But_CancelInSe.Text = "CANCELAR";
            this.But_CancelInSe.UseVisualStyleBackColor = false;
            this.But_CancelInSe.Click += new System.EventHandler(this.But_CancelInSe_Click);
            // 
            // Tex_Pass
            // 
            this.Tex_Pass.Location = new System.Drawing.Point(171, 229);
            this.Tex_Pass.Name = "Tex_Pass";
            this.Tex_Pass.PasswordChar = '*';
            this.Tex_Pass.Size = new System.Drawing.Size(242, 20);
            this.Tex_Pass.TabIndex = 2;
            this.Tex_Pass.TextChanged += new System.EventHandler(this.Tex_Contraseña_TextChanged);
            // 
            // texb_Usuario
            // 
            this.texb_Usuario.Location = new System.Drawing.Point(171, 194);
            this.texb_Usuario.Name = "texb_Usuario";
            this.texb_Usuario.Size = new System.Drawing.Size(242, 20);
            this.texb_Usuario.TabIndex = 3;
            this.texb_Usuario.TextChanged += new System.EventHandler(this.texb_Usuario_TextChanged);
            // 
            // Lab_Usuari
            // 
            this.Lab_Usuari.AutoSize = true;
            this.Lab_Usuari.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Usuari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.Lab_Usuari.Location = new System.Drawing.Point(29, 197);
            this.Lab_Usuari.Name = "Lab_Usuari";
            this.Lab_Usuari.Size = new System.Drawing.Size(69, 17);
            this.Lab_Usuari.TabIndex = 4;
            this.Lab_Usuari.Text = "USUARIO";
            // 
            // Labe_Contra
            // 
            this.Labe_Contra.AutoSize = true;
            this.Labe_Contra.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labe_Contra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.Labe_Contra.Location = new System.Drawing.Point(29, 232);
            this.Labe_Contra.Name = "Labe_Contra";
            this.Labe_Contra.Size = new System.Drawing.Size(101, 17);
            this.Labe_Contra.TabIndex = 5;
            this.Labe_Contra.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // But_LimUsCon
            // 
            this.But_LimUsCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.But_LimUsCon.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_LimUsCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.But_LimUsCon.Location = new System.Drawing.Point(160, 325);
            this.But_LimUsCon.Name = "But_LimUsCon";
            this.But_LimUsCon.Size = new System.Drawing.Size(111, 35);
            this.But_LimUsCon.TabIndex = 7;
            this.But_LimUsCon.Text = "LIMPIAR";
            this.But_LimUsCon.UseVisualStyleBackColor = false;
            this.But_LimUsCon.Click += new System.EventHandler(this.But_LimUsCon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ingresar usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InicioSesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(453, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.But_LimUsCon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Labe_Contra);
            this.Controls.Add(this.Lab_Usuari);
            this.Controls.Add(this.texb_Usuario);
            this.Controls.Add(this.Tex_Pass);
            this.Controls.Add(this.But_CancelInSe);
            this.Controls.Add(this.but_InicioSecion);
            this.Name = "InicioSesi";
            this.Text = "Inicio Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_InicioSecion;
        private System.Windows.Forms.Button But_CancelInSe;
        private System.Windows.Forms.TextBox Tex_Pass;
        private System.Windows.Forms.TextBox texb_Usuario;
        private System.Windows.Forms.Label Lab_Usuari;
        private System.Windows.Forms.Label Labe_Contra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button But_LimUsCon;
        private System.Windows.Forms.Button button1;
    }
}

