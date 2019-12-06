using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Service
{

  class InicializacaoResultadoSimulacao
  {
    private Simulacoes simulacoes;

    public InicializacaoResultadoSimulacao(Simulacoes simulacoes)
    {
      this.simulacoes = simulacoes;
    }

    public ResultadoSimulacao CriarItemInicial()
    {
      int vendaInicial = simulacoes.QtdeVendaInicial;
      double custoTotal = simulacoes.CustoFixoTotal + (simulacoes.CustoVarUnit * simulacoes.QtdeVendaInicial);
      double totalVendas = simulacoes.PrecoUnit * simulacoes.QtdeVendaInicial;
      double custoUnit = custoTotal / simulacoes.QtdeVendaInicial;
      double ganhoPerda = totalVendas - custoTotal;

      return new ResultadoSimulacao(vendaInicial, custoTotal, totalVendas,
                                   ganhoPerda, custoUnit);
    }
  }
}
