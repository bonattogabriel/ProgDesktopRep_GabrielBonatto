﻿using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
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

    public PontoDeEquilibrio(IList<ResultadoSimulacao> listData) {
      InitializeComponent();
      dataGridView1.DataSource = listData;
    }

    private void ListBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }
  }
}