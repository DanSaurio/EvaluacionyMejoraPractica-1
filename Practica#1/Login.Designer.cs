namespace Practica_1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            System.Windows.Forms.PictureBox pictureBoxUsuario;
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTituloLogin = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.IconoCerrarLogin = new System.Windows.Forms.Button();
            pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(479, 809);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(292, 92);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "    Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(96, 809);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(292, 92);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "    Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTituloLogin
            // 
            this.txtTituloLogin.AutoSize = true;
            this.txtTituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.txtTituloLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTituloLogin.Location = new System.Drawing.Point(352, 35);
            this.txtTituloLogin.Name = "txtTituloLogin";
            this.txtTituloLogin.Size = new System.Drawing.Size(191, 61);
            this.txtTituloLogin.TabIndex = 2;
            this.txtTituloLogin.Text = "LOGIN";
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            pictureBoxUsuario.Location = new System.Drawing.Point(317, 165);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new System.Drawing.Size(256, 256);
            pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxUsuario.TabIndex = 3;
            pictureBoxUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(196, 594);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(151, 40);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(353, 604);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(324, 30);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(353, 665);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(324, 30);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(134, 655);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 40);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Contraseña:";
            // 
            // IconoCerrarLogin
            // 
            this.IconoCerrarLogin.FlatAppearance.BorderSize = 0;
            this.IconoCerrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.IconoCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconoCerrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconoCerrarLogin.ForeColor = System.Drawing.Color.White;
            this.IconoCerrarLogin.Image = ((System.Drawing.Image)(resources.GetObject("IconoCerrarLogin.Image")));
            this.IconoCerrarLogin.Location = new System.Drawing.Point(824, 2);
            this.IconoCerrarLogin.Name = "IconoCerrarLogin";
            this.IconoCerrarLogin.Size = new System.Drawing.Size(35, 33);
            this.IconoCerrarLogin.TabIndex = 8;
            this.IconoCerrarLogin.UseVisualStyleBackColor = true;
            this.IconoCerrarLogin.Click += new System.EventHandler(this.IconoCerrarLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(859, 1006);
            this.Controls.Add(this.IconoCerrarLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(pictureBoxUsuario);
            this.Controls.Add(this.txtTituloLogin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(859, 1006);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label txtTituloLogin;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Button IconoCerrarLogin;
    }
}