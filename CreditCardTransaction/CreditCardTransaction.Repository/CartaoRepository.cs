using CreditCardTransaction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Repository
{
    public class CartaoRepository : ICartaoRepository
    {
        private static List<Cartao> _cartaoList = new List<Cartao>();
        public void Atualizar(Cartao obj)
        {
            var cartao = CartaoRepository._cartaoList.FirstOrDefault(x => x.Id == obj.Id);
            CartaoRepository._cartaoList.Remove(cartao);
            CartaoRepository._cartaoList.Add(obj);

        }

        public void Excluir(Guid id)
        {
            var cartao = CartaoRepository._cartaoList.FirstOrDefault(x => x.Id == id);
            CartaoRepository._cartaoList.Remove(cartao);
        }

        public Cartao Obter(Guid id)
        {
            return CartaoRepository._cartaoList.FirstOrDefault(x => x.Id == id);
        }

       

       

        public List<Cartao> ObterTodos()
        {
            return CartaoRepository._cartaoList;
        }

        public void Salvar(Cartao obj)
        {
            CartaoRepository._cartaoList.Add(obj);
        }

        public List<Cartao> ObterPorCriterio(Expression<Func<Cartao, bool>> expression)
        {
            return CartaoRepository._cartaoList.Where(expression.Compile()).ToList();
        }

    }
}
