using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
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
  public partial class GridSimulacoes : Form {
    public GridSimulacoes() {
      InitializeComponent();
    }

    private void GridSimulacoes_Load(object sender, EventArgs e) {
      // TODO: esta linha de código carrega dados na tabela 'projetoFinalDataSet.SIMULACOES'. Você pode movê-la ou removê-la conforme necessário.
      this.sIMULACOESTableAdapter.Fill(this.projetoFinalDataSet.SIMULACOES);

    }

    private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      Simulacoes simulacao = new Simulacoes();
      simulacao.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());
      simulacao.CustoFixoTotal = Double.Parse(dataGridView1.Rows[e.RowIndex].Cells["CustoFixoTotal"].Value.ToString());
      simulacao.CustoVarUnit = Double.Parse(dataGridView1.Rows[e.RowIndex].Cells["CustoVarUnit"].Value.ToString());
      simulacao.IncrementoUnit = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["IncrementoUnit"].Value.ToString());
      simulacao.PrecoUnit = Double.Parse(dataGridView1.Rows[e.RowIndex].Cells["PrecoUnit"].Value.ToString());
      simulacao.QtdeVendaFinal = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["QtdeVendaFinal"].Value.ToString());
      simulacao.QtdeVendaInicial = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["QtdeVendaInicial"].Value.ToString());
      new PontoDeEquilibrio(simulacao).Show();
    }
  }
}
