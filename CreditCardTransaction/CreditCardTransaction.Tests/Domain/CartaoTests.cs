using CreditCardTransaction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CreditCardTransaction.Tests.Domain
{
    public class CartaoTests
    {

        [Fact]
        public void DeveAutorizarTransacaoDeCartao()
        {
            //Arrange
            var IdCartao = Guid.NewGuid();
            var cartao = new Cartao()
            {
                Ativo = true,
                Bandeira = Bandeira.VISA,
                Limite = 50000L,
                Id = IdCartao
            };
            
            Transacao trans = new Transacao(cartao);
            trans.Itens.Add(new ItemProduto() { Produto = new Produto() { Nome = "XPTO", Valor = 5000L }, Quantidade = 1 });
            trans.Itens.Add(new ItemProduto() { Produto = new Produto() { Nome = "XPTO2", Valor = 15000L }, Quantidade = 1 } );

            //Act
            var result = cartao.Autorizar(trans);

            //Assert
            Assert.True(result != Guid.Empty);
            Assert.True(cartao.Limite == 30000L);

        }

        [Fact]
        public void DeveLancarExcecaoSeOCartaoNaoForAtivo()
        {
            var IdCartao = Guid.NewGuid();
            var cartao = new Cartao()
            {
                Ativo = false,
                Bandeira = Bandeira.VISA,
                Limite = 50000L,
                Id = IdCartao
            };

            Transacao trans = new Transacao(cartao);
            trans.Itens.Add(new ItemProduto() { Produto = new Produto() { Nome = "XPTO", Valor = 5000L }, Quantidade = 1 });

            var result = Assert.Throws<Exception>(() => 
            {
                cartao.Autorizar(trans);
            });

            Assert.True(result.Message == "Cartão não está ativo");

        }

        [Fact]
        public void DeveLancarExcecaoSeOLimiteForInsuficiente()
        {
            var IdCartao = Guid.NewGuid();
            var cartao = new Cartao()
            {
                Ativo = true,
                Bandeira = Bandeira.VISA,
                Limite = 10000L,
                Id = IdCartao
            };

            Transacao trans = new Transacao(cartao);
            trans.Itens.Add(new ItemProduto() { Produto = new Produto() { Nome = "XPTO", Valor = 15000L }, Quantidade = 1 });

            var result = Assert.Throws<Exception>(() =>
            {
                cartao.Autorizar(trans);
            });

            Assert.True(result.Message == "Valor da compra maior que o limite");

        }

        [Fact]
        public void DeveLancarExcecaoSeOIdCartaoForDiferenteNaTransacao()
        {
            var IdCartao = Guid.NewGuid();
            var cartao = new Cartao()
            {
                Ativo = true,
                Bandeira = Bandeira.VISA,
                Limite = 30000L,
                Id = IdCartao
            };

            var cartao2 = new Cartao()
            {
                Ativo = true,
                Bandeira = Bandeira.MASTERCARD,
                Limite = 150000L,
                Id = Guid.NewGuid()
            };


            Transacao trans = new Transacao(cartao2);

            trans.Itens.Add(new ItemProduto() { Produto = new Produto() { Nome = "XPTO", Valor = 15000L }, Quantidade = 1 });

            var result = Assert.Throws<Exception>(() =>
            {
                cartao.Autorizar(trans);
            });

            Assert.True(result.Message == "Para autorizar a compra a transacao deve ser a mesma do cartao no processo.");

        }
    }
}
