namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class TabelaSimulacoes {
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
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.projetoFinalDataSet = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSet();
      this.sIMULACOESBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.sIMULACOESTableAdapter = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetTableAdapters.SIMULACOESTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.custoFixoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.custoVarUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.precoUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.qtdeVendaInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.qtdeVendaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.incrementounitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.empresaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(438, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(82, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Novo";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.custoFixoTotalDataGridViewTextBoxColumn,
            this.custoVarUnitDataGridViewTextBoxColumn,
            this.precoUnitDataGridViewTextBoxColumn,
            this.qtdeVendaInicialDataGridViewTextBoxColumn,
            this.qtdeVendaFinalDataGridViewTextBoxColumn,
            this.incrementounitDataGridViewTextBoxColumn,
            this.empresaIdDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.sIMULACOESBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(1, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(423, 286);
      this.dataGridView1.TabIndex = 2;
      // 
      // projetoFinalDataSet
      // 
      this.projetoFinalDataSet.DataSetName = "ProjetoFinalDataSet";
      this.projetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // sIMULACOESBindingSource
      // 
      this.sIMULACOESBindingSource.DataMember = "SIMULACOES";
      this.sIMULACOESBindingSource.DataSource = this.projetoFinalDataSet;
      // 
      // sIMULACOESTableAdapter
      // 
      this.sIMULACOESTableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      this.idDataGridViewTextBoxColumn.Width = 40;
      // 
      // custoFixoTotalDataGridViewTextBoxColumn
      // 
      this.custoFixoTotalDataGridViewTextBoxColumn.DataPropertyName = "CustoFixoTotal";
      this.custoFixoTotalDataGridViewTextBoxColumn.HeaderText = "CustoFixoTotal";
      this.custoFixoTotalDataGridViewTextBoxColumn.Name = "custoFixoTotalDataGridViewTextBoxColumn";
      this.custoFixoTotalDataGridViewTextBoxColumn.Width = 60;
      // 
      // custoVarUnitDataGridViewTextBoxColumn
      // 
      this.custoVarUnitDataGridViewTextBoxColumn.DataPropertyName = "CustoVarUnit";
      this.custoVarUnitDataGridViewTextBoxColumn.HeaderText = "CustoVarUnit";
      this.custoVarUnitDataGridViewTextBoxColumn.Name = "custoVarUnitDataGridViewTextBoxColumn";
      this.custoVarUnitDataGridViewTextBoxColumn.Width = 60;
      // 
      // precoUnitDataGridViewTextBoxColumn
      // 
      this.precoUnitDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnit";
      this.precoUnitDataGridViewTextBoxColumn.HeaderText = "PrecoUnit";
      this.precoUnitDataGridViewTextBoxColumn.Name = "precoUnitDataGridViewTextBoxColumn";
      this.precoUnitDataGridViewTextBoxColumn.Width = 60;
      // 
      // qtdeVendaInicialDataGridViewTextBoxColumn
      // 
      this.qtdeVendaInicialDataGridViewTextBoxColumn.DataPropertyName = "QtdeVendaInicial";
      this.qtdeVendaInicialDataGridViewTextBoxColumn.HeaderText = "QtdeVendaInicial";
      this.qtdeVendaInicialDataGridViewTextBoxColumn.Name = "qtdeVendaInicialDataGridViewTextBoxColumn";
      this.qtdeVendaInicialDataGridViewTextBoxColumn.Width = 40;
      // 
      // qtdeVendaFinalDataGridViewTextBoxColumn
      // 
      this.qtdeVendaFinalDataGridViewTextBoxColumn.DataPropertyName = "QtdeVendaFinal";
      this.qtdeVendaFinalDataGridViewTextBoxColumn.HeaderText = "QtdeVendaFinal";
      this.qtdeVendaFinalDataGridViewTextBoxColumn.Name = "qtdeVendaFinalDataGridViewTextBoxColumn";
      this.qtdeVendaFinalDataGridViewTextBoxColumn.Width = 40;
      // 
      // incrementounitDataGridViewTextBoxColumn
      // 
      this.incrementounitDataGridViewTextBoxColumn.DataPropertyName = "Incrementounit";
      this.incrementounitDataGridViewTextBoxColumn.HeaderText = "Incrementounit";
      this.incrementounitDataGridViewTextBoxColumn.Name = "incrementounitDataGridViewTextBoxColumn";
      this.incrementounitDataGridViewTextBoxColumn.Width = 40;
      // 
      // empresaIdDataGridViewTextBoxColumn
      // 
      this.empresaIdDataGridViewTextBoxColumn.DataPropertyName = "EmpresaId";
      this.empresaIdDataGridViewTextBoxColumn.HeaderText = "EmpresaId";
      this.empresaIdDataGridViewTextBoxColumn.Name = "empresaIdDataGridViewTextBoxColumn";
      this.empresaIdDataGridViewTextBoxColumn.Width = 40;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(438, 51);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(82, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "Alterar";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // TabelaSimulacoes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 296);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Name = "TabelaSimulacoes";
      this.Text = "Simulações";
      this.Load += new System.EventHandler(this.TabelaSimulacoes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private ProjetoFinalDataSet projetoFinalDataSet;
    private System.Windows.Forms.BindingSource sIMULACOESBindingSource;
    private ProjetoFinalDataSetTableAdapters.SIMULACOESTableAdapter sIMULACOESTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn custoFixoTotalDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn custoVarUnitDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn precoUnitDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn qtdeVendaInicialDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn qtdeVendaFinalDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn incrementounitDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn empresaIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button button2;
  }
}