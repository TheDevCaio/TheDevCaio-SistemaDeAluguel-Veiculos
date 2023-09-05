namespace SistemadeAlugueldeVeiculos.Acess
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
            this.textSenha = new System.Windows.Forms.MaskedTextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.Location = new System.Drawing.Point(49, 284);
            this.textSenha.Mask = "************";
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(192, 30);
            this.textSenha.TabIndex = 0;
            this.textSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textSenha_MaskInputRejected);
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogin.Location = new System.Drawing.Point(49, 159);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(192, 30);
            this.textLogin.TabIndex = 1;
            this.textLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLogin.Location = new System.Drawing.Point(29, 98);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(236, 28);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Informe o seu E-mail";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Snow;
            this.labelPassword.Location = new System.Drawing.Point(40, 224);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(214, 27);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Informe a sua Senha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripLogin,
            this.cadastroToolStripCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripLogin
            // 
            this.loginToolStripLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.loginToolStripLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.loginToolStripLogin.Name = "loginToolStripLogin";
            this.loginToolStripLogin.Size = new System.Drawing.Size(65, 25);
            this.loginToolStripLogin.Text = "Login";
            this.loginToolStripLogin.Click += new System.EventHandler(this.loginToolStripLogin_Click);
            // 
            // cadastroToolStripCadastro
            // 
            this.cadastroToolStripCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastroToolStripCadastro.Name = "cadastroToolStripCadastro";
            this.cadastroToolStripCadastro.Size = new System.Drawing.Size(89, 25);
            this.cadastroToolStripCadastro.Text = "Cadastro";
            this.cadastroToolStripCadastro.Click += new System.EventHandler(this.cadastroToolStripCadastro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(94, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeAlugueldeVeiculos.Properties.Resources.BackgroundM;
            this.ClientSize = new System.Drawing.Size(298, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textSenha;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripCadastro;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripLogin;
        private System.Windows.Forms.Button button1;
    }
}