using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.View {
  public partial class CadEmpresa : Form {
    public CadEmpresa() {
      InitializeComponent();
    }

    private void TabelaEmpresa_Load(object sender, EventArgs e) {
      this.eMPRESA1TableAdapter.Fill(this.projetoFinalDataSetGeral.EMPRESA1);

    }

    private void EMPRESA1BindingNavigatorSaveItem_Click(object sender, EventArgs e) {
      this.Validate();
      this.eMPRESA1BindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.projetoFinalDataSetGeral);

    }

    private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
      if (this.Validate()) {
        this.eMPRESA1DataGridView.EndEdit();
        this.tableAdapterManager.UpdateAll(this.projetoFinalDataSetGeral);
      }
    }

    private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
      if (this.eMPRESA1BindingNavigator.BindingSource.Current != null) {
        this.Validate();
        this.eMPRESA1BindingNavigator.BindingSource.RemoveFilter();
        this.eMPRESA1BindingSource.EndEdit();
        this.tableAdapterManager.UpdateAll(this.projetoFinalDataSetGeral);
      }
    }
  }
}
