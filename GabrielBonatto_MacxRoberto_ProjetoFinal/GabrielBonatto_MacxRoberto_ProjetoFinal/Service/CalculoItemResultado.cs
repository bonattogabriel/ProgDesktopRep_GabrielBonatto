using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Service
{
  class CalculoItemResultado
  {
    private Simulacoes simulacoes;
    private PontoEquilibrio pontoEquilibrio;
    private ResultadoSimulacao resultadoAtual;

    public CalculoItemResultado(Simulacoes simulacoes, PontoEquilibrio pontoEquilibrio)
    {
      this.simulacoes = simulacoes;
      this.pontoEquilibrio = pontoEquilibrio;
    }

    public ResultadoSimulacao CalculularNovoResultado(ResultadoSimulacao resultadoAtual)
    {
      this.resultadoAtual = resultadoAtual;
      return new ResultadoSimulacao(CalcularQuantidadeAtual(),
                                    CalcularCustoTotal(),
                                    CalcularTotalDeVendas(),
                                    CalcularGanhoPerda(),
                                    CalcularCustoUnitario(),
                                    VerificarPontoEquilibrio());
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

    private Boolean VerificarPontoEquilibrio()
    {
      return CalcularQuantidadeAtual() == pontoEquilibrio.QtdePontoEquilibrio &&
             CalcularCustoTotal()      == pontoEquilibrio.CustoEquilibrio     &&
             CalcularTotalDeVendas()   == pontoEquilibrio.ReceitaEquilibrio;
    }
  }
}
