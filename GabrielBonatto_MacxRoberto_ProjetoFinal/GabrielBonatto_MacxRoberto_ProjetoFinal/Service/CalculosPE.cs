using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Service
{
  class CalculosPe
  {
    private Simulacoes simulacoes;

    public CalculosPe(Simulacoes simulacoes) {
      this.simulacoes = simulacoes;
    }

    public Double CalcularEquilibrio() {
      return simulacoes.CustoFixoTotal + (simulacoes.PrecoUnit - simulacoes.CustoVarUnit );
    }

    public Double CalcularReceitaEquilibrio() {
      return simulacoes.PrecoUnit * CalcularEquilibrio();
    }

    public Double CalcularCustoEquilibrio() {
      return simulacoes.CustoFixoTotal + (simulacoes.CustoVarUnit * CalcularEquilibrio());
    }

    public Double CalcularCustoTotal()
    {
      return simulacoes.CustoFixoTotal + (simulacoes.CustoVarUnit * simulacoes.QtdeVendaFinal);
    }

    public Double CalcularTotalDeVendas()
    {
      return simulacoes.PrecoUnit * simulacoes.QtdeVendaFinal;
    }

    public Double CalcularCustoUnit()
    {
      return CalcularCustoTotal() / simulacoes.QtdeVendaFinal;
    }

    public Double CalcularGanhoPerda()
    {
      return CalcularTotalDeVendas() - CalcularCustoTotal();
    }

  }
}
