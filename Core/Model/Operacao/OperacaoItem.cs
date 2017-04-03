using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.Produto;

namespace Core.Model.Operacao
{
    public class OperacaoItem
    {
        public int Id { get; set; }
        public Produto.Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
