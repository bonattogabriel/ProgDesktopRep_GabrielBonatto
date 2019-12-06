using GabrielBonatto_MacxRoberto_ProjetoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Service
{

  class CalculaResultadosSimulacao
  {
    private Simulacoes simulacoes;
    private PontoEquilibrio pontoEquilibrio;
    private List<ResultadoSimulacao> resultados;

    public CalculaResultadosSimulacao(Simulacoes simulacoes)
    {
      this.simulacoes = simulacoes;
      pontoEquilibrio = new CalculoPE(simulacoes).CalcularPontoDeEquilibrio();
      resultados = new List<ResultadoSimulacao>();
    }

    public List<ResultadoSimulacao> CalcularListaResultados()
    {
      CalculoItemResultado cauculoResultados = new CalculoItemResultado(simulacoes, pontoEquilibrio);
      resultados.Add(new InicializacaoResultadoSimulacao(simulacoes).CriarItemInicial());
      int count = 0;
      while (resultados[count].Quantidade < simulacoes.QtdeVendaFinal)
      {
        resultados.Add(cauculoResultados.
                        CalculularNovoResultado(resultados[count]));
        count++;
      }

      foreach (ResultadoSimulacao item in resultados)
      {
        Console.WriteLine(resultados.IndexOf(item) + "   " + item.Quantidade + "   "
            + item.CustoTotal + "'' " + item.TotalVendas + "''   " + item.GanhoPerda + "    " + item.CustoUnitario);
      }
      return resultados;
    }
  }
}
