using CreditCardTransaction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardTransaction.Repository
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private static List<Cliente> _clienteList = new List<Cliente>();

        public void Atualizar(Cliente obj)
        {
            var clienteOld = ClienteRepository._clienteList.FirstOrDefault(x => x.Id == obj.Id);
            ClienteRepository._clienteList.Remove(clienteOld);
            ClienteRepository._clienteList.Add(obj);
        }

        public void Excluir(Guid id)
        {
            var clienteOld = ClienteRepository._clienteList.FirstOrDefault(x => x.Id == id);
            ClienteRepository._clienteList.Remove(clienteOld);
        }

        public Cliente Obter(Guid id)
        {
            return ClienteRepository._clienteList.FirstOrDefault(x => x.Id == id);
        }

        public List<Cliente> ObterTodos()
        {
            return ClienteRepository._clienteList;
        }

        public void Salvar(Cliente obj)
        {
            ClienteRepository._clienteList.Add(obj);
        }

        public List<Cliente> ObterPorCriterio(Expression<Func<Cliente, bool>> expression)
        {
            return ClienteRepository._clienteList.Where(expression.Compile()).ToList();
        }
    }
}
