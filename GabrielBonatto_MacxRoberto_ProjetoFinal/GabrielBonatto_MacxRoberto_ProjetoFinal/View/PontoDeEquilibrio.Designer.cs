namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class PontoDeEquilibrio {
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
      this.projetoFinalDataSet = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSet();
      this.projetoFinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // projetoFinalDataSet
      // 
      this.projetoFinalDataSet.DataSetName = "ProjetoFinalDataSet";
      this.projetoFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // projetoFinalDataSetBindingSource
      // 
      this.projetoFinalDataSetBindingSource.DataSource = this.projetoFinalDataSet;
      this.projetoFinalDataSetBindingSource.Position = 0;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(588, 331);
      this.dataGridView1.TabIndex = 0;
      // 
      // PontoDeEquilibrio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(587, 448);
      this.Controls.Add(this.dataGridView1);
      this.Name = "PontoDeEquilibrio";
      this.Text = "PontoDeEquilibrio";
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private ProjetoFinalDataSet projetoFinalDataSet;
    private System.Windows.Forms.BindingSource projetoFinalDataSetBindingSource;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}