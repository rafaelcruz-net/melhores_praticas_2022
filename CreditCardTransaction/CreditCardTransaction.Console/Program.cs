using CreditCardTransaction.Domain;
using CreditCardTransaction.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Produto produto = new Produto();
produto.Nome = "Geladeira";
produto.Valor = 5000;
produto.Id = Guid.NewGuid();

IRepository<Produto> produtoRepository = new ProdutoRepository();
produtoRepository.Salvar(produto);

var produto2 = produtoRepository.Obter(produto.Id);

var produtos = produtoRepository.ObterTodos();

System.Console.WriteLine(produtos.Count);

