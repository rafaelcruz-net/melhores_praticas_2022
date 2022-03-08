using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Domain
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Transacao> Transacoes { get; set; }
        public List<Cartao> Cartoes { get; set; }

        public Transacao RealizarCompra(List<ItemProduto> itens, Cartao cartao)
        {
            if (Cartoes.Any(x => x.Id == cartao.Id) == false)
                throw new Exception("Esse cartão não está associado a esse cliente");

            var transacao = new Transacao();
            transacao.Cartao = cartao;
            transacao.Itens.AddRange(itens);
            transacao.Id = cartao.Autorizar(transacao);

            this.Transacoes.Add(transacao);

            return transacao;
        }

    }
}
