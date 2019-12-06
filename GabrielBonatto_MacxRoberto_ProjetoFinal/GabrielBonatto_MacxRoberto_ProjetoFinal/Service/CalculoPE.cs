using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Service
{
  /// <summary>
  /// Nao esta completamente implementada
  /// - foi adicionado o calculo dos valores para um 
  /// novo item do resultado da simulaçao com base nos 
  /// dados da simulaçao e no resultado atual da simulaçao
  /// - Falta o calculo de ponto de equilibrio.
  /// </summary>
  class CalculoPE
  {
    private Simulacoes simulacoes;

    public CalculoPE(Simulacoes simulacoes) {
      this.simulacoes = simulacoes;
    }

    public PontoEquilibrio CalcularPontoDeEquilibrio()
    {
      return new PontoEquilibrio(CalcularEquilibrio(), CalcularReceitaEquilibrio(), CalcularCustoEquilibrio());
    }

    private Double CalcularEquilibrio() {
      return simulacoes.CustoFixoTotal / (simulacoes.PrecoUnit - simulacoes.CustoVarUnit);
    }

    private Double CalcularReceitaEquilibrio() {
      return simulacoes.PrecoUnit * CalcularEquilibrio();
    }

    private Double CalcularCustoEquilibrio() {
      return simulacoes.CustoFixoTotal + (simulacoes.CustoVarUnit * CalcularEquilibrio());
    }

  }
}
