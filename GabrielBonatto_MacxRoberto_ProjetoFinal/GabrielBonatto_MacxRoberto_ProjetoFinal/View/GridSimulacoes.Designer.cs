namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class GridSimulacoes {
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
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).BeginInit();
      this.SuspendLayout();
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
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(844, 385);
      this.dataGridView1.TabIndex = 0;
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
      // 
      // custoFixoTotalDataGridViewTextBoxColumn
      // 
      this.custoFixoTotalDataGridViewTextBoxColumn.DataPropertyName = "CustoFixoTotal";
      this.custoFixoTotalDataGridViewTextBoxColumn.HeaderText = "CustoFixoTotal";
      this.custoFixoTotalDataGridViewTextBoxColumn.Name = "custoFixoTotalDataGridViewTextBoxColumn";
      // 
      // custoVarUnitDataGridViewTextBoxColumn
      // 
      this.custoVarUnitDataGridViewTextBoxColumn.DataPropertyName = "CustoVarUnit";
      this.custoVarUnitDataGridViewTextBoxColumn.HeaderText = "CustoVarUnit";
      this.custoVarUnitDataGridViewTextBoxColumn.Name = "custoVarUnitDataGridViewTextBoxColumn";
      // 
      // precoUnitDataGridViewTextBoxColumn
      // 
      this.precoUnitDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnit";
      this.precoUnitDataGridViewTextBoxColumn.HeaderText = "PrecoUnit";
      this.precoUnitDataGridViewTextBoxColumn.Name = "precoUnitDataGridViewTextBoxColumn";
      // 
      // qtdeVendaInicialDataGridViewTextBoxColumn
      // 
      this.qtdeVendaInicialDataGridViewTextBoxColumn.DataPropertyName = "QtdeVendaInicial";
      this.qtdeVendaInicialDataGridViewTextBoxColumn.HeaderText = "QtdeVendaInicial";
      this.qtdeVendaInicialDataGridViewTextBoxColumn.Name = "qtdeVendaInicialDataGridViewTextBoxColumn";
      // 
      // qtdeVendaFinalDataGridViewTextBoxColumn
      // 
      this.qtdeVendaFinalDataGridViewTextBoxColumn.DataPropertyName = "QtdeVendaFinal";
      this.qtdeVendaFinalDataGridViewTextBoxColumn.HeaderText = "QtdeVendaFinal";
      this.qtdeVendaFinalDataGridViewTextBoxColumn.Name = "qtdeVendaFinalDataGridViewTextBoxColumn";
      // 
      // incrementounitDataGridViewTextBoxColumn
      // 
      this.incrementounitDataGridViewTextBoxColumn.DataPropertyName = "Incrementounit";
      this.incrementounitDataGridViewTextBoxColumn.HeaderText = "Incrementounit";
      this.incrementounitDataGridViewTextBoxColumn.Name = "incrementounitDataGridViewTextBoxColumn";
      // 
      // empresaIdDataGridViewTextBoxColumn
      // 
      this.empresaIdDataGridViewTextBoxColumn.DataPropertyName = "EmpresaId";
      this.empresaIdDataGridViewTextBoxColumn.HeaderText = "EmpresaId";
      this.empresaIdDataGridViewTextBoxColumn.Name = "empresaIdDataGridViewTextBoxColumn";
      // 
      // GridSimulacoes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(844, 385);
      this.Controls.Add(this.dataGridView1);
      this.Name = "GridSimulacoes";
      this.Text = "GridSimulacoes";
      this.Load += new System.EventHandler(this.GridSimulacoes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

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
  }
}