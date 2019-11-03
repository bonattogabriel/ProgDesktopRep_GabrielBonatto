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
  public partial class TabelaSimulacoes : Form {
    public TabelaSimulacoes() {
      InitializeComponent();
    }

    private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void TabelaSimulacoes_Load(object sender, EventArgs e) {
      // TODO: esta linha de código carrega dados na tabela 'projetoFinalDataSet.SIMULACOES'. Você pode movê-la ou removê-la conforme necessário.
      this.sIMULACOESTableAdapter.Fill(this.projetoFinalDataSet.SIMULACOES);

    }
  }
}
