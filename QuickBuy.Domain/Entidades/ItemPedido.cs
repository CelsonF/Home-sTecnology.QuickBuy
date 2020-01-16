using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entity
{
   public class ItemPedido
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        
    }
}
