using System;

namespace SistemadeAlugueldeVeiculos.Register
{
    partial class Cadastro
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
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.WhatsApp = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textWhatsApp = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItemC = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.textCelular = new System.Windows.Forms.MaskedTextBox();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.textData = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nome.Location = new System.Drawing.Point(34, 127);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(46, 18);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.SystemColors.Desktop;
            this.CPF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CPF.Location = new System.Drawing.Point(34, 161);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(35, 18);
            this.CPF.TabIndex = 2;
            this.CPF.Text = "CPF";
            this.CPF.Click += new System.EventHandler(this.CPF_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.SystemColors.Desktop;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(34, 198);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 18);
            this.Email.TabIndex = 3;
            this.Email.Text = "E-mail";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.BackColor = System.Drawing.SystemColors.Desktop;
            this.Telefone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Telefone.Location = new System.Drawing.Point(34, 233);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(63, 18);
            this.Telefone.TabIndex = 4;
            this.Telefone.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(34, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(34, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data de Nascimento";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.BackColor = System.Drawing.SystemColors.ControlText;
            this.Celular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Celular.Location = new System.Drawing.Point(34, 339);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(51, 18);
            this.Celular.TabIndex = 8;
            this.Celular.Text = "Celular";
            this.Celular.Click += new System.EventHandler(this.Celular_Click);
            // 
            // WhatsApp
            // 
            this.WhatsApp.AutoSize = true;
            this.WhatsApp.BackColor = System.Drawing.SystemColors.Desktop;
            this.WhatsApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatsApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WhatsApp.Location = new System.Drawing.Point(34, 374);
            this.WhatsApp.Name = "WhatsApp";
            this.WhatsApp.Size = new System.Drawing.Size(72, 18);
            this.WhatsApp.TabIndex = 9;
            this.WhatsApp.Text = "WhatsApp";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(102, 127);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 10;
            this.textNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(102, 198);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 13;
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(120, 270);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 15;
            this.textEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEndereco.TextChanged += new System.EventHandler(this.textEndereco_TextChanged);
            // 
            // textWhatsApp
            // 
            this.textWhatsApp.Location = new System.Drawing.Point(127, 374);
            this.textWhatsApp.Name = "textWhatsApp";
            this.textWhatsApp.Size = new System.Drawing.Size(100, 20);
            this.textWhatsApp.TabIndex = 17;
            this.textWhatsApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textWhatsApp.TextChanged += new System.EventHandler(this.textWhatsApp_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(47, 448);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(86, 33);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(47, 60);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 31);
            this.lbTitle.TabIndex = 21;
            this.lbTitle.Text = "Cadastro de Cliente";
            this.lbTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(0, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 29;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItemC,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(327, 29);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItemC
            // 
            this.loginToolStripMenuItemC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginToolStripMenuItemC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginToolStripMenuItemC.Name = "loginToolStripMenuItemC";
            this.loginToolStripMenuItemC.Size = new System.Drawing.Size(65, 25);
            this.loginToolStripMenuItemC.Text = "Login";
            this.loginToolStripMenuItemC.Click += new System.EventHandler(this.loginToolStripMenuItemC_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItemC_Click);
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(102, 161);
            this.textCPF.Mask = "00,000,000,00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(100, 20);
            this.textCPF.TabIndex = 25;
            this.textCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(102, 339);
            this.textCelular.Mask = "00,0000,0000";
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(100, 20);
            this.textCelular.TabIndex = 26;
            this.textCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(115, 232);
            this.textTelefone.Mask = "00 0000,0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(100, 20);
            this.textTelefone.TabIndex = 27;
            this.textTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(189, 448);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 33);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // textData
            // 
            this.textData.Location = new System.Drawing.Point(180, 306);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(135, 20);
            this.textData.TabIndex = 28;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeAlugueldeVeiculos.Properties.Resources.BackgroundM;
            this.ClientSize = new System.Drawing.Size(327, 512);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textWhatsApp);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.WhatsApp);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label WhatsApp;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textWhatsApp;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItemC;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.MaskedTextBox textCelular;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker textData;

        public EventHandler menuToolStripMenuItemCad_Click { get; private set; }
    }
}