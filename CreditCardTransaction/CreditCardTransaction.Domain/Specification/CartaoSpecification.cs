using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Domain.Specification
{
    public static class CartaoSpecification
    {
        public static Expression<Func<Cartao, bool>> GetCartaoPorBandeira(Bandeira bandeira) =>
            x => x.Bandeira == bandeira;

        public static Expression<Func<Cartao, bool>> GetCartaoPorBandeiraEValor(Bandeira bandeira, decimal limite) =>
            x => x.Bandeira == bandeira && x.Limite >= limite;

    }
}
