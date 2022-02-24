﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Domain
{
    public class Transacao
    {
        public Guid Id { get; set; }

        public List<ItemProduto> Itens { get; set; }
        public Cartao Cartao { get; set; }
        public Decimal ValorTotal => this.ObterValorTotal();

        private Decimal ObterValorTotal() => Itens.Sum(x => x.Produto.Valor * x.Quantidade);

    }
}
