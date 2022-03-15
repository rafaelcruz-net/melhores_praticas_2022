// See https://aka.ms/new-console-template for more information
using CreditCardTransaction.Domain;
using CreditCardTransaction.Domain.Specification;
using CreditCardTransaction.Repository;

namespace CreditCardTransaction.AppConsole;

public class Program
{
    public static void Main(String[] args)
    {
        Produto produto = new Produto();
        produto.Nome = "Geladeira";
        produto.Valor = 5000;
        produto.Id = Guid.NewGuid();

        IRepository<Produto> produtoRepository = new ProdutoRepository();
        produtoRepository.Salvar(produto);

        var produto2 = produtoRepository.Obter(produto.Id);

        var produtos = produtoRepository.ObterTodos();

        var produtos3 = produtoRepository.ObterPorCriterio(x => x.Valor > 1000);

        System.Console.WriteLine(produtos.Count);

        Cartao cartao = new Cartao();
        cartao.Numero = "111111";
        cartao.Ativo = true;
        cartao.Limite = 10_000_000;
        cartao.Bandeira = Bandeira.AMEX;

        IRepository<Cartao> cartaoRepository = new CartaoRepository();

        cartaoRepository.Salvar(cartao);

        var cartao2 = cartaoRepository.ObterPorCriterio(CartaoSpecification.GetCartaoPorBandeiraEValor(Bandeira.AMEX, 1_000_000));


    }
}