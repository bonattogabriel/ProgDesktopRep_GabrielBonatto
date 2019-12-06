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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaEmpresa));
      this.projetoFinalDataSetGeral = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeral();
      this.eMPRESA1BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.eMPRESA1TableAdapter = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeralTableAdapters.EMPRESATableAdapter();
      this.tableAdapterManager = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeralTableAdapters.TableAdapterManager();
      this.eMPRESA1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.eMPRESA1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.eMPRESA1DataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetGeral)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESA1BindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESA1BindingNavigator)).BeginInit();
      this.eMPRESA1BindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESA1DataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // projetoFinalDataSetGeral
      // 
      this.projetoFinalDataSetGeral.DataSetName = "ProjetoFinalDataSetGeral";
      this.projetoFinalDataSetGeral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // eMPRESA1BindingSource
      // 
      this.eMPRESA1BindingSource.DataMember = "EMPRESA";
      this.eMPRESA1BindingSource.DataSource = this.projetoFinalDataSetGeral;
      // 
      // eMPRESA1TableAdapter
      // 
      this.eMPRESA1TableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.EMPRESATableAdapter = this.eMPRESA1TableAdapter;
      this.tableAdapterManager.SIMULACOESTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetGeralTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // eMPRESA1BindingNavigator
      // 
      this.eMPRESA1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.eMPRESA1BindingNavigator.BindingSource = this.eMPRESA1BindingSource;
      this.eMPRESA1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.eMPRESA1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.eMPRESA1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eMPRESA1BindingNavigatorSaveItem});
      this.eMPRESA1BindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.eMPRESA1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.eMPRESA1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.eMPRESA1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.eMPRESA1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.eMPRESA1BindingNavigator.Name = "eMPRESA1BindingNavigator";
      this.eMPRESA1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.eMPRESA1BindingNavigator.Size = new System.Drawing.Size(503, 25);
      this.eMPRESA1BindingNavigator.TabIndex = 0;
      this.eMPRESA1BindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
      this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.BindingNavigatorAddNewItem_Click);
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
      this.bindingNavigatorCountItem.Text = "de {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Excluir";
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
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Mover último";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // eMPRESA1BindingNavigatorSaveItem
      // 
      this.eMPRESA1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.eMPRESA1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eMPRESA1BindingNavigatorSaveItem.Image")));
      this.eMPRESA1BindingNavigatorSaveItem.Name = "eMPRESA1BindingNavigatorSaveItem";
      this.eMPRESA1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.eMPRESA1BindingNavigatorSaveItem.Text = "Salvar Dados";
      this.eMPRESA1BindingNavigatorSaveItem.Click += new System.EventHandler(this.EMPRESA1BindingNavigatorSaveItem_Click);
      // 
      // eMPRESA1DataGridView
      // 
      this.eMPRESA1DataGridView.AutoGenerateColumns = false;
      this.eMPRESA1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.eMPRESA1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.eMPRESA1DataGridView.DataSource = this.eMPRESA1BindingSource;
      this.eMPRESA1DataGridView.Location = new System.Drawing.Point(0, 28);
      this.eMPRESA1DataGridView.Name = "eMPRESA1DataGridView";
      this.eMPRESA1DataGridView.Size = new System.Drawing.Size(500, 284);
      this.eMPRESA1DataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "RAZAOSOCIAL";
      this.dataGridViewTextBoxColumn2.HeaderText = "RAZAOSOCIAL";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "CNPJ";
      this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "FONE";
      this.dataGridViewTextBoxColumn4.HeaderText = "FONE";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // TabelaEmpresa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(503, 318);
      this.Controls.Add(this.eMPRESA1DataGridView);
      this.Controls.Add(this.eMPRESA1BindingNavigator);
      this.Name = "TabelaEmpresa";
      this.Text = "TabelaEmpresa";
      this.Load += new System.EventHandler(this.TabelaEmpresa_Load);
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSetGeral)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESA1BindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESA1BindingNavigator)).EndInit();
      this.eMPRESA1BindingNavigator.ResumeLayout(false);
      this.eMPRESA1BindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.eMPRESA1DataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private ProjetoFinalDataSetGeral projetoFinalDataSetGeral;
    private System.Windows.Forms.BindingSource eMPRESA1BindingSource;
    private ProjetoFinalDataSetGeralTableAdapters.EMPRESATableAdapter eMPRESA1TableAdapter;
    private ProjetoFinalDataSetGeralTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator eMPRESA1BindingNavigator;
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
    private System.Windows.Forms.ToolStripButton eMPRESA1BindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView eMPRESA1DataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
  }
}