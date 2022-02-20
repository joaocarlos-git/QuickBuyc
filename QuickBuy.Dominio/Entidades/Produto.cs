namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome deve ser preenchido");
            if (string.IsNullOrEmpty(Descricao))
                 AdicionarCritica("Descrição deve ser preenchido");
            if (Preco == 0)
                AdicionarCritica("Preço deve ser preenchido");
        }
    }
}
