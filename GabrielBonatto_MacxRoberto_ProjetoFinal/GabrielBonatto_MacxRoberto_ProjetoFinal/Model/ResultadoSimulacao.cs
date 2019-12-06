using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Model
{
  class ResultadoSimulacao
  {
    public int Quantidade { get; set; }
    public double CustoTotal { get; set; }
    public double TotalVendas { get; set; }
    public double GanhoPerda { get; set; }
    public double CustoUnitario { get; set; }
    public Boolean IsPontoEquilibrio { get; set; }

    public ResultadoSimulacao(int quantidade, 
      double custoTotal, 
      double totalVendas, 
      double ganhoPerda, 
      double custoUnitario,
      Boolean isPontoEquilibrio)
    {
      Quantidade = quantidade;
      CustoTotal = custoTotal;
      TotalVendas = totalVendas;
      GanhoPerda = ganhoPerda;
      CustoUnitario = custoUnitario;
      IsPontoEquilibrio = isPontoEquilibrio;
    }
  }
}
