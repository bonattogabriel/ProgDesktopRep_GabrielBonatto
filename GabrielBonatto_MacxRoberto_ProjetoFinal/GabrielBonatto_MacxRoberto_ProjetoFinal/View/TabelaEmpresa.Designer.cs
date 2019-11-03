namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class TabelaEmpresa {
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
      this.components = new System.ComponentModel.Container();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.projetoFinalDataSetEmpresa = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetEmpresa();
      this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.eMPRESATableAdapter = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetEmpresaTableAdapters.EMPRESATableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rAZAOSOCIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetEmpresa)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rAZAOSOCIALDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.fONEDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.eMPRESABindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(1, 2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(507, 258);
      this.dataGridView1.TabIndex = 0;
      // 
      // projetoFinalDataSetEmpresa
      // 
      this.projetoFinalDataSetEmpresa.DataSetName = "ProjetoFinalDataSetEmpresa";
      this.projetoFinalDataSetEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // eMPRESABindingSource
      // 
      this.eMPRESABindingSource.DataMember = "EMPRESA";
      this.eMPRESABindingSource.DataSource = this.projetoFinalDataSetEmpresa;
      // 
      // eMPRESATableAdapter
      // 
      this.eMPRESATableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      this.idDataGridViewTextBoxColumn.Width = 40;
      // 
      // rAZAOSOCIALDataGridViewTextBoxColumn
      // 
      this.rAZAOSOCIALDataGridViewTextBoxColumn.DataPropertyName = "RAZAOSOCIAL";
      this.rAZAOSOCIALDataGridViewTextBoxColumn.HeaderText = "RAZAOSOCIAL";
      this.rAZAOSOCIALDataGridViewTextBoxColumn.Name = "rAZAOSOCIALDataGridViewTextBoxColumn";
      this.rAZAOSOCIALDataGridViewTextBoxColumn.Width = 180;
      // 
      // cNPJDataGridViewTextBoxColumn
      // 
      this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
      this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
      this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
      this.cNPJDataGridViewTextBoxColumn.Width = 120;
      // 
      // fONEDataGridViewTextBoxColumn
      // 
      this.fONEDataGridViewTextBoxColumn.DataPropertyName = "FONE";
      this.fONEDataGridViewTextBoxColumn.HeaderText = "FONE";
      this.fONEDataGridViewTextBoxColumn.Name = "fONEDataGridViewTextBoxColumn";
      this.fONEDataGridViewTextBoxColumn.Width = 120;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 280);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Novo";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(106, 280);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Alterar";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // TabelaEmpresa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(509, 315);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "TabelaEmpresa";
      this.Text = "TabelaEmpresa";
      this.Load += new System.EventHandler(this.TabelaEmpresa_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetEmpresa)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private ProjetoFinalDataSetEmpresa projetoFinalDataSetEmpresa;
    private System.Windows.Forms.BindingSource eMPRESABindingSource;
    private ProjetoFinalDataSetEmpresaTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn rAZAOSOCIALDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fONEDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}