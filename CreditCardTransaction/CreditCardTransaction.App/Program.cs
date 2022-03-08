// See https://aka.ms/new-console-template for more information

using CreditCardTransaction.Domain;
using CreditCardTransaction.Repository;

Produto produto = new Produto();
produto.Nome = "Geladeira";
produto.Valor = 5000;
produto.Id = Guid.NewGuid();

IRepository<Produto> produtoRepository = new ProdutoRepository();
produtoRepository.Salvar(produto);

var produto2 = produtoRepository.Obter(produto.Id);

var produtos = produtoRepository.ObterTodos();

System.Console.WriteLine(produtos.Count);
