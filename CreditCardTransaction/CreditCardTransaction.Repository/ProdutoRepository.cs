using CreditCardTransaction.Domain;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Repository
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private static List<Produto> _produtos = new List<Produto>();


        public void Atualizar(Produto obj)
        {
            var produto = ProdutoRepository._produtos.FirstOrDefault(x => x.Id == obj.Id);
            ProdutoRepository._produtos.Remove(produto);
            ProdutoRepository._produtos.Add(obj);
        }

        public void Excluir(Guid id)
        {
            var produto = ProdutoRepository._produtos.FirstOrDefault(x => x.Id == id);
            ProdutoRepository._produtos.Remove(produto);
        }

        public Produto Obter(Guid id)
        {
            return ProdutoRepository._produtos.FirstOrDefault(x => x.Id == id);
        }


        public List<Produto> ObterTodos()
        {
            return ProdutoRepository._produtos;
        }

        public void Salvar(Produto obj)
        {
            ProdutoRepository._produtos.Add(obj);
        }

        public List<Produto> ObterPorCriterio(Expression<Func<Produto, bool>> expression)
        {
            return ProdutoRepository._produtos.Where(expression.Compile()).ToList();
        }

    }
}
