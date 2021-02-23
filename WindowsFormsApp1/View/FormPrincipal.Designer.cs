namespace SistemaVendas.View
{
    partial class FormPrincipal
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
            this.mmPrincipal = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinatarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmPrincipal
            // 
            this.mmPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.mmPrincipal.Font = new System.Drawing.Font("Calibri", 14F);
            this.mmPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mmPrincipal.Name = "mmPrincipal";
            this.mmPrincipal.Size = new System.Drawing.Size(1349, 37);
            this.mmPrincipal.TabIndex = 0;
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(113, 33);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(137, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.destinatarioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(124, 33);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaSaldoToolStripMenuItem,
            this.cadastrarContaToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(131, 33);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // consultaSaldoToolStripMenuItem
            // 
            this.consultaSaldoToolStripMenuItem.Name = "consultaSaldoToolStripMenuItem";
            this.consultaSaldoToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.consultaSaldoToolStripMenuItem.Text = "Consulta Saldo";
            this.consultaSaldoToolStripMenuItem.Click += new System.EventHandler(this.ConsultaSaldoToolStripMenuItem_Click);
            // 
            // cadastrarContaToolStripMenuItem
            // 
            this.cadastrarContaToolStripMenuItem.Name = "cadastrarContaToolStripMenuItem";
            this.cadastrarContaToolStripMenuItem.Size = new System.Drawing.Size(259, 34);
            this.cadastrarContaToolStripMenuItem.Text = "Cadastrar Conta";
            this.cadastrarContaToolStripMenuItem.Click += new System.EventHandler(this.CadastrarContaToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(186, 33);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.VendasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(85, 33);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // destinatarioToolStripMenuItem
            // 
            this.destinatarioToolStripMenuItem.Name = "destinatarioToolStripMenuItem";
            this.destinatarioToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.destinatarioToolStripMenuItem.Text = "Destinatário";
            this.destinatarioToolStripMenuItem.Click += new System.EventHandler(this.DestinatarioToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1349, 718);
            this.Controls.Add(this.mmPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mmPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MinimumSize = new System.Drawing.Size(1092, 633);
            this.Name = "FormPrincipal";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Sistema Gerencial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mmPrincipal.ResumeLayout(false);
            this.mmPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinatarioToolStripMenuItem;
    }
}

