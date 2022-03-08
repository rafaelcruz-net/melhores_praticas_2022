using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Domain
{
    public class Cartao
    {
        public Guid Id { get; set; } 
        public string Numero { get; set; }
        public bool Ativo { get; set; } 
        public Decimal Limite { get; set; }

        public Bandeira Bandeira { get; set; }
        

        public Guid Autorizar(Transacao transacao)
        {
            if (this.Ativo == false)
                throw new Exception("Cartão não está ativo");

            if (transacao.ValorTotal > Limite)
                throw new Exception("Valor da compra maior que o limite");

            if (transacao.Cartao.Id != this.Id)
                throw new Exception("Para autorizar a compra a transacao deve ser a mesma do cartao no processo.");

            this.Limite -= transacao.ValorTotal;

            return Guid.NewGuid();

        }


    }

    public enum Bandeira
    {
        AMEX = 1,
        VISA = 2,
        MASTERCARD = 3,
        OUTROS = 4
    }
}
