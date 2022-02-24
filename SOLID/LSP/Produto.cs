namespace LSP
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public abstract string ObterCaracteristica();

    }
    
}

