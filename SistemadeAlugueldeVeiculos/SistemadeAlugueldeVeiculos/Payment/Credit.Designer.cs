namespace SistemadeAlugueldeVeiculos.Payment
{
    partial class Credit
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
            this.dataGridViewCredit = new System.Windows.Forms.DataGridView();
            this.Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h1 = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.textConta = new System.Windows.Forms.TextBox();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUmVeículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCredit
            // 
            this.dataGridViewCredit.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Conta,
            this.Valor});
            this.dataGridViewCredit.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCredit.Location = new System.Drawing.Point(248, 96);
            this.dataGridViewCredit.Name = "dataGridViewCredit";
            this.dataGridViewCredit.Size = new System.Drawing.Size(234, 193);
            this.dataGridViewCredit.TabIndex = 0;
            // 
            // Conta
            // 
            this.Conta.Frozen = true;
            this.Conta.HeaderText = "Conta";
            this.Conta.Name = "Conta";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // h1
            // 
            this.h1.AutoSize = true;
            this.h1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.h1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.h1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.h1.Location = new System.Drawing.Point(5, 96);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(237, 32);
            this.h1.TabIndex = 1;
            this.h1.Text = "Contas a Receber";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConta.Location = new System.Drawing.Point(5, 186);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(83, 31);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblValor.Location = new System.Drawing.Point(5, 258);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(76, 31);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // textConta
            // 
            this.textConta.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConta.ForeColor = System.Drawing.SystemColors.Window;
            this.textConta.Location = new System.Drawing.Point(114, 187);
            this.textConta.Name = "textConta";
            this.textConta.Size = new System.Drawing.Size(114, 29);
            this.textConta.TabIndex = 4;
            this.textConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textValor
            // 
            this.textValor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValor.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textValor.Location = new System.Drawing.Point(114, 260);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(114, 29);
            this.textValor.TabIndex = 5;
            this.textValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(417, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "0,00";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTot.Location = new System.Drawing.Point(248, 330);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(143, 28);
            this.lblTot.TabIndex = 7;
            this.lblTot.Text = "Valor Total :";
            this.lblTot.Click += new System.EventHandler(this.label2_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscar.Location = new System.Drawing.Point(73, 324);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(83, 40);
            this.Buscar.TabIndex = 8;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.pagamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(488, 25);
            this.menuStrip1.TabIndex = 24;
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
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText;
            this.pagamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem,
            this.debitToolStripMenuItem});
            this.pagamentosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(117, 25);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
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
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemadeAlugueldeVeiculos.Properties.Resources.BackgroundM;
            this.ClientSize = new System.Drawing.Size(488, 369);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.textConta);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.dataGridViewCredit);
            this.Name = "Credit";
            this.Text = "Credit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label h1;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox textConta;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUmVeículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitToolStripMenuItem;
    }
}