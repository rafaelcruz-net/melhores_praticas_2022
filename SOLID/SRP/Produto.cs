namespace SRP
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        private const decimal DESCONTO_PADRAO = .1m;

        public Produto(string nomeProduto, decimal precoProduto)
        {
            this.Nome = nomeProduto;
            this.Preco = precoProduto;
        }

        public virtual void CalculaDesconto(decimal desconto = 0.1M)
        {
            this.Preco = this.Preco * desconto;
        }

    }

    public class Geladeira : Produto 
    {
        public Geladeira(string nomeProduto, decimal precoProduto): base(nomeProduto, precoProduto)
        {
            
        }

        public override void CalculaDesconto(decimal desconto = 0.1M)
        {
            this.Preco = this.Preco * .8m;
        }
    }

    public class Fogao : Produto
    {
        public Fogao(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {

        }

        public override void CalculaDesconto(decimal desconto = 0.1M)
        {
            this.Preco = this.Preco * .75m;
        }
    }


}