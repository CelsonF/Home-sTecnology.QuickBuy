using QuickBuy.Domain.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.ObjetoDeValor
{
    public class FormaPagamento
    {
    
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        //EhBoleto
        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        //EhCartaoCredito
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }

        //EhDeposito
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        //Não Definido
        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
