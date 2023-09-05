namespace SistemadeAlugueldeVeiculos.Register
{
    partial class Pedido
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
            this.h1 = new System.Windows.Forms.Label();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCPF = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.gpBox2 = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnPlaca = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.gpBox3 = new System.Windows.Forms.GroupBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.dataFinal = new System.Windows.Forms.DateTimePicker();
            this.btnData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVeículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBox.SuspendLayout();
            this.gpBox2.SuspendLayout();
            this.gpBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.h1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h1.Location = new System.Drawing.Point(25, 56);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(328, 28);
            this.h1.TabIndex = 0;
            this.h1.Text = "Agendar Carro Para o Cliente";
            this.h1.Click += new System.EventHandler(this.h1_Click);
            // 
            // gpBox
            // 
            this.gpBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpBox.Controls.Add(this.txtNome);
            this.gpBox.Controls.Add(this.btnCPF);
            this.gpBox.Controls.Add(this.txtCPF);
            this.gpBox.Controls.Add(this.lblCPF);
            this.gpBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpBox.Location = new System.Drawing.Point(12, 129);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(357, 61);
            this.gpBox.TabIndex = 1;
            this.gpBox.TabStop = false;
            this.gpBox.Text = "Cliente";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(268, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(83, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnCPF
            // 
            this.btnCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCPF.Location = new System.Drawing.Point(185, 24);
            this.btnCPF.Name = "btnCPF";
            this.btnCPF.Size = new System.Drawing.Size(75, 20);
            this.btnCPF.TabIndex = 3;
            this.btnCPF.Text = "Buscar";
            this.btnCPF.UseVisualStyleBackColor = true;
            this.btnCPF.Click += new System.EventHandler(this.btnCPF_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(95, 24);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(81, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 25);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(33, 13);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF :";
            // 
            // gpBox2
            // 
            this.gpBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpBox2.Controls.Add(this.txtMarca);
            this.gpBox2.Controls.Add(this.btnPlaca);
            this.gpBox2.Controls.Add(this.lblPlaca);
            this.gpBox2.Controls.Add(this.txtPlaca);
            this.gpBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpBox2.Location = new System.Drawing.Point(12, 224);
            this.gpBox2.Name = "gpBox2";
            this.gpBox2.Size = new System.Drawing.Size(357, 63);
            this.gpBox2.TabIndex = 2;
            this.gpBox2.TabStop = false;
            this.gpBox2.Text = "Carro";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(268, 25);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(83, 20);
            this.txtMarca.TabIndex = 5;
            // 
            // btnPlaca
            // 
            this.btnPlaca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlaca.Location = new System.Drawing.Point(185, 25);
            this.btnPlaca.Name = "btnPlaca";
            this.btnPlaca.Size = new System.Drawing.Size(75, 21);
            this.btnPlaca.TabIndex = 4;
            this.btnPlaca.Text = "Buscar";
            this.btnPlaca.UseVisualStyleBackColor = true;
            this.btnPlaca.Click += new System.EventHandler(this.btnPlaca_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(12, 28);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(83, 13);
            this.lblPlaca.TabIndex = 5;
            this.lblPlaca.Text = "Placa do Carro :";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(96, 25);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(83, 20);
            this.txtPlaca.TabIndex = 4;
            // 
            // gpBox3
            // 
            this.gpBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpBox3.Controls.Add(this.lblTempo);
            this.gpBox3.Controls.Add(this.dataInicio);
            this.gpBox3.Controls.Add(this.dataFinal);
            this.gpBox3.Controls.Add(this.btnData);
            this.gpBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpBox3.Location = new System.Drawing.Point(12, 326);
            this.gpBox3.Name = "gpBox3";
            this.gpBox3.Size = new System.Drawing.Size(357, 54);
            this.gpBox3.TabIndex = 0;
            this.gpBox3.TabStop = false;
            this.gpBox3.Text = "Tempo";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(12, 23);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "Prazo :";
            // 
            // dataInicio
            // 
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(100, 19);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(81, 20);
            this.dataInicio.TabIndex = 3;
            // 
            // dataFinal
            // 
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinal.Location = new System.Drawing.Point(187, 19);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(81, 20);
            this.dataFinal.TabIndex = 4;
            // 
            // btnData
            // 
            this.btnData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnData.Location = new System.Drawing.Point(276, 19);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 20);
            this.btnData.TabIndex = 5;
            this.btnData.Text = "Buscar";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.cadastrarVeículoToolStripMenuItem,
            this.pagamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // cadastrarVeículoToolStripMenuItem
            // 
            this.cadastrarVeículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVeículoToolStripMenuItem1,
            this.realizarPedidoToolStripMenuItem});
            this.cadastrarVeículoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cadastrarVeículoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastrarVeículoToolStripMenuItem.Name = "cadastrarVeículoToolStripMenuItem";
            this.cadastrarVeículoToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.cadastrarVeículoToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarVeículoToolStripMenuItem1
            // 
            this.cadastrarVeículoToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastrarVeículoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastrarVeículoToolStripMenuItem1.Name = "cadastrarVeículoToolStripMenuItem1";
            this.cadastrarVeículoToolStripMenuItem1.Size = new System.Drawing.Size(213, 26);
            this.cadastrarVeículoToolStripMenuItem1.Text = "Cadastrar Veículo";
            this.cadastrarVeículoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarVeículoToolStripMenuItem1_Click);
            // 
            // realizarPedidoToolStripMenuItem
            // 
            this.realizarPedidoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.realizarPedidoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            this.realizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.realizarPedidoToolStripMenuItem.Text = "Realizar Pedido";
            this.realizarPedidoToolStripMenuItem.Click += new System.EventHandler(this.realizarPedidoToolStripMenuItem_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem,
            this.debitToolStripMenuItem});
            this.pagamentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
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
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeAlugueldeVeiculos.Properties.Resources.BackgroundM;
            this.ClientSize = new System.Drawing.Size(381, 403);
            this.Controls.Add(this.gpBox3);
            this.Controls.Add(this.gpBox2);
            this.Controls.Add(this.gpBox);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.gpBox2.ResumeLayout(false);
            this.gpBox2.PerformLayout();
            this.gpBox3.ResumeLayout(false);
            this.gpBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.GroupBox gpBox2;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.GroupBox gpBox3;
        private System.Windows.Forms.Button btnCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.DateTimePicker dataFinal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVeículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem realizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitToolStripMenuItem;
    }
}