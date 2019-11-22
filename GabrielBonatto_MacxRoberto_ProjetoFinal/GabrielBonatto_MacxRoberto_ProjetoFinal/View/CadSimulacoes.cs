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
  public partial class CadSimulacoes : Form {
    public CadSimulacoes() {
      InitializeComponent();
    }

    private void SIMULACOESBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
      this.Validate();
      this.sIMULACOESBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.projetoFinalDataSet);

    }

    private void CadSimulacoes_Load(object sender, EventArgs e) {
      // TODO: esta linha de código carrega dados na tabela 'projetoFinalDataSet.SIMULACOES'. Você pode movê-la ou removê-la conforme necessário.
      this.sIMULACOESTableAdapter.Fill(this.projetoFinalDataSet.SIMULACOES);

    }

    private void SIMULACOESDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }
  }
}
