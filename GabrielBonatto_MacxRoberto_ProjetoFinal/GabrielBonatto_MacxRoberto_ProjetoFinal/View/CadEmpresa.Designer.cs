namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class CadEmpresa {
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
      System.Windows.Forms.Label idLabel;
      System.Windows.Forms.Label rAZAOSOCIALLabel;
      System.Windows.Forms.Label cNPJLabel;
      System.Windows.Forms.Label fONELabel;
      this.button1 = new System.Windows.Forms.Button();
      this.projetoFinalDataSetCadEmpresa = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetCadEmpresa();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.eMPRESATableAdapter = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetCadEmpresaTableAdapters.EMPRESATableAdapter();
      this.tableAdapterManager = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetCadEmpresaTableAdapters.TableAdapterManager();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.rAZAOSOCIALTextBox = new System.Windows.Forms.TextBox();
      this.cNPJTextBox = new System.Windows.Forms.TextBox();
      this.fONETextBox = new System.Windows.Forms.TextBox();
      idLabel = new System.Windows.Forms.Label();
      rAZAOSOCIALLabel = new System.Windows.Forms.Label();
      cNPJLabel = new System.Windows.Forms.Label();
      fONELabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetCadEmpresa)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 129);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Salvar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // projetoFinalDataSetCadEmpresa
      // 
      this.projetoFinalDataSetCadEmpresa.DataSetName = "ProjetoFinalDataSetCadEmpresa";
      this.projetoFinalDataSetCadEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // eMPRESABindingSource
      // 
      this.eMPRESABindingSource.DataMember = "EMPRESA";
      this.eMPRESABindingSource.DataSource = this.projetoFinalDataSetCadEmpresa;
      // 
      // eMPRESATableAdapter
      // 
      this.eMPRESATableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.EMPRESATableAdapter = this.eMPRESATableAdapter;
      this.tableAdapterManager.UpdateOrder = GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetCadEmpresaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // idLabel
      // 
      idLabel.AutoSize = true;
      idLabel.Location = new System.Drawing.Point(12, 9);
      idLabel.Name = "idLabel";
      idLabel.Size = new System.Drawing.Size(19, 13);
      idLabel.TabIndex = 6;
      idLabel.Text = "Id:";
      // 
      // idTextBox
      // 
      this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "Id", true));
      this.idTextBox.Location = new System.Drawing.Point(103, 6);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.ReadOnly = true;
      this.idTextBox.Size = new System.Drawing.Size(315, 20);
      this.idTextBox.TabIndex = 7;
      // 
      // rAZAOSOCIALLabel
      // 
      rAZAOSOCIALLabel.AutoSize = true;
      rAZAOSOCIALLabel.Location = new System.Drawing.Point(12, 35);
      rAZAOSOCIALLabel.Name = "rAZAOSOCIALLabel";
      rAZAOSOCIALLabel.Size = new System.Drawing.Size(85, 13);
      rAZAOSOCIALLabel.TabIndex = 8;
      rAZAOSOCIALLabel.Text = "RAZAOSOCIAL:";
      // 
      // rAZAOSOCIALTextBox
      // 
      this.rAZAOSOCIALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "RAZAOSOCIAL", true));
      this.rAZAOSOCIALTextBox.Location = new System.Drawing.Point(103, 32);
      this.rAZAOSOCIALTextBox.Name = "rAZAOSOCIALTextBox";
      this.rAZAOSOCIALTextBox.Size = new System.Drawing.Size(315, 20);
      this.rAZAOSOCIALTextBox.TabIndex = 9;
      // 
      // cNPJLabel
      // 
      cNPJLabel.AutoSize = true;
      cNPJLabel.Location = new System.Drawing.Point(12, 61);
      cNPJLabel.Name = "cNPJLabel";
      cNPJLabel.Size = new System.Drawing.Size(37, 13);
      cNPJLabel.TabIndex = 10;
      cNPJLabel.Text = "CNPJ:";
      // 
      // cNPJTextBox
      // 
      this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "CNPJ", true));
      this.cNPJTextBox.Location = new System.Drawing.Point(103, 58);
      this.cNPJTextBox.Name = "cNPJTextBox";
      this.cNPJTextBox.Size = new System.Drawing.Size(315, 20);
      this.cNPJTextBox.TabIndex = 11;
      // 
      // fONELabel
      // 
      fONELabel.AutoSize = true;
      fONELabel.Location = new System.Drawing.Point(12, 87);
      fONELabel.Name = "fONELabel";
      fONELabel.Size = new System.Drawing.Size(39, 13);
      fONELabel.TabIndex = 12;
      fONELabel.Text = "FONE:";
      // 
      // fONETextBox
      // 
      this.fONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "FONE", true));
      this.fONETextBox.Location = new System.Drawing.Point(103, 84);
      this.fONETextBox.Name = "fONETextBox";
      this.fONETextBox.Size = new System.Drawing.Size(315, 20);
      this.fONETextBox.TabIndex = 13;
      // 
      // CadEmpresa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(442, 166);
      this.Controls.Add(idLabel);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(rAZAOSOCIALLabel);
      this.Controls.Add(this.rAZAOSOCIALTextBox);
      this.Controls.Add(cNPJLabel);
      this.Controls.Add(this.cNPJTextBox);
      this.Controls.Add(fONELabel);
      this.Controls.Add(this.fONETextBox);
      this.Controls.Add(this.button1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "CadEmpresa";
      this.Text = "Empresa";
      this.Load += new System.EventHandler(this.CadEmpresa_Load);
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetCadEmpresa)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
    private System.Windows.Forms.Button button1;
    private ProjetoFinalDataSetCadEmpresa projetoFinalDataSetCadEmpresa;
    private System.Windows.Forms.BindingSource bindingSource1;
    private System.Windows.Forms.BindingSource eMPRESABindingSource;
    private ProjetoFinalDataSetCadEmpresaTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
    private ProjetoFinalDataSetCadEmpresaTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.TextBox rAZAOSOCIALTextBox;
    private System.Windows.Forms.TextBox cNPJTextBox;
    private System.Windows.Forms.TextBox fONETextBox;
  }
}