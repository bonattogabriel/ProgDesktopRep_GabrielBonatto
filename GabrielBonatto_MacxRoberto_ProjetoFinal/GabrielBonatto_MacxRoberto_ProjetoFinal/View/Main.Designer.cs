namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class Main {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.simulaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pontoDeEquilibrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.visualizarTabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pontoDeEquilibrioToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // cadastroToolStripMenuItem
      // 
      this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.simulaçõesToolStripMenuItem});
      this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
      this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
      this.cadastroToolStripMenuItem.Text = "Cadastro";
      // 
      // empresaToolStripMenuItem
      // 
      this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
      this.empresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.empresaToolStripMenuItem.Text = "Empresa";
      this.empresaToolStripMenuItem.Click += new System.EventHandler(this.EmpresaToolStripMenuItem_Click);
      // 
      // simulaçõesToolStripMenuItem
      // 
      this.simulaçõesToolStripMenuItem.Name = "simulaçõesToolStripMenuItem";
      this.simulaçõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.simulaçõesToolStripMenuItem.Text = "Simulações";
      this.simulaçõesToolStripMenuItem.Click += new System.EventHandler(this.SimulaçõesToolStripMenuItem_Click);
      // 
      // pontoDeEquilibrioToolStripMenuItem
      // 
      this.pontoDeEquilibrioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarTabelaToolStripMenuItem});
      this.pontoDeEquilibrioToolStripMenuItem.Name = "pontoDeEquilibrioToolStripMenuItem";
      this.pontoDeEquilibrioToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
      this.pontoDeEquilibrioToolStripMenuItem.Text = "Ponto de Equilibrio";
      // 
      // visualizarTabelaToolStripMenuItem
      // 
      this.visualizarTabelaToolStripMenuItem.Name = "visualizarTabelaToolStripMenuItem";
      this.visualizarTabelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.visualizarTabelaToolStripMenuItem.Text = "Visualizar Tabela";
      this.visualizarTabelaToolStripMenuItem.Click += new System.EventHandler(this.VisualizarTabelaToolStripMenuItem_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Main";
      this.RightToLeftLayout = true;
      this.Text = "Cadastro";
      this.Load += new System.EventHandler(this.Main_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem simulaçõesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pontoDeEquilibrioToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem visualizarTabelaToolStripMenuItem;
  }
}