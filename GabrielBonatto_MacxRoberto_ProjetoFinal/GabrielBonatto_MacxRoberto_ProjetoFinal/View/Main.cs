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
  public partial class Main : Form {
    public Main() {
      InitializeComponent();

    }

    private void Main_Load(object sender, EventArgs e) {

    }

    private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e) {
      new TabelaEmpresa().Show();
    }

    private void SimulaçõesToolStripMenuItem_Click(object sender, EventArgs e) {
      new CadSimulacoes().Show();
    }

    private void VisualizarTabelaToolStripMenuItem_Click(object sender, EventArgs e) {
      new TabelaSimulacoes().Show();
    }
  }
}
