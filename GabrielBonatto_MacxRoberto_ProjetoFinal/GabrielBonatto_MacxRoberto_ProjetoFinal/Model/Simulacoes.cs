using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Model {
  class Simulacoes {

    private long? Id { get; set; }
    private double CustoFixoTotal { get; set; }
    private double CustoVarUnit { get; set; }
    private double PrecoUnit { get; set; }
    private int QtdeVendaInicial { get; set; }
    private int QtdeVendaFinal { get; set; }
    private int IncrementoUnit { get; set; }
    private Empresa Empresa { get; set; }

    public Simulacoes(long? id,
      double custoFixoTotal,
      double custoVarUnit,
      double precoUnit,
      int qtdeVendaInicial,
      int qtdeVendaFinal,
      int incrementoUnit,
      Empresa empresa) {
      Id = id;
      CustoFixoTotal = custoFixoTotal;
      CustoVarUnit = custoVarUnit;
      PrecoUnit = precoUnit;
      QtdeVendaInicial = qtdeVendaInicial;
      QtdeVendaFinal = qtdeVendaFinal;
      IncrementoUnit = incrementoUnit;
      Empresa = empresa ?? throw new ArgumentNullException(nameof(empresa));
    }

    public override bool Equals(object obj) {
      return obj is Simulacoes simulacoes &&
             EqualityComparer<long?>.Default.Equals(Id, simulacoes.Id) &&
             CustoFixoTotal == simulacoes.CustoFixoTotal &&
             CustoVarUnit == simulacoes.CustoVarUnit &&
             PrecoUnit == simulacoes.PrecoUnit &&
             QtdeVendaInicial == simulacoes.QtdeVendaInicial &&
             QtdeVendaFinal == simulacoes.QtdeVendaFinal &&
             IncrementoUnit == simulacoes.IncrementoUnit &&
             EqualityComparer<Empresa>.Default.Equals(Empresa, simulacoes.Empresa);
    }

    public override int GetHashCode() {
      var hashCode = 1418928831;
      hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Id);
      hashCode = hashCode * -1521134295 + CustoFixoTotal.GetHashCode();
      hashCode = hashCode * -1521134295 + CustoVarUnit.GetHashCode();
      hashCode = hashCode * -1521134295 + PrecoUnit.GetHashCode();
      hashCode = hashCode * -1521134295 + QtdeVendaInicial.GetHashCode();
      hashCode = hashCode * -1521134295 + QtdeVendaFinal.GetHashCode();
      hashCode = hashCode * -1521134295 + IncrementoUnit.GetHashCode();
      hashCode = hashCode * -1521134295 + EqualityComparer<Empresa>.Default.GetHashCode(Empresa);
      return hashCode;
    }
  }
}
