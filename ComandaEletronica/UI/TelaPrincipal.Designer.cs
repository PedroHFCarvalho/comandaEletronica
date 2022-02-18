namespace ComandaEletronica
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGerenciarComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemProdutos,
            this.itemComandas});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // itemProdutos
            // 
            this.itemProdutos.Name = "itemProdutos";
            this.itemProdutos.Size = new System.Drawing.Size(152, 22);
            this.itemProdutos.Text = "Produtos";
            // 
            // itemComandas
            // 
            this.itemComandas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGerenciarComandas});
            this.itemComandas.Name = "itemComandas";
            this.itemComandas.Size = new System.Drawing.Size(152, 22);
            this.itemComandas.Text = "Comandas";
            // 
            // itemGerenciarComandas
            // 
            this.itemGerenciarComandas.Name = "itemGerenciarComandas";
            this.itemGerenciarComandas.Size = new System.Drawing.Size(179, 22);
            this.itemGerenciarComandas.Text = "Gerenciar Comanda";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 329);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comanda Eletrônica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemProdutos;
        private System.Windows.Forms.ToolStripMenuItem itemComandas;
        private System.Windows.Forms.ToolStripMenuItem itemGerenciarComandas;
    }
}

