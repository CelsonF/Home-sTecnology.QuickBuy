using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entity
{
   public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
            {
                AdicionarAviso("Não foi possivel identificar qual é o Produto.");
            }

            if (Quantidade == 0)
            {
                AdicionarAviso("Quantidade de produto não informada.");
            }
        }
    }
}
