using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Domain
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Decimal Valor { get; set; }
    }
}
