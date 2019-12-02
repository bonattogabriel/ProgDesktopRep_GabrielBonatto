using GabrielBonatto_MacxRoberto_ProjetoFinal.Controller;
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
  public partial class CadEmpresa : Form {
    public CadEmpresa() {
      InitializeComponent();

    }

    private void Button1_Click(object sender, EventArgs e) {

    }

    private void BindingSource1_CurrentChanged(object sender, EventArgs e) {

    }

    private void CadEmpresa_Load(object sender, EventArgs e) {
      // TODO: esta linha de código carrega dados na tabela 'projetoFinalDataSetGeral.EMPRESA'. Você pode movê-la ou removê-la conforme necessário.
      this.eMPRESATableAdapter.Fill(this.projetoFinalDataSetGeral.EMPRESA);

    }

    private void EMPRESABindingNavigatorSaveItem_Click(object sender, EventArgs e) {
      this.Validate();
      this.eMPRESABindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.projetoFinalDataSetGeral);

    }
  }
}
