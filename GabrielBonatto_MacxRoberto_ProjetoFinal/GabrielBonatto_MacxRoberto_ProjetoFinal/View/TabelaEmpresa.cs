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
      // TODO: esta linha de código carrega dados na tabela 'projetoFinalDataSetEmpresa.EMPRESA'. Você pode movê-la ou removê-la conforme necessário.
      this.eMPRESATableAdapter.Fill(this.projetoFinalDataSetEmpresa.EMPRESA);

    }

    private void Button1_Click(object sender, EventArgs e) {
      new CadEmpresa().Show();
    }
  }
}
