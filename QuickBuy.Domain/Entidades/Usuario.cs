﻿using System.Collections.Generic;

namespace QuickBuy.Domain.Entity
{
    public class Usuario : Entidade
    {
        //Propriedades criadas utiliando Snippets prop
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        
        /// <summary>
        /// Um usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarAviso("Por favor , informe seu endereço de email.");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarAviso("Por favor , informe sua senha.");
            }
        }
    }
}
