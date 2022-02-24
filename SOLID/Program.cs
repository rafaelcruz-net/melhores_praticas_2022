using System;
using LSP;
using ISP;
using DIP;

namespace MelhoresPraticas
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Produto g = new Geladeira("Geladeira", 999.99M);
        //     Produto f = new Fogao("Fogao", 499.99M);
        //     Produto t = new Produto("TV", 199.99M);

        //     Carrinho carrinho = new Carrinho();

        //     carrinho.AdicionaProdutoNoCarrinho(g);
        //     carrinho.AdicionaProdutoNoCarrinho(f, true);
        //     carrinho.AdicionaProdutoNoCarrinho(t, true);

        //     CarrinhoRepository repository = new CarrinhoRepository();

        //     repository.Save(carrinho);

        //     Console.WriteLine(carrinho.CalculaTotalCarinho());
        //     Console.WriteLine(carrinho.TotalItensCarrinho());

        // }

        static void Main(string[] args)
        {
            IMessage message = new SMS();
            message.Send();

            IMessage message1 = new Email();
            message1.Send();

            IMessage message2 = new Telefone();
            message2.Send();


        }

        public static void ObterCaracteristicaProduto(Produto produto)
        {
            Console.WriteLine(produto.ObterCaracteristica());
        }

    }
}
