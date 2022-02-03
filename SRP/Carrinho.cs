using System.Collections.Generic;
using System.Linq;

namespace  SRP
{
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void AdicionaProdutoNoCarrinho(Produto produto, bool aplicaDesconto = false)
        {
            if (aplicaDesconto)
            {
                produto.CalculaDesconto();
            }

            this.Produtos.Add(produto);
        }

        public decimal CalculaTotalCarinho() => this.Produtos.Sum(c => c.Preco);

        public int TotalItensCarrinho() => this.Produtos.Count;

    }

}