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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.sIMULACOESBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.projetoFinalDataSet = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSet();
      this.sIMULACOESTableAdapter = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetTableAdapters.SIMULACOESTableAdapter();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CustoFixoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CustoVarUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PrecoUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.QtdeVendaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.QtdeVendaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Incrementounit = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.empresaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustoFixoTotal,
            this.CustoVarUnit,
            this.PrecoUnit,
            this.QtdeVendaInicial,
            this.QtdeVendaFinal,
            this.Incrementounit,
            this.empresaIdDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.sIMULACOESBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(844, 385);
      this.dataGridView1.TabIndex = 0;
      this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
      // 
      // sIMULACOESBindingSource
      // 
      this.sIMULACOESBindingSource.DataMember = "SIMULACOES";
      this.sIMULACOESBindingSource.DataSource = this.projetoFinalDataSet;
      // 
      // projetoFinalDataSet
      // 
      this.projetoFinalDataSet.DataSetName = "ProjetoFinalDataSet";
      this.projetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // sIMULACOESTableAdapter
      // 
      this.sIMULACOESTableAdapter.ClearBeforeFill = true;
      // 
      // Id
      // 
      this.Id.DataPropertyName = "Id";
      dataGridViewCellStyle8.Format = "N0";
      dataGridViewCellStyle8.NullValue = "0";
      this.Id.DefaultCellStyle = dataGridViewCellStyle8;
      this.Id.HeaderText = "Id";
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      // 
      // CustoFixoTotal
      // 
      this.CustoFixoTotal.DataPropertyName = "CustoFixoTotal";
      dataGridViewCellStyle9.Format = "N2";
      dataGridViewCellStyle9.NullValue = "0";
      this.CustoFixoTotal.DefaultCellStyle = dataGridViewCellStyle9;
      this.CustoFixoTotal.HeaderText = "CustoFixoTotal";
      this.CustoFixoTotal.Name = "CustoFixoTotal";
      // 
      // CustoVarUnit
      // 
      this.CustoVarUnit.DataPropertyName = "CustoVarUnit";
      dataGridViewCellStyle10.Format = "N2";
      dataGridViewCellStyle10.NullValue = "1";
      this.CustoVarUnit.DefaultCellStyle = dataGridViewCellStyle10;
      this.CustoVarUnit.HeaderText = "CustoVarUnit";
      this.CustoVarUnit.Name = "CustoVarUnit";
      // 
      // PrecoUnit
      // 
      this.PrecoUnit.DataPropertyName = "PrecoUnit";
      dataGridViewCellStyle11.Format = "N2";
      dataGridViewCellStyle11.NullValue = "1";
      this.PrecoUnit.DefaultCellStyle = dataGridViewCellStyle11;
      this.PrecoUnit.HeaderText = "PrecoUnit";
      this.PrecoUnit.Name = "PrecoUnit";
      // 
      // QtdeVendaInicial
      // 
      this.QtdeVendaInicial.DataPropertyName = "QtdeVendaInicial";
      dataGridViewCellStyle12.Format = "N0";
      dataGridViewCellStyle12.NullValue = "0";
      this.QtdeVendaInicial.DefaultCellStyle = dataGridViewCellStyle12;
      this.QtdeVendaInicial.HeaderText = "QtdeVendaInicial";
      this.QtdeVendaInicial.Name = "QtdeVendaInicial";
      // 
      // QtdeVendaFinal
      // 
      this.QtdeVendaFinal.DataPropertyName = "QtdeVendaFinal";
      dataGridViewCellStyle13.Format = "N0";
      dataGridViewCellStyle13.NullValue = "1";
      this.QtdeVendaFinal.DefaultCellStyle = dataGridViewCellStyle13;
      this.QtdeVendaFinal.HeaderText = "QtdeVendaFinal";
      this.QtdeVendaFinal.Name = "QtdeVendaFinal";
      // 
      // Incrementounit
      // 
      this.Incrementounit.DataPropertyName = "Incrementounit";
      dataGridViewCellStyle14.Format = "N0";
      dataGridViewCellStyle14.NullValue = "1";
      this.Incrementounit.DefaultCellStyle = dataGridViewCellStyle14;
      this.Incrementounit.HeaderText = "Incrementounit";
      this.Incrementounit.Name = "Incrementounit";
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
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private ProjetoFinalDataSet projetoFinalDataSet;
    private System.Windows.Forms.BindingSource sIMULACOESBindingSource;
    private ProjetoFinalDataSetTableAdapters.SIMULACOESTableAdapter sIMULACOESTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn CustoFixoTotal;
    private System.Windows.Forms.DataGridViewTextBoxColumn CustoVarUnit;
    private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnit;
    private System.Windows.Forms.DataGridViewTextBoxColumn QtdeVendaInicial;
    private System.Windows.Forms.DataGridViewTextBoxColumn QtdeVendaFinal;
    private System.Windows.Forms.DataGridViewTextBoxColumn Incrementounit;
    private System.Windows.Forms.DataGridViewTextBoxColumn empresaIdDataGridViewTextBoxColumn;
  }
}