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
  public partial class TabelaEmpresa : Form {
    public TabelaEmpresa() {
      InitializeComponent();
    }

    private void TabelaEmpresa_Load(object sender, EventArgs e) {
      // TODO: esta linha de código carrega dados na tabela 'projetoFinalDataSetGeral.EMPRESA1'. Você pode movê-la ou removê-la conforme necessário.
      this.eMPRESA1TableAdapter.Fill(this.projetoFinalDataSetGeral.EMPRESA);

    }

    private void Button1_Click(object sender, EventArgs e) {
      new TabelaEmpresa().Show();
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
  }
}
