using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Model
{
  class PontoEquilibrio
  {
    public Double QtdePontoEquilibrio { get; set; }
    public Double ReceitaEquilibrio { get; set; }
    public Double CustoEquilibrio { get; set; }

    public PontoEquilibrio(double qtdePontoEquilibrio, double receitaEquilibrio, double custoEquilibrio)
    {
      QtdePontoEquilibrio = qtdePontoEquilibrio;
      ReceitaEquilibrio = receitaEquilibrio;
      CustoEquilibrio = custoEquilibrio;
    }
  }
}
