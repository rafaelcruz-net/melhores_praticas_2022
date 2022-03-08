using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Repository
{
    public interface IRepository<T>
    {
        void Salvar(T obj);
        void Atualizar(T obj);
        void Excluir(Guid id);
        T Obter(Guid id);
        List<T> ObterTodos();

        List<T> ObterPorCriterio(Expression<Func<T, bool>> expression);

    }
}
