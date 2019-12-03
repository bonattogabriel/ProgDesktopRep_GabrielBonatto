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
  class CalculosPe
  {
    private Simulacoes simulacoes;
    private ResultadoSimulacao resultadoAtual;

    public CalculosPe(Simulacoes simulacoes) {
      this.simulacoes = simulacoes;
    }

    public ResultadoSimulacao CalculularNovoResultado(ResultadoSimulacao resultadoAtual)
    {
      this.resultadoAtual = resultadoAtual;
      return new ResultadoSimulacao(CalcularQuantidadeAtual(),
                                    CalcularCustoTotal(),
                                    CalcularTotalDeVendas(),
                                    CalcularGanhoPerda(),
                                    CalcularCustoUnitario() );
    }
 
    private int CalcularQuantidadeAtual()
    {
      return resultadoAtual.Quantidade + simulacoes.IncrementoUnit;
    }

    private Double CalcularCustoTotal()
    {
      return simulacoes.CustoFixoTotal + (simulacoes.CustoVarUnit * CalcularQuantidadeAtual());
    }

    private Double CalcularTotalDeVendas()
    {
      return simulacoes.PrecoUnit * CalcularQuantidadeAtual();
    }

    private Double CalcularGanhoPerda()
    {
      return CalcularTotalDeVendas() - CalcularCustoTotal();
    }

    private Double CalcularCustoUnitario()
    {
      return CalcularCustoTotal() / CalcularQuantidadeAtual();
    }


    // nao estao sendo usadas pois ainda n estamos controlando o PE
    private Double CalcularEquilibrio() {
      return simulacoes.CustoFixoTotal + (simulacoes.PrecoUnit - resultadoAtual.Quantidade );
    }

    private Double CalcularReceitaEquilibrio() {
      return simulacoes.PrecoUnit * CalcularEquilibrio();
    }

    private Double CalcularCustoEquilibrio() {
      return simulacoes.CustoFixoTotal + (simulacoes.CustoVarUnit * CalcularEquilibrio());
    }

  }
}
