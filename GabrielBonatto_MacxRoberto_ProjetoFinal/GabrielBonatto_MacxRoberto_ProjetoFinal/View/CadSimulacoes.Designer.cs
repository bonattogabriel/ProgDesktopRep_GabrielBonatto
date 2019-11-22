namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  partial class CadSimulacoes {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadSimulacoes));
      this.projetoFinalDataSet = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSet();
      this.sIMULACOESBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.sIMULACOESTableAdapter = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetTableAdapters.SIMULACOESTableAdapter();
      this.tableAdapterManager = new GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager();
      this.sIMULACOESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.sIMULACOESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.sIMULACOESDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingNavigator)).BeginInit();
      this.sIMULACOESBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESDataGridView)).BeginInit();
      this.SuspendLayout();
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
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.SIMULACOESTableAdapter = this.sIMULACOESTableAdapter;
      this.tableAdapterManager.UpdateOrder = GabrielBonatto_MacxRoberto_ProjetoFinal.ProjetoFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // sIMULACOESBindingNavigator
      // 
      this.sIMULACOESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.sIMULACOESBindingNavigator.BindingSource = this.sIMULACOESBindingSource;
      this.sIMULACOESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.sIMULACOESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.sIMULACOESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sIMULACOESBindingNavigatorSaveItem});
      this.sIMULACOESBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.sIMULACOESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.sIMULACOESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.sIMULACOESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.sIMULACOESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.sIMULACOESBindingNavigator.Name = "sIMULACOESBindingNavigator";
      this.sIMULACOESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.sIMULACOESBindingNavigator.Size = new System.Drawing.Size(849, 25);
      this.sIMULACOESBindingNavigator.TabIndex = 13;
      this.sIMULACOESBindingNavigator.Text = "bindingNavigator1";
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
      // sIMULACOESBindingNavigatorSaveItem
      // 
      this.sIMULACOESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.sIMULACOESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sIMULACOESBindingNavigatorSaveItem.Image")));
      this.sIMULACOESBindingNavigatorSaveItem.Name = "sIMULACOESBindingNavigatorSaveItem";
      this.sIMULACOESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
      this.sIMULACOESBindingNavigatorSaveItem.Text = "Salvar Dados";
      this.sIMULACOESBindingNavigatorSaveItem.Click += new System.EventHandler(this.SIMULACOESBindingNavigatorSaveItem_Click);
      // 
      // sIMULACOESDataGridView
      // 
      this.sIMULACOESDataGridView.AutoGenerateColumns = false;
      this.sIMULACOESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.sIMULACOESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
      this.sIMULACOESDataGridView.DataSource = this.sIMULACOESBindingSource;
      this.sIMULACOESDataGridView.Location = new System.Drawing.Point(1, 28);
      this.sIMULACOESDataGridView.Name = "sIMULACOESDataGridView";
      this.sIMULACOESDataGridView.Size = new System.Drawing.Size(845, 287);
      this.sIMULACOESDataGridView.TabIndex = 13;
      this.sIMULACOESDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SIMULACOESDataGridView_CellContentClick);
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
      this.dataGridViewTextBoxColumn2.DataPropertyName = "CustoFixoTotal";
      this.dataGridViewTextBoxColumn2.HeaderText = "CustoFixoTotal";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "CustoVarUnit";
      this.dataGridViewTextBoxColumn3.HeaderText = "CustoVarUnit";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecoUnit";
      this.dataGridViewTextBoxColumn4.HeaderText = "PrecoUnit";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "QtdeVendaInicial";
      this.dataGridViewTextBoxColumn5.HeaderText = "QtdeVendaInicial";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "QtdeVendaFinal";
      this.dataGridViewTextBoxColumn6.HeaderText = "QtdeVendaFinal";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "Incrementounit";
      this.dataGridViewTextBoxColumn7.HeaderText = "Incrementounit";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "EmpresaId";
      this.dataGridViewTextBoxColumn8.HeaderText = "EmpresaId";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      // 
      // CadSimulacoes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(849, 319);
      this.Controls.Add(this.sIMULACOESDataGridView);
      this.Controls.Add(this.sIMULACOESBindingNavigator);
      this.Name = "CadSimulacoes";
      this.Text = "Cadastro Simulações";
      this.Load += new System.EventHandler(this.CadSimulacoes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.projetoFinalDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESBindingNavigator)).EndInit();
      this.sIMULACOESBindingNavigator.ResumeLayout(false);
      this.sIMULACOESBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.sIMULACOESDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private ProjetoFinalDataSet projetoFinalDataSet;
    private System.Windows.Forms.BindingSource sIMULACOESBindingSource;
    private ProjetoFinalDataSetTableAdapters.SIMULACOESTableAdapter sIMULACOESTableAdapter;
    private ProjetoFinalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator sIMULACOESBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton sIMULACOESBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView sIMULACOESDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
  }
}