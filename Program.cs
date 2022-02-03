using System;
using SRP;

namespace MelhoresPraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto g = new Geladeira("Geladeira", 999.99M);
            Produto f = new Fogao("Fogao", 499.99M);
            Produto t = new Produto("TV", 199.99M);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionaProdutoNoCarrinho(g);
            carrinho.AdicionaProdutoNoCarrinho(f, true);
            carrinho.AdicionaProdutoNoCarrinho(t, true);

            CarrinhoRepository repository = new CarrinhoRepository();

            repository.Save(carrinho);

            Console.WriteLine(carrinho.CalculaTotalCarinho());
            Console.WriteLine(carrinho.TotalItensCarrinho());


        }
    }
}
