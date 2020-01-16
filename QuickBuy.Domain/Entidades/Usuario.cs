using System.Collections.Generic;

namespace QuickBuy.Domain.Entity
{
    public class Usuario
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
    }
}
