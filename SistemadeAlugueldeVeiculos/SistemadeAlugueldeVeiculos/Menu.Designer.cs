namespace SistemadeAlugueldeVeiculos
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.h1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.DataFinal = new System.Windows.Forms.DateTimePicker();
            this.h2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.labelAprov = new System.Windows.Forms.Label();
            this.espcUM = new System.Windows.Forms.ComboBox();
            this.espcDOIS = new System.Windows.Forms.ComboBox();
            this.espcTRES = new System.Windows.Forms.ComboBox();
            this.labelReprov = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.espcQUATRO = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUmVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.h1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h1.Location = new System.Drawing.Point(11, 57);
            this.h1.Margin = new System.Windows.Forms.Padding(0);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(294, 24);
            this.h1.TabIndex = 0;
            this.h1.Text = "Sistema de Aluguel de Veículos";
            this.h1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.h1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMarca.Location = new System.Drawing.Point(43, 123);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(0);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(47, 18);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Text = "Marca";
            this.txtMarca.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtModelo
            // 
            this.txtModelo.AutoSize = true;
            this.txtModelo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtModelo.Location = new System.Drawing.Point(43, 162);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(0);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(55, 18);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Potência";
            this.label3.Click += new System.EventHandler(this.label4_Click);
            // 
            // DataInicio
            // 
            this.DataInicio.CalendarForeColor = System.Drawing.Color.DimGray;
            this.DataInicio.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.DataInicio.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataInicio.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicio.Location = new System.Drawing.Point(134, 366);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(0);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(90, 20);
            this.DataInicio.TabIndex = 5;
            this.DataInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DataFinal
            // 
            this.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFinal.Location = new System.Drawing.Point(134, 404);
            this.DataFinal.Margin = new System.Windows.Forms.Padding(0);
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.Size = new System.Drawing.Size(90, 20);
            this.DataFinal.TabIndex = 6;
            this.DataFinal.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // h2
            // 
            this.h2.AutoSize = true;
            this.h2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.h2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.h2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h2.Location = new System.Drawing.Point(14, 328);
            this.h2.Margin = new System.Windows.Forms.Padding(0);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(292, 17);
            this.h2.TabIndex = 7;
            this.h2.Text = "Perído que quer alugar o veículo escolhido. ";
            this.h2.Click += new System.EventHandler(this.h2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(80, 404);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "FINAL";
            this.label5.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(80, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "INÍCIO";
            this.label4.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerifica.Location = new System.Drawing.Point(158, 453);
            this.btnVerifica.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(87, 32);
            this.btnVerifica.TabIndex = 12;
            this.btnVerifica.Text = "Alugar";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.buttonVerifica_Click);
            // 
            // labelAprov
            // 
            this.labelAprov.AutoSize = true;
            this.labelAprov.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAprov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAprov.Location = new System.Drawing.Point(108, 280);
            this.labelAprov.Margin = new System.Windows.Forms.Padding(0);
            this.labelAprov.Name = "labelAprov";
            this.labelAprov.Size = new System.Drawing.Size(0, 13);
            this.labelAprov.TabIndex = 15;
            // 
            // espcUM
            // 
            this.espcUM.FormattingEnabled = true;
            this.espcUM.Location = new System.Drawing.Point(145, 123);
            this.espcUM.Margin = new System.Windows.Forms.Padding(0);
            this.espcUM.Name = "espcUM";
            this.espcUM.Size = new System.Drawing.Size(124, 21);
            this.espcUM.TabIndex = 16;
            this.espcUM.SelectedIndexChanged += new System.EventHandler(this.espcUM_SelectedIndexChanged);
            // 
            // espcDOIS
            // 
            this.espcDOIS.FormattingEnabled = true;
            this.espcDOIS.Location = new System.Drawing.Point(145, 162);
            this.espcDOIS.Margin = new System.Windows.Forms.Padding(0);
            this.espcDOIS.Name = "espcDOIS";
            this.espcDOIS.Size = new System.Drawing.Size(124, 21);
            this.espcDOIS.TabIndex = 17;
            // 
            // espcTRES
            // 
            this.espcTRES.FormattingEnabled = true;
            this.espcTRES.Location = new System.Drawing.Point(145, 199);
            this.espcTRES.Margin = new System.Windows.Forms.Padding(0);
            this.espcTRES.Name = "espcTRES";
            this.espcTRES.Size = new System.Drawing.Size(124, 21);
            this.espcTRES.TabIndex = 18;
            // 
            // labelReprov
            // 
            this.labelReprov.AutoSize = true;
            this.labelReprov.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReprov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelReprov.Location = new System.Drawing.Point(72, 280);
            this.labelReprov.Margin = new System.Windows.Forms.Padding(0);
            this.labelReprov.Name = "labelReprov";
            this.labelReprov.Size = new System.Drawing.Size(0, 13);
            this.labelReprov.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(43, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cor";
            // 
            // espcQUATRO
            // 
            this.espcQUATRO.FormattingEnabled = true;
            this.espcQUATRO.Location = new System.Drawing.Point(145, 234);
            this.espcQUATRO.Margin = new System.Windows.Forms.Padding(0);
            this.espcQUATRO.Name = "espcQUATRO";
            this.espcQUATRO.Size = new System.Drawing.Size(124, 21);
            this.espcQUATRO.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.pagamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(315, 25);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUmVeículoToolStripMenuItem,
            this.agendarCarroToolStripMenuItem});
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cadastrarUmVeículoToolStripMenuItem
            // 
            this.cadastrarUmVeículoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastrarUmVeículoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastrarUmVeículoToolStripMenuItem.Name = "cadastrarUmVeículoToolStripMenuItem";
            this.cadastrarUmVeículoToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.cadastrarUmVeículoToolStripMenuItem.Text = "Cadastrar um Veículo";
            this.cadastrarUmVeículoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUmVeículoToolStripMenuItem_Click);
            // 
            // agendarCarroToolStripMenuItem
            // 
            this.agendarCarroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.agendarCarroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agendarCarroToolStripMenuItem.Name = "agendarCarroToolStripMenuItem";
            this.agendarCarroToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.agendarCarroToolStripMenuItem.Text = "Agendar Carro ";
            this.agendarCarroToolStripMenuItem.Click += new System.EventHandler(this.agendarCarroToolStripMenuItem_Click);
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro Cliente";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSair.Location = new System.Drawing.Point(65, 453);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 32);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem,
            this.debitToolStripMenuItem});
            this.pagamentoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.creditToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.creditToolStripMenuItem.Text = "Credit";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // debitToolStripMenuItem
            // 
            this.debitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.debitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debitToolStripMenuItem.Name = "debitToolStripMenuItem";
            this.debitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.debitToolStripMenuItem.Text = "Debit";
            this.debitToolStripMenuItem.Click += new System.EventHandler(this.debitToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SistemadeAlugueldeVeiculos.Properties.Resources.BackgroundM;
            this.ClientSize = new System.Drawing.Size(315, 507);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.espcQUATRO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelReprov);
            this.Controls.Add(this.espcTRES);
            this.Controls.Add(this.espcDOIS);
            this.Controls.Add(this.espcUM);
            this.Controls.Add(this.labelAprov);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.DataFinal);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.h1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.DateTimePicker DataFinal;
        private System.Windows.Forms.Label h2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label labelAprov;
        private System.Windows.Forms.ComboBox espcTRES;
        private System.Windows.Forms.ComboBox espcDOIS;
        private System.Windows.Forms.ComboBox espcUM;
        private System.Windows.Forms.Label labelReprov;
        private System.Windows.Forms.ComboBox espcQUATRO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUmVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitToolStripMenuItem;
    }
}

