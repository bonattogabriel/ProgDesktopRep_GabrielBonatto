using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
using GabrielBonatto_MacxRoberto_ProjetoFinal.Service;
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
  public partial class Main : Form {
    public Main() {
      InitializeComponent();
    }

    private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e) {
      new TabelaEmpresa().Show();
    }

    private void SimulaçõesToolStripMenuItem_Click(object sender, EventArgs e) {
      new CadSimulacoes().Show();
    }

    private void VisualizarTabelaToolStripMenuItem_Click(object sender, EventArgs e) {
      new GridSimulacoes().Show();
      //new PontoDeEquilibrio(new Simulacoes(1, 1000000.00, 12345.67, 23456.78, 10, 150, 10, new Empresa(1, "teste", "1231231", "123123"))).Show();
    }
  }
}
