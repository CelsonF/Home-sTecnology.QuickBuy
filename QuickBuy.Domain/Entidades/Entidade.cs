using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entity
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao 
        {
            get 
            {
                return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); 
            }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarAviso(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get 
            { 
                return !MensagemValidacao.Any(); 
            }
        }

    }
}
