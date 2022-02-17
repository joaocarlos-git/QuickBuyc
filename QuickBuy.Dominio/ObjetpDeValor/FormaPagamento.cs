using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetpDeValor

{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhPix
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Pix; }
        }
        public bool EhNaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

    }
}
