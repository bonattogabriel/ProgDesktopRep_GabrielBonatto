using GabrielBonatto_MacxRoberto_ProjetoFinal.View;
using System;
using System.Windows.Forms;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal {
  static class Program {
    /// <summary>
    /// Ponto de entrada principal para o aplicativo.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new CadEmpresa());
    }
  }
}
