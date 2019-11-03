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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEmpresa));
      System.Windows.Forms.Label idLabel;
      System.Windows.Forms.Label rAZAOSOCIALLabel;
      System.Windows.Forms.Label cNPJLabel;
      System.Windows.Forms.Label fONELabel;
      this.button1 = new System.Windows.Forms.Button();
      this.projetoFinalDataSetGeral = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeral();
      this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.eMPRESATableAdapter = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeralTableAdapters.EMPRESATableAdapter();
      this.tableAdapterManager = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeralTableAdapters.TableAdapterManager();
      this.eMPRESABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.eMPRESABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.idTextBox = new System.Windows.Forms.TextBox();
      this.rAZAOSOCIALTextBox = new System.Windows.Forms.TextBox();
      this.cNPJTextBox = new System.Windows.Forms.TextBox();
      this.fONETextBox = new System.Windows.Forms.TextBox();
      idLabel = new System.Windows.Forms.Label();
      rAZAOSOCIALLabel = new System.Windows.Forms.Label();
      cNPJLabel = new System.Windows.Forms.Label();
      fONELabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetGeral)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingNavigator)).BeginInit();
      this.eMPRESABindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 158);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Salvar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // projetoFinalDataSetGeral
      // 
      this.projetoFinalDataSetGeral.DataSetName = "ProjetoFinalDataSetGeral";
      this.projetoFinalDataSetGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // eMPRESABindingSource
      // 
      this.eMPRESABindingSource.DataMember = "EMPRESA";
      this.eMPRESABindingSource.DataSource = this.projetoFinalDataSetGeral;
      // 
      // eMPRESATableAdapter
      // 
      this.eMPRESATableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.EMPRESATableAdapter = this.eMPRESATableAdapter;
      this.tableAdapterManager.SIMULACOESTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeralTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // eMPRESABindingNavigator
      // 
      this.eMPRESABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.eMPRESABindingNavigator.BindingSource = this.eMPRESABindingSource;
      this.eMPRESABindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.eMPRESABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.eMPRESABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.eMPRESABindingNavigatorSaveItem});
      this.eMPRESABindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.eMPRESABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.eMPRESABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.eMPRESABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.eMPRESABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.eMPRESABindingNavigator.Name = "eMPRESABindingNavigator";
      this.eMPRESABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.eMPRESABindingNavigator.Size = new System.Drawing.Size(442, 25);
      this.eMPRESABindingNavigator.TabIndex = 7;
      this.eMPRESABindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Posição";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorMoveLastItem.Text = "Mover último";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
      this.bindingNavigatorDeleteItem.Text = "Excluir";
      // 
      // eMPRESABindingNavigatorSaveItem
      // 
      this.eMPRESABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.eMPRESABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPRESABindingNavigatorSaveItem.Image")));
      this.eMPRESABindingNavigatorSaveItem.Name = "eMPRESABindingNavigatorSaveItem";
      this.eMPRESABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.eMPRESABindingNavigatorSaveItem.Text = "Salvar Dados";
      this.eMPRESABindingNavigatorSaveItem.Click += new System.EventHandler(this.EMPRESABindingNavigatorSaveItem_Click);
      // 
      // idLabel
      // 
      idLabel.AutoSize = true;
      idLabel.Location = new System.Drawing.Point(13, 42);
      idLabel.Name = "idLabel";
      idLabel.Size = new System.Drawing.Size(19, 13);
      idLabel.TabIndex = 7;
      idLabel.Text = "Id:";
      // 
      // idTextBox
      // 
      this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "Id", true));
      this.idTextBox.Location = new System.Drawing.Point(104, 39);
      this.idTextBox.Name = "idTextBox";
      this.idTextBox.Size = new System.Drawing.Size(100, 20);
      this.idTextBox.TabIndex = 8;
      // 
      // rAZAOSOCIALLabel
      // 
      rAZAOSOCIALLabel.AutoSize = true;
      rAZAOSOCIALLabel.Location = new System.Drawing.Point(13, 68);
      rAZAOSOCIALLabel.Name = "rAZAOSOCIALLabel";
      rAZAOSOCIALLabel.Size = new System.Drawing.Size(85, 13);
      rAZAOSOCIALLabel.TabIndex = 9;
      rAZAOSOCIALLabel.Text = "RAZAOSOCIAL:";
      // 
      // rAZAOSOCIALTextBox
      // 
      this.rAZAOSOCIALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "RAZAOSOCIAL", true));
      this.rAZAOSOCIALTextBox.Location = new System.Drawing.Point(104, 65);
      this.rAZAOSOCIALTextBox.Name = "rAZAOSOCIALTextBox";
      this.rAZAOSOCIALTextBox.Size = new System.Drawing.Size(100, 20);
      this.rAZAOSOCIALTextBox.TabIndex = 10;
      // 
      // cNPJLabel
      // 
      cNPJLabel.AutoSize = true;
      cNPJLabel.Location = new System.Drawing.Point(13, 94);
      cNPJLabel.Name = "cNPJLabel";
      cNPJLabel.Size = new System.Drawing.Size(37, 13);
      cNPJLabel.TabIndex = 11;
      cNPJLabel.Text = "CNPJ:";
      // 
      // cNPJTextBox
      // 
      this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "CNPJ", true));
      this.cNPJTextBox.Location = new System.Drawing.Point(104, 91);
      this.cNPJTextBox.Name = "cNPJTextBox";
      this.cNPJTextBox.Size = new System.Drawing.Size(100, 20);
      this.cNPJTextBox.TabIndex = 12;
      // 
      // fONELabel
      // 
      fONELabel.AutoSize = true;
      fONELabel.Location = new System.Drawing.Point(13, 120);
      fONELabel.Name = "fONELabel";
      fONELabel.Size = new System.Drawing.Size(39, 13);
      fONELabel.TabIndex = 13;
      fONELabel.Text = "FONE:";
      // 
      // fONETextBox
      // 
      this.fONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPRESABindingSource, "FONE", true));
      this.fONETextBox.Location = new System.Drawing.Point(104, 117);
      this.fONETextBox.Name = "fONETextBox";
      this.fONETextBox.Size = new System.Drawing.Size(100, 20);
      this.fONETextBox.TabIndex = 14;
      // 
      // CadEmpresa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(442, 216);
      this.Controls.Add(idLabel);
      this.Controls.Add(this.idTextBox);
      this.Controls.Add(rAZAOSOCIALLabel);
      this.Controls.Add(this.rAZAOSOCIALTextBox);
      this.Controls.Add(cNPJLabel);
      this.Controls.Add(this.cNPJTextBox);
      this.Controls.Add(fONELabel);
      this.Controls.Add(this.fONETextBox);
      this.Controls.Add(this.eMPRESABindingNavigator);
      this.Controls.Add(this.button1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "CadEmpresa";
      this.Text = "Empresa";
      this.Load += new System.EventHandler(this.CadEmpresa_Load);
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetGeral)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingNavigator)).EndInit();
      this.eMPRESABindingNavigator.ResumeLayout(false);
      this.eMPRESABindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
    private System.Windows.Forms.Button button1;
    private ProjetoFinalDataSetGeral projetoFinalDataSetGeral;
    private System.Windows.Forms.BindingSource eMPRESABindingSource;
    private ProjetoFinalDataSetGeralTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
    private ProjetoFinalDataSetGeralTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator eMPRESABindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton eMPRESABindingNavigatorSaveItem;
    private System.Windows.Forms.TextBox idTextBox;
    private System.Windows.Forms.TextBox rAZAOSOCIALTextBox;
    private System.Windows.Forms.TextBox cNPJTextBox;
    private System.Windows.Forms.TextBox fONETextBox;
  }
}