using System.Collections.Generic;
using System.Linq;

namespace SRP_OLD
{
    public class Produto
    {
        public string Nome { get; set; }     
        public decimal Preco { get; set; }

        public List<Produto> Carrinho { get; set; }

        public Produto(string nomeProduto, decimal precoProduto)
        {
            this.Nome = nomeProduto;
            this.Preco = precoProduto;
        }

        public void CalculaDesconto(decimal desconto = 0.1M) 
        {
            this.Preco = this.Preco * desconto;
        }

        public void AdicionaProdutoNoCarrinho(Produto produto, bool aplicaDesconto = false) 
        {
            if (aplicaDesconto) {
                produto.CalculaDesconto();
            }

            this.Carrinho.Add(produto);
        }

        public void Save() {
            //.. Adiciona o produto no banco de dados
        }

        public void GetProdutoCarinho() {
            // retorna o produto salvo do carinho
        }

        public decimal CalculaTotalCarinho() => this.Carrinho.Sum(c => c.Preco);


    }    
}

