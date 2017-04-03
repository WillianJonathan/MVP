using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.Pessoa;

namespace Core.Model.Operacao
{
    public class Operacao
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public DateTime DataHoraOperacao { get; set; }
        public List<OperacaoItem> Items { get; set; }
        public Pessoa.Pessoa Cliente { get; set; }
    }

}
