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
  public partial class PontoDeEquilibrio : Form {
    public PontoDeEquilibrio(Simulacoes simulacao) {
      InitializeComponent();

      this.txtCustoTotal.Text = simulacao.CustoFixoTotal.ToString();
      this.txtCustoVariável.Text = simulacao.CustoVarUnit.ToString();
      this.txtPreçoVenda.Text = simulacao.PrecoUnit.ToString();

      dataGridView1.DataSource = new CalculaResultadosSimulacao(simulacao).CalcularListaResultados();
    }
  }
}
