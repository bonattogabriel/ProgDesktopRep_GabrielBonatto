using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielBonatto_MacxRoberto_ProjetoFinal.Model {
  class Empresa {
        public int EmpresaId { get; set; }
        public String RazaoSocial { get; set; }
        public String CNPJ { get; set; }
        public String Fone { get; set; }

        public Empresa(int empresaId, string razaoSocial, string cNPJ, string fone)
        {
            EmpresaId = empresaId;
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            Fone = fone;
        }

        public override bool Equals(object obj)
        {
            var empresa = obj as Empresa;
            return empresa != null &&
                   EmpresaId == empresa.EmpresaId &&
                   RazaoSocial == empresa.RazaoSocial &&
                   CNPJ == empresa.CNPJ &&
                   Fone == empresa.Fone;
        }

        public override int GetHashCode()
        {
            return 680593949 + EmpresaId.GetHashCode();
        }
    }
}
